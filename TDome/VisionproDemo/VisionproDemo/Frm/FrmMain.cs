using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cognex.VisionPro;
using Cognex.VisionPro.CalibFix;
using Cognex.VisionPro.ToolBlock;

using VisionproDemo.Properties;

using S7.Net;

namespace VisionproDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //传递图片和坐标的委托 用于九点标定使用
        public delegate void FrmNPointInfoDelegate(string msg, ICogImage image);
        public static event FrmNPointInfoDelegate FrmNPointInfoEvent;


        double dx = 0;
        double dy = 0;
        double da = 0;

        #region 生产数据
        int total, okNum;
        double yield;
        ICogImage mImage;//接收相机拍照图片
        /// <summary>
        /// 存储图像的集合
        /// </summary>
        Queue<ICogImage> imageQue = new Queue<ICogImage>();
        int imgSaveDays;
        DateTime lastDele;
        #endregion

       
        Cls_Config config = Cls_Config.GetInstance();//配置文件对象
        Vision mVision =  new Vision();//视觉类对象
        //Vision mVision = Vision.GetInstance();//视觉类对象
        SerialPort sp;//串口
        Socket clientSocket;//客户端
        //保存数据的类对象
        FileOperator fileOperator = new FileOperator();
        //传递信息的集合
        List<DataInfo> dataInfoList;

        //声明PLC
        /// <summary>
        /// 通信的PLC
        /// </summary>
        SiemensPLC plc;

        Thread receivThread; 
        Thread inspectThread;
        //PLC线程
        Thread plcThread;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            receivThread = new Thread(ReceiveServerMsg);
            receivThread.IsBackground = true;
          

            dataInfoList = new List<DataInfo>();
            PrintMessage("程序启动!");
            PrintMessage("读取配置文件!");
            config.LoadConfig();//读取配置文件
            total = config.ProductTotal;
            okNum = config.ProductOkNum;
            this.lbl_result.Text = string.Empty;
            this.lbl_result.BackColor = Color.Transparent;

            //设置自动生成列为false
            dataGridView1.AutoGenerateColumns = false;
            //设置dataGridView1列宽填充控件
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            PrintMessage("加载VPP！");
            if(mVision.LoadToolBlock())
                PrintMessage("VPP加载完成！");
            else
                PrintMessage("VPP加载失败！");

            UpdateProduction();//更新产能

            SetCommunication();//设置通信
           
            timer1.Start();
        }

        #region 窗体按钮事件
        //相机1设置
        private void 相机1_Click(object sender, EventArgs e)
        {
            FrmCam frmCam = new FrmCam();
            frmCam.LoadVppEvent += Frm_LoadVppEvent;
            frmCam.vision = this.mVision;
            frmCam.ShowDialog();
            frmCam.LoadVppEvent -= Frm_LoadVppEvent;
        }
        //相机2
        private void 相机2toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCam2 frm = new FrmCam2();
            frm.frmVision = this.mVision;//传递对象
            frm.LoadVppEvent += Frm_LoadVppEvent;
            frm.ShowDialog();//打开窗体
            frm.LoadVppEvent -= Frm_LoadVppEvent;
        }
        //编辑VPP
        private void tsmEditTB_Click(object sender, EventArgs e)
        {
            FrmEditTB frmEditTB = new FrmEditTB();
            frmEditTB.vision = this.mVision;
            frmEditTB.LoadVppEvent += Frm_LoadVppEvent;
            frmEditTB.ShowDialog();
            frmEditTB.LoadVppEvent -= Frm_LoadVppEvent;
        }
        //复检VPP
        private void 复检toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRecheck frm = new FrmRecheck();
            frm.LoadVppEvent += Frm_LoadVppEvent;
            frm.frmVision = this.mVision;
            frm.ShowDialog();
            frm.LoadVppEvent -= Frm_LoadVppEvent;
        }
        //标定页面
        private void 标定toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmNPoint frmNPoint = new FrmNPoint();
            frmNPoint.LoadVppEvent += Frm_LoadVppEvent;
            frmNPoint.mVision = this.mVision;
            frmNPoint.ShowDialog();
            frmNPoint.LoadVppEvent -= Frm_LoadVppEvent;
        }
        //参数设置
        private void tsmSetParam_Click(object sender, EventArgs e)
        {
            FrmParam frmParam = new FrmParam();
            frmParam.ShowDialog();
        }
        //编辑标定作业
        private void 编辑标定作业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNPointTool frmNPointTool = new FrmNPointTool();
            frmNPointTool.LoadVppEvent += Frm_LoadVppEvent;
            frmNPointTool.frmVision = mVision;
            frmNPointTool.ShowDialog();
            frmNPointTool.LoadVppEvent -= Frm_LoadVppEvent;

        }

        //重新加载VPP
        private void Frm_LoadVppEvent()
        {
            mVision.LoadToolBlock();//重新加载一次Vpp

        }

        //保存图片设置
        private void tsmSaveImage_Click(object sender, EventArgs e)
        {
            FrmSaveSetting frmSave = new FrmSaveSetting();
            frmSave.ShowDialog();
        }
        //通信设置
        private void tsmCommunication_Click(object sender, EventArgs e)
        {
            FrmCommuincation frmCommuincation = new FrmCommuincation();
            frmCommuincation.ShowDialog();
        }

        //清除生产信息btn
        private void btnClear_Click(object sender, EventArgs e)
        {
            okNum = 0;
            total = 0;
            UpdateProduction();
            dataInfoList.Clear();
            UpdateDgwHandle(dataInfoList);
        }

        //窗体关闭事件
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            receivThread.Abort();
            //plc释放
            plcThread.Abort();
            plc.DisconnectPlc();
            mVision.CloseCam();//关闭相机
        }
        #endregion


        #region 保存图片和数据
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="state"></param>
        private void SaveData(object state)
        {
            string data = state.ToString();
            fileOperator.SaveData(data);
        }

        /// <summary>
        /// 保存原始图像
        /// </summary>
        /// <param name="imageInfo">图片信息</param>
        private void SaveRawImage(object imageInfo)
        {
            ImageInfo info = (ImageInfo)imageInfo;
            fileOperator.SaveRawImage(info.Image8Grey, info.ImageName);
            fileOperator.SaveDealImage(info.ImageDisplay, info.ImageName);
        }
        #endregion

        /// <summary>
        /// 设置通信
        /// </summary>
        private void SetCommunication()
        {
            //sp = new SerialPort();
            //sp.PortName = config.ComName;
            //sp.BaudRate = config.ComBoundrate;
            //sp.Parity = (Parity)config.ComParity;
            //sp.DataBits = config.ComDataBits;
            //sp.StopBits = (StopBits)config.ComStopBits;
            //sp.Open();

            //初始化客户端
            //clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPAddress IP = IPAddress.Parse(config.TcpIP);
            //int port = config.TcpPort;
            //IPEndPoint iPEndPoint = new IPEndPoint(IP, port);

            //ConnectServer();//连接服务器
            //ThreadPool.QueueUserWorkItem(ReceiveServerMsg, clientSocket);
            //receivThread.Start(clientSocket);

            //连接PLC
            plc = new SiemensPLC(CpuType.S71200, "192.168.8.10", 0, 1);
            plc.ConnectPlc();

            plcThread = new Thread(ReadPlc);
            plcThread.IsBackground = true;
            plcThread.Start();
        }

        //线程刷新读取PLC信息
        private void ReadPlc()
        {
            while (true)
            {
                Thread.Sleep(500);

                try
                {
                    if (!plc.PlcIsConn())
                    {

                        //ConnectPlcAsync();
                        plc.ConnectPlc();
                    }
                    else
                    {
                        //ReadT1Async();
                        //ReadT2Async();
                        //ReadT3Async();

                        //bool 类型 DBX  int类型 DBW   其余类型 DBD
                        if ((bool)plc.Read("DB14.DBX0.0"))//T1拍照信号
                        {
                            plc.Write("DB14.DBX14.2", false);//复位T2接收数据信号
                            plc.Write("DB14.DBX0.1", true);//T1接收拍照信号反馈
                            RunT1();
                        }

                        if ((bool)plc.Read("DB14.DBX14.0"))//T2拍照信号
                        {
                            plc.Write("DB14.DBX0.2", false);//复位T1接收数据信号
                            plc.Write("DB14.DBX14.1", true);//T2接收拍照信号反馈
                            RunT2();
                        }

                        if ((bool)plc.Read("DB14.DBX28.0"))//T3拍照信号
                        {
                            plc.Write("DB14.DBX28.1", true);//拍照完成
                            RunReckeck();
                        }

                        UpdatePlcStatus();//更新plc连接状态
                    }
                }
                catch (Exception ex)
                {

                    
                }
               

               

               
            }
        }
        //连接PLC方法
        private async void ConnectPlcAsync()
        {
            try
            {
                await Task.Run(() => { plc.ConnectPlc(); });
            }
            catch (Exception ex) { }
        }
      
        //读取
        private async void ReadT1Async()
        {
            await Task.Run(() =>
            {
                try
                {
                    if ((bool)plc.Read("DB14.DBX0.0"))//T1拍照信号
                    {
                        plc.Write("DB14.DBX0.1", true);//拍照完成
                        RunT1();

                    }

                }
                catch (Exception) { }
            });
        }
        //读取
        private async void ReadT2Async()
        {
            await Task.Run(() =>
            {
                try
                {
                    if ((bool)plc.Read("DB14.DBX14.0"))//T2拍照信号
                    {
                        plc.Write("DB14.DBX14.1", true);//拍照完成
                        RunT2();
                    }
                        
                }
                catch (Exception) { }
            });
        } //读取  
        private async void ReadT3Async()
        {
            await Task.Run(() =>
            {
                try
                {
                    if ((bool)plc.Read("DB14.DBX28.0"))//T3拍照信号
                        RunReckeck();
                }
                catch (Exception) { }
            });
        }
        #region 通信
        /// <summary>
        /// 连接服务器
        /// </summary>
        private void ConnectServer()
        {
            try
            {
                //IP地址和端口号
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(config.TcpIP), config.TcpPort);
                PrintMessage("连接服务器！");
                clientSocket.Connect(iPEndPoint);//连接服务器哦

            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
            }
        }

        /// <summary>
        /// 接收服务器信息
        /// </summary>
        /// <param name="state"></param>
        private void ReceiveServerMsg(object state)
        {
            Socket socket = (Socket)state;//传过来的对象，转成Socket类型
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024];//创建字节数组
                    int r = socket.Receive(buffer);//获取读取到的字节数
                    if (r == 0) break;// =0 没有读到信息 跳出
                    string msg = Encoding.Default.GetString(buffer, 0, r); // 转成string类型
                    PrintMessage("接收服务器信息: " + msg, true);
                    //收到T1信号 拍照
                    if (msg.Contains("T1"))
                    {
                        RunT1();
                    }
                    if (msg.Contains("T2"))
                    {
                        RunT2();
                    }
                    if (msg.Contains("C1"))//九点标定
                    {
                        mVision.DownCam.Run();//拍照
                        mImage = mVision.DownCam.OutputImage;
                        if (FrmNPointInfoEvent != null)
                        {
                            FrmNPointInfoEvent.Invoke(msg, mImage);
                        }
                    }
                    if (msg.Contains("RC"))//旋转中心
                    {
                        mVision.DownCam.Run();//拍照
                        mImage = mVision.DownCam.OutputImage;
                        if (FrmNPointInfoEvent != null)
                        {
                            FrmNPointInfoEvent.Invoke(msg, mImage);
                        }
                    }
                    if (msg.Contains("R1"))//复检
                    {
                        RunReckeck();
                    }

                }
                catch (SocketException ex)
                {
                    //进入catch 代表连接服务器失败，或者服务器断开， 每隔3s钟进行一次重新连接
                    Thread.Sleep(3000);
                    ConnectServer();
                    fileOperator.SaveLog(ex.Message);
                }
                catch (Exception ex)
                {
                    PrintMessage(ex.Message);
                    fileOperator.SaveLog(ex.Message);
                }
            }
        }

        /// <summary>
        /// 向服务器发送信息
        /// </summary>
        /// <param name="msg"></param>
        private void SendDataToServer(string msg)
        {
            byte[] buffer = new byte[1024 * 1024];//创建字节数组
            buffer = Encoding.Default.GetBytes(msg);//string类型转成字节数组
            if (clientSocket.Connected)//判断是否连接到远程主机
                clientSocket.Send(buffer);
        }

        #endregion


        #region 视觉处理方法
      
       
       
        //T1检测
        private void RunT1()
        {
            Stopwatch sw = new Stopwatch();
            //string[] strArray = msg.Split(',');
            ////机械手移动到拍照点坐标
            //double pzX = Convert.ToDouble(strArray[1]);
            //double pzY = Convert.ToDouble(strArray[2]);
            //double pzR = Convert.ToDouble(strArray[3]);
            da = 0;

            sw.Start();
            PrintMessage("T1开始拍照");
            mVision.DownCam.Run();//拍照
            if (mVision.DownCam.RunStatus.Result == CogToolResultConstants.Accept)//判断工具运行结果
            {
                PrintMessage($"T1拍照完成，拍照时间 {sw.ElapsedMilliseconds}ms");
                mImage = mVision.DownCam.OutputImage;
                //运行标定VPP
                CogCalibNPointToNPointTool nPoint = (CogCalibNPointToNPointTool)mVision.DownCameraNpointTB.Tools["CogCalibNPointToNPointTool1"];
                nPoint.InputImage = mImage;
                nPoint.Run();
                //运行检测VPP
                mVision.DownCameraInspectTB.Inputs["InputImage"].Value = nPoint.OutputImage;
                mVision.DownCameraInspectTB.Run();
                cogRecordDisplay1.Record = null;
                cogRecordDisplay1.Record = mVision.DownCameraInspectTB.CreateLastRunRecord().SubRecords[0];
                cogRecordDisplay1.Fit();
                //if (mVision.DownCameraInspectTB.RunStatus.Result == CogToolResultConstants.Accept)
                {
                    da = Convert.ToDouble(mVision.DownCameraInspectTB.Outputs["Angle"].Value);
                    //pzR = pzR + angle;
                    da = Math.Round(da, 3);
                    //转动角度
                    //SendDataToServer($"0,0,{da.ToString("0.000")}");
                    
                  //PLC位置
                    plc.Write("DB14.DBD2.0",  (float)0);//x位置
                    plc.Write("DB14.DBD6.0", (float)0);//y
                    plc.Write("DB14.DBD10.0", (float)0);//r (float)da
                    plc.Write("DB14.DBX0.2", true);//数据发送完成

                    PrintMessage($"发送T1偏移量 0,0,{da.ToString()}");
                   

                }
            }
            //else
            //{
            //    PrintMessage($"拍照失败");
            //    plc.Write("DB14.DBX0.1", true);//拍照完成
            //    PrintMessage($"发送服务器 T1,NG");
            //}
        }
        //T2检测
        private void RunT2()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            PrintMessage("T2开始拍照");
            mVision.DownCam.Run();//拍照
            //if (mVision.DownCam.RunStatus.Result == CogToolResultConstants.Accept)//判断工具运行结果
            {
                PrintMessage($"T2拍照完成，拍照时间 {sw.ElapsedMilliseconds}ms");
                mImage = mVision.DownCam.OutputImage;

                //运行标定VPP
                CogCalibNPointToNPointTool nPoint = (CogCalibNPointToNPointTool)mVision.DownCameraNpointTB.Tools["CogCalibNPointToNPointTool1"];
                nPoint.InputImage = mImage;
                nPoint.Run();
                //运行检测VPP
                mVision.DownCameraInspectTB.Inputs["InputImage"].Value = nPoint.OutputImage;
                mVision.DownCameraInspectTB.Run();
                cogRecordDisplay1.Record = null;
                cogRecordDisplay1.Record = mVision.DownCameraInspectTB.CreateLastRunRecord().SubRecords[0];
                cogRecordDisplay1.Fit();
                //if (mVision.DownCameraInspectTB.RunStatus.Result == CogToolResultConstants.Accept)
                {

                    //有旋转中心的算法 只拍一次照即可
                    //if (false)
                    {
                        da = Convert.ToDouble(mVision.DownCameraInspectTB.Outputs["Angle"].Value);
                        //视觉拍到的坐标
                        double visionX1 = Convert.ToDouble(mVision.DownCameraInspectTB.Outputs["VisionX"].Value);
                        double visionY1 = Convert.ToDouble(mVision.DownCameraInspectTB.Outputs["VisionY"].Value);
                        //求拍到的点绕旋转中心转动后的坐标
                        double x = Math.Cos(da) * (visionX1 - config.OrgX) - Math.Sin(da) * (visionY1 - config.OrgY) + config.OrgX;
                        double y = Math.Cos(da) * (visionY1 - config.OrgY) + Math.Sin(da) * (visionX1 - config.OrgX) + config.OrgY;
                        //求偏移量
                        dx = x - config.BaseX;
                        dy = y - config.BaseY;
                        //da = Convert.ToDouble(mVision.DownCameraInspectTB.Outputs["Angle"].Value);
                        da = Math.Round(da, 3);
                        dx = Math.Round(dx, 3);
                        dy = Math.Round(dy, 3);


                    }
                    ////视觉坐标
                    //double visionX = Convert.ToDouble(mVision.DownCameraInspectTB.Outputs["VisionX"].Value);
                    //double visionY = Convert.ToDouble(mVision.DownCameraInspectTB.Outputs["VisionY"].Value);
                    ////计算偏差
                    ////dx = visionX - config.BaseX;
                    ////dy = visionY - config.BaseY;
                    //dx = config.BaseX - visionX;
                    //dy = config.BaseY - visionY;
                    //dx = Math.Round(dx, 3);
                    //dy = Math.Round(dy, 3);



                    plc.Write("DB14.DBD16.0", (float)dx);//x位置dx
                    plc.Write("DB14.DBD20.0", (float)dy);//y dy
                    plc.Write("DB14.DBD24.0", (float)da);//r da
                    plc.Write("DB14.DBX14.2", true);//数据发送完成
                    PrintMessage($"发送T2偏移量 {dx},{dy},{da}");

                }
            }
            //else
            //{
            //    PrintMessage($"拍照失败");
            //    //SendDataToServer("T2,NG");
            //    PrintMessage($"发送服务器 T2,NG");
            //}
            //发送拍照完成  发送补偿
           
        }
        //复检
        private void RunReckeck()
        {

            try
            {
               

                Stopwatch sw = new Stopwatch();
                sw.Start();
                PrintMessage("相机2拍照");
                mVision.Cam2.Run();
                PrintMessage($"相机2拍照完成 时间：{sw.ElapsedMilliseconds}ms");
                ICogImage image = mVision.Cam2.OutputImage;//获取输出图像

                sw.Restart();
                PrintMessage("开始检测");
                mVision.RecheckTB.Inputs["OutputImage"].Value = image;//提供输入图像
                mVision.RecheckTB.Run();//运行
                PrintMessage($"检测完成 检测时间：{sw.ElapsedMilliseconds}ms");
                //显示
                cogRecordDisplay2.Record = null;
                cogRecordDisplay2.Record = mVision.RecheckTB.CreateLastRunRecord().SubRecords[0];
                cogRecordDisplay2.Fit();
                //判断OK  获取结果和数据
                if (mVision.RecheckTB.RunStatus.Result == CogToolResultConstants.Accept)
                {

                }

                dataInfoList.Add(new DataInfo
                {
                    Data = "",
                    DT = DateTime.Now,
                    Result = "OK"
                });
                UpdateDgwHandle(dataInfoList);//跟新信息显示

            }
            catch (Exception ex)
            {

               
            }

            
           
        }

        #endregion





        #region 更新窗体信息
        /// <summary>
        /// 更新产能
        /// </summary>
        private void UpdateProduction()
        {
            this.lbl_Total.Text = total.ToString();
            this.lbl_OKNum.Text = okNum.ToString();
            if (total > 0)
                yield = okNum / (double)total * 100;
            this.lbl_Yield.Text = yield.ToString();
            config.WriteConfig("生产数据", "ProductTotal", total.ToString());
            config.WriteConfig("生产数据", "ProductOkNum", okNum.ToString());
        }
        //跨线程调用，更新产能
        private void UpdateProductionHandle()
        {
            Invoke(new MethodInvoker(() => { UpdateProduction(); }));
        }
        /// <summary>
        /// 更新结果Label显示
        /// </summary>
        /// <param name="bResult"></param>
        private void UpdateLblResult(bool bResult)
        {
            if (bResult)
            {
                lbl_result.Text = "PASS";
                lbl_result.BackColor = Color.Green;
            }
            else
            {
                lbl_result.Text = "Fail";
                lbl_result.BackColor = Color.Red;
            }
        }
        //跨线程调用，更新产能
        private void UpdateLablResultHandle(bool bResult)
        {
            Invoke(new MethodInvoker(() => { UpdateLblResult(bResult); }));
        }

        private void UpdateDgwHandle(List<DataInfo> datas)
        {
            Invoke(new MethodInvoker(() => { UpdateDgw(datas); }));
        }
        private void UpdateDgw(List<DataInfo> dataInfos)
        {

            if (dataInfoList.Count > 5)
            {
                dataInfoList.RemoveAt(0);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataInfos;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        /// <summary>
        /// 打印信息到屏幕
        /// </summary>
        /// <param name="msg">信息</param>
        /// <param name="bReceive">判断是否是接收到信息的标志位</param>
        private void PrintMessage(string msg, bool bReceive = false)
        {
            string time = DateTime.Now.ToString("HH:mm:ss:fff");//系统时间
            string receive = bReceive ? " <- " : " -> ";
            string str = $"{time}: {receive}{msg}";
            try
            {
                listBox1.BeginInvoke(new Action(() =>
                {
                    if (listBox1.Items.Count > 60)
                    {
                        listBox1.Items.RemoveAt(0);
                    }
                    listBox1.Items.Add(str);
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                }));
                fileOperator.SaveLog(str);
            }
            catch (Exception ex)
            {
                fileOperator.SaveLog(ex.Message);
            }
        }

        //刷新状态
        private void timer1_Tick(object sender, EventArgs e)
        {
            //客户端是否连接
            if (clientSocket == null)
            {
                listBox1.Items.Add(DateTime.Now.ToString() + " -> 未连接");
            }
            else if (clientSocket.Poll(1000, SelectMode.SelectRead))
            {
                byte[] bytes = new byte[1024];
                int len = clientSocket.Receive(bytes);
                if (len == 0)
                {
                    listBox1.Items.Add(DateTime.Now.ToString() + " -> 断开");
                }
            }
            else
            {
                listBox1.Items.Add(DateTime.Now.ToString() + " -> 已连接");
            }

            listBox1.SelectedItems.Clear();
            string str = listBox1.Items[listBox1.Items.Count - 1].ToString();
            listBox1.SelectedItems.Add(str);
            //if (clientSocket.Connected)
            //{
            //    tslbl_ClientStatus.Text = "已连接";
            //    tslbl_ClientStatus.BackColor = Color.Green;
            //}
            //else
            //{
            //    tslbl_ClientStatus.Text = "未连接";
            //    tslbl_ClientStatus.BackColor = Color.Red;
            //}
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            imgSaveDays = Settings.Default.ImageSaveDays;
            bool bAutoDelete = Settings.Default.bAutoDelete;
            lastDele = Settings.Default.LastDeleteDate;
            if (bAutoDelete)
            {
                //判断 默认保存七天 最后删除日期＋保存天数 小于 当前日期，则代表距离上次删除图片 超过七天  需要重新删除图片
                if (lastDele.AddDays(imgSaveDays) < DateTime.Now)
                {
                    if (!bgwDeleteImage.IsBusy)
                    {
                        bgwDeleteImage.RunWorkerAsync();
                        lastDele = DateTime.Now;
                        Settings.Default.LastDeleteDate = lastDele;
                        Settings.Default.Save();
                    }
                }
            }


        }

        //更新plc连接状态
        private void UpdatePlcStatus()
        {
            this.Invoke(new Action(() =>
            {
                if (plc.PlcIsConn())
                {
                    plcStatusLbl.BackColor = Color.Green;
                    plcStatusLbl.Text = "已连接";
                }
                else
                {
                    plcStatusLbl.BackColor = Color.Red;
                    plcStatusLbl.Text = "未连接";
                }
            }));
        }


        #endregion







        //自动删除图片
        private void bgwDeleteImage_DoWork(object sender, DoWorkEventArgs e)
        {
            //D:\Image
            string imagePath = Cls_Config.GetInstance().ImageSavePath;
            if (Directory.Exists(imagePath))
            {
                //初始化图片路径的对象
                DirectoryInfo directory = new DirectoryInfo(imagePath);
                //返回当前目录的子目录 获取Image文件夹里边的所有文件夹
                DirectoryInfo[] dirs = directory.GetDirectories();
                foreach (DirectoryInfo d in dirs)
                {
                    //判断文件夹创建时间
                    if (d.CreationTime.AddDays(imgSaveDays) < lastDele)
                    {
                        d.Delete(true);//删除  true 删除目录及目录的子目录和文件 
                    }
                }
            }
        }
       
     
        
    }
}
