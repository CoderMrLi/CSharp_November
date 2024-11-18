using Cognex.VisionPro;
using Cognex.VisionPro.PMAlign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class FrmNPointTB : Form
    {
        Vision vision;
        public FrmNPointTB(Vision vision)
        {
            InitializeComponent();
            this.vision = vision;
        }

        //用来保存点位的信息
        List<CalibNPoint> points = new List<CalibNPoint>();

        /// <summary>
        /// 用来中转的方法，根据传入的是C1还是RC，决定调用哪个方法
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="image"></param>
        public void Transfer(string msg, ICogImage image)
        {
            if (msg.Contains("C1"))
            {
                NPointRun(msg, image);
            }
            else if (msg.Contains("RC"))
            {
                RcRun(msg, image);
            }
        }



        //用来标定的方法 传入msg信息和拍照的图片
        //msg : C1,-68,143
        //image : 对应位置拍照得到的图片
        public void NPointRun(string msg, ICogImage image)
        {
            //1. 把图片放到TB里运行
            vision.NPointTB.Inputs["OutputImage"].Value = image;
            vision.NPointTB.Run();
            //2. 拿到模板匹配工具
            CogPMAlignTool pmaTool = vision.NPointTB.Tools["CogPMAlignTool1"] as CogPMAlignTool;
            //3. 拿到匹配结果
            double pixX = pmaTool.Results[0].GetPose().TranslationX;
            double pixY = pmaTool.Results[0].GetPose().TranslationY;
            //创建一条信息
            CalibNPoint calibNPoint = new CalibNPoint();
            calibNPoint.pixX = pixX;
            calibNPoint.pixY = pixY;
            //已校准点XY在msg里 需要分割
            string[] WorldsPoints = msg.Split(',');

            calibNPoint.worldX = Convert.ToDouble(WorldsPoints[1]);
            calibNPoint.worldY = Convert.ToDouble(WorldsPoints[2]);

            //往list里填入信息
            points.Add(calibNPoint);
            UpdataDGV();
            //显示图片
            //list里的数据数量 == 9 的时候
            //把list里的9条数据添加进标定工具
            //进行校准
        }




        //list用来显示到窗体
        List<CalibNPoint> rcPoints = new List<CalibNPoint>();
        /// <summary>
        /// 旋转中心
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="image"></param>

        public void RcRun(string msg, ICogImage image)
        {
            //把图片给TB
            vision.NPointTB.Inputs["OutputImage"].Value = image;
            //运行
            vision.NPointTB.Run();
            //拿到模板匹配工具
            CogPMAlignTool PMATool = vision.NPointTB.Tools["CogPMAlignTool2"] as CogPMAlignTool;
            //拿到XY结果
            double x = PMATool.Results[0].GetPose().TranslationX;
            double y = PMATool.Results[0].GetPose().TranslationY;
            //创建一个点位信息
            CalibNPoint calibNPoint1 = new CalibNPoint();
            calibNPoint1.RCX = x;
            calibNPoint1.RCY = y;
            //加到list里
            rcPoints.Add(calibNPoint1);
            //绑定数据源
            UpdataRCDGV();

            //拍照3次之后 画圆
            if (rcPoints.Count == 3)
            {
                //拿到拟合圆工具
                CogFitCircleTool fcTool = vision.NPointTB.Tools["CogFitCircleTool1"] as CogFitCircleTool;
                for (int i = 0; i < rcPoints.Count; i++)
                {
                    //修改坐标
                    fcTool.RunParams.SetPoint(i, rcPoints[i].RCX, rcPoints[i].RCY);
                }
                //运行拟合圆
                fcTool.Run();
                //圆心XY
                label3.Text = "旋转中心X：" + fcTool.Result.GetCircle().CenterX.ToString();
                label4.Text = "旋转中心Y：" + fcTool.Result.GetCircle().CenterY.ToString();
                //存INI文件
            }
        }

        private void UpdataDGV()
        {
            Invoke(new MethodInvoker(() =>
            {
                //往表格里写数据
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = points;
            }));
        }

        private void UpdataRCDGV()
        {
            Invoke(new MethodInvoker(() =>
            {
                //绑定数据源
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = rcPoints;
            }));
        }

        private void FrmNPointTB_Load(object sender, EventArgs e)
        {
            //取消跨线程检查
            Control.CheckForIllegalCrossThreadCalls = false;
            //禁止自动生成新的列
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
        }
    }
}
