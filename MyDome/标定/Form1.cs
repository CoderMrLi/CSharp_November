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

namespace 标定
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

		}
        //图片路径
        static string img_path = Directory.GetCurrentDirectory() + "\\img";
        //全部图片的路径的数组
        static string[] imgs = Directory.GetFiles(img_path);
        //当前图片的索引
        static int imgIndex = 0;

        //VPP
        static CogToolBlock mToolBlock = CogSerializer.LoadObjectFromFile(Directory.GetCurrentDirectory() + "\\vpp\\NPoint1.vpp") as CogToolBlock;
        //模板匹配工具
        CogPMAlignTool pmaTool;

		//校准数据
		//List<NPointRow> points = new List<NPointRow>();
		BindingList<NPointRow> points = new BindingList<NPointRow>();
		


		private void Form1_Load(object sender, EventArgs e)
        {
            pmaTool = mToolBlock.Tools["CogPMAlignTool1"] as CogPMAlignTool;
            serialPort1.Open();
			//dgvNPoint = new DataGridView();
		}

        //串口接收到数据后调用
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //拿到串口发送的数据
            int size = serialPort1.BytesToRead;
            byte[] data = new byte[size];
            serialPort1.Read(data, 0, size);
            string msg = Encoding.ASCII.GetString(data);

            listBox1.Items.Add("接收到串口消息 -> " + msg);

            if (msg.Contains("T1"))
            {
                //拍照(使用图片)
                Bitmap bmp = new Bitmap(imgs[imgIndex]);
                if ( imgIndex >= imgs.Length - 1 ) {
                    MessageBox.Show("图片运行完毕！" , "提示");
                    return;
                } else { 
                    imgIndex++;
                }
                //转为灰度图
                CogImage8Grey img8Gtey = new CogImage8Grey(bmp);
				cogRecordDisplay1.Image = img8Gtey;

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

                //dgvNPoint.DataSource = null;
                dgvNPoint.DataSource = points;
				//new BindingSource(new BindingList<标定.NPointRow>(points) , null);
				//new BindingList<标定.NPointRow>(points);
			}
		}
    }
}
