using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//引用模板匹配命名空间
using Cognex.VisionPro.PMAlign;
using System.Windows.Interop;
//引用标定命名空间
using Cognex.VisionPro.CalibFix;

namespace 标定
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //图片路径
        static string img_path = Directory.GetCurrentDirectory() + "\\img";
        //全部图片的路径的数组
        static string[] imgs = Directory.GetFiles(img_path);
        //当前图片的索引
        static int imgIndex = 0;

        //VPP
        static CogToolBlock mToolBlock = CogSerializer.LoadObjectFromFile(Directory.GetCurrentDirectory() + "\\vpp\\NPoint.vpp") as CogToolBlock;
        //模板匹配工具
        CogPMAlignTool pmaTool;
        CogPMAlignTool pmaTool2;
        //N点标定工具
        CogCalibNPointToNPointTool npointTool;

        //校准数据
        List<NPointRow> points = new List<NPointRow>();

        private void Form1_Load(object sender, EventArgs e)
        {
            pmaTool = mToolBlock.Tools["CogPMAlignTool1"] as CogPMAlignTool;
            npointTool = mToolBlock.Tools["CogCalibNPointToNPointTool1"] as CogCalibNPointToNPointTool;
            pmaTool2 = mToolBlock.Tools["CogPMAlignTool2"] as CogPMAlignTool;
            serialPort1.Open();
        }

        //串口接收到数据后调用
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //拿到串口发送的数据
            int size = serialPort1.BytesToRead;
            byte[] data = new byte[size];
            serialPort1.Read(data, 0, size);
            string msg = Encoding.ASCII.GetString(data);

            UpdateListBox1Status("接收到串口消息 -> " + msg);

            if (msg.Contains("T1"))
            {
                //拍照(使用图片)
                Bitmap bmp = new Bitmap(imgs[imgIndex]);
                imgIndex++;

                //转为灰度图
                CogImage8Grey img8Gtey = new CogImage8Grey(bmp);
                //图片给ToolBlock
                mToolBlock.Inputs["OutputImage"].Value = img8Gtey;
                mToolBlock.Run();

                //未校准点
                double pixX = pmaTool.Results[0].GetPose().TranslationX;
                double pixY = pmaTool.Results[0].GetPose().TranslationY;
                //已校准点
                string[] pointstr = msg.Split(',');
                double worldX = Convert.ToDouble(pointstr[1]);
                double worldY = Convert.ToDouble(pointstr[2]);

                //创建一行
                NPointRow row = new NPointRow(pixX, pixY, worldX, worldY);
                //添加到校准数据list
                points.Add(row);

                //更新dgv状态
                UpdateDgvStatus();

                //更新图片
                cogRecordDisplay1.Record = mToolBlock.CreateLastRunRecord().SubRecords[0];
                cogRecordDisplay1.Fit();

                if(imgIndex == 9)
                {
                    Start9Point();
                }


                //加个条件 防止下标越界
                if (imgIndex == 9)
                {
                    imgIndex = 0;
                }
            }
        }

        //更新dgv状态
        private void UpdateDgvStatus()
        {
            Invoke(new MethodInvoker(() =>
            {
                dgvNPoint.DataSource = null;
                dgvNPoint.DataSource = points;
            }));
        }

        //更新listbox1状态
        private void UpdateListBox1Status(string msg)
        {
            Invoke(new MethodInvoker(() =>
            {
                listBox1.Items.Add("接收到串口消息 -> " + msg);
            }));
        }

        //开始9点标定
        private void Start9Point()
        {
            UpdateListBox1Status("开始校准!");

            for (int i = 0; i < points.Count; i++)
            {
                npointTool.Calibration.AddPointPair(points[i].PixX, points[i].PixY, points[i].WorldX, points[i].WorldY);
            }
            //开始校准
            npointTool.Calibration.Calibrate();

            UpdateListBox1Status("校准完成!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(imgs[imgIndex]);
            CogImage8Grey img8Grey = new CogImage8Grey(bmp);

            mToolBlock.Inputs["OutputImage"].Value = img8Grey;
            mToolBlock.Run();

            double resultX = pmaTool2.Results[0].GetPose().TranslationX;
            double resultY = pmaTool2.Results[0].GetPose().TranslationY;

            UpdateListBox1Status($"位置信息 -> X:{resultX} Y:{resultY}");

        }
    }
}
