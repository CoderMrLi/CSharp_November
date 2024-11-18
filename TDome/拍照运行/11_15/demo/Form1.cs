using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Vision vision = new Vision();

        //串口通信
        SerialPort port = new SerialPort();
        //串口线程
        Thread portThread;
        //声明INI配置类
        Cls_Config Cls_Config = Cls_Config.GetInstance();

        //用于9点标定的委托
        public delegate void NPointDelegate(string msg, ICogImage image);
        public event NPointDelegate NPointEvent;



        private void Form1_Load(object sender, EventArgs e)
        {
            //加载TB
            vision.load();
            //串口通信设置
            port.PortName = "COM2";
            port.BaudRate = 9600;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            port.DataBits = 8;
            //打开串口
            port.Open();

            portThread = new Thread(Receive);
            portThread.IsBackground = true;
            portThread.Start();

            //加载INI配置
            Cls_Config.loadINI();
        }

        private void Receive()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    //发送来多少个字节
                    int size = port.BytesToRead;
                    //接收
                    int len = port.Read(buffer, 0, size);
                    if (len > 0)
                    {
                        //转为字符串
                        string msg = Encoding.ASCII.GetString(buffer, 0, len);
                        if (msg.Contains("C1") || msg.Contains("RC"))
                        {
                            //这里我们取一张图片
                            //实际运行时，要通过相机拍照获得图片
                            Bitmap bmp = new Bitmap(Directory.GetCurrentDirectory() + "\\image\\rc1.bmp");
                            CogImage8Grey cogImage8Grey = new CogImage8Grey(bmp);

                            //标定
                            //msg里是发送来的位置信息 : C1,-68,143
                            //图片是对应位置拍照得到的图片
                            NPointEvent.Invoke(msg, cogImage8Grey);
                        }
                        else if (msg.Contains("T1"))
                        {
                            //接收到了T1拍照信号
                            cameraRun();
                        }
                    }
                }
                catch
                {

                }
            }
        }

        /// <summary>
        /// 拍照
        /// </summary>
        private void cameraRun()
        {
            //读取图片 实际去调试的时候换成拍照
            Bitmap bmp = new Bitmap(Directory.GetCurrentDirectory() + "\\image\\rc2.bmp");
            CogImage8Grey cogImage8Grey = new CogImage8Grey(bmp);

            //把基准信息给TB
            vision.detectionTB.Inputs["refX"].Value = Cls_Config.refX;
            vision.detectionTB.Inputs["refY"].Value = Cls_Config.refY;
            vision.detectionTB.Inputs["refR"].Value = Cls_Config.refR;

            //把图片给标定 转换坐标系
            vision.NPointTB.Inputs["OutputImage"].Value = cogImage8Grey;
            vision.NPointTB.Run();
            //标定完的图片给检测的vpp
            vision.detectionTB.Inputs["OutputImage"].Value = vision.NPointTB.Outputs["OutputImage"].Value;
            vision.detectionTB.Run();

            //获取偏移量
            double offX = Convert.ToDouble(vision.detectionTB.Outputs["offX"].Value);
            double offY = Convert.ToDouble(vision.detectionTB.Outputs["offY"].Value);
            double offR = Convert.ToDouble(vision.detectionTB.Outputs["offR"].Value);

            //发送给PLC

            //提示信息
            MessageBox.Show($"偏移X:{offX.ToString("f2")},偏移Y:{offY.ToString("f2")},偏移R:{offR.ToString("f2")}");

            //显示图片
            cogRecordDisplay1.Image = cogImage8Grey;
            cogRecordDisplay1.Fit();
            cogRecordDisplay2.Record = vision.detectionTB.CreateLastRunRecord().SubRecords[0];
            cogRecordDisplay2.Fit();
        }



        private void 编辑标定作业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建窗体的时候 把Vision传进去
            FrmEditNPointTB frmEditNPointTB = new FrmEditNPointTB(vision);
            //显示
            frmEditNPointTB.ShowDialog();
            //运行结束后 防止线程占用问题
            vision.load();
        }

        private void 下相机标定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNPointTB frm = new FrmNPointTB(vision);
            NPointEvent += frm.Transfer;
            frm.ShowDialog();
            vision.load();
        }
    }
}
