using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cognex.VisionPro;
using Cognex.VisionPro.PMAlign;
using Cognex.VisionPro.CalibFix;

namespace VisionproDemo
{
    
   
    public partial class FrmNPoint : Form
    {
        public List<CalibNPoint> pointList = new List<CalibNPoint>();
        public Vision mVision;
        CogPMAlignTool pma;
        CogCalibNPointToNPointTool nPointTool;
        CogPMAlignTool pma2;
        CogFitCircleTool fcTool;
        public delegate void LoadVppDelagate();
        public event LoadVppDelagate LoadVppEvent;
        public FrmNPoint()
        {
            InitializeComponent();
        }

        private void FrmNPoint_Load(object sender, EventArgs e)
        {
            this.dgwNpoint.AutoGenerateColumns = false;
            this.dgwRC.AutoGenerateColumns = false;

            FrmMain.FrmNPointInfoEvent += ReceiveNpointInfoEvent;
            //声明PMA工具
            pma = (CogPMAlignTool)mVision.DownCameraNpointTB.Tools["CogPMAlignTool1"];
            nPointTool = (CogCalibNPointToNPointTool)mVision.DownCameraNpointTB.Tools["CogCalibNPointToNPointTool1"];
            pma2 = (CogPMAlignTool)mVision.DownCameraNpointTB.Tools["CogPMAlignTool2"];
            fcTool = (CogFitCircleTool)mVision.DownCameraNpointTB.Tools["CogFitCircleTool1"];
            
            
            //删除点位
            //while (nPointTool.Calibration.NumPoints > 0)
            //{
            //    nPointTool.Calibration.DeletePointPair(0);
            //}

            pointList.Clear();
        }
        
        private void ReceiveNpointInfoEvent(string msg, ICogImage image)
        {

            if (msg.Contains("C1"))
                NPointFunc(msg, image);
            else
                RotationCenterFunc(msg, image);

           

        }
        //求旋转中心
        private void RotationCenterFunc(string msg, ICogImage image)
        {
            //分割坐标
            //string[] pointStr = msg.Split(',');
            //double worldX = Convert.ToDouble(pointStr[1]);//世界坐标
            //double worldY = Convert.ToDouble(pointStr[2]);
            try
            {
                nPointTool.InputImage = image;
                nPointTool.Run();
                pma2.Run();
                double x = pma2.Results[0].GetPose().TranslationX;
                double y = pma2.Results[0].GetPose().TranslationY;
                pointList.Add(new CalibNPoint
                {
                    FitCircleX = x,
                    FitCircleY = y
                });

                UpdateDgwRCHandler(pointList);

                if (pointList.Count == 3)
                {
                    for (int i = 0; i < pointList.Count; i++)
                    {
                        fcTool.RunParams.SetPoint(i, pointList[i].FitCircleX, pointList[i].FitCircleY);
                    }
                    
                    fcTool.Run();
                    Cls_Config.GetInstance().OrgX = fcTool.Result.GetCircle().CenterX;
                    Cls_Config.GetInstance().OrgY = fcTool.Result.GetCircle().CenterY;

                    Cls_Config.GetInstance().WriteConfig("点位", "OrgX", Cls_Config.GetInstance().OrgX.ToString());
                    Cls_Config.GetInstance().WriteConfig("点位", "OrgY", Cls_Config.GetInstance().OrgY.ToString());
                    pointList.Clear();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        //九点标定
        private void NPointFunc(string msg,ICogImage image)
        {
            try
            {
                //分割坐标
                string[] pointStr = msg.Split(',');
                double worldX = Convert.ToDouble(pointStr[1]);//世界坐标
                double worldY = Convert.ToDouble(pointStr[2]);

                //测试使用
                double pixX = Convert.ToDouble(pointStr[3]);//模拟像素坐标
                double pixY = Convert.ToDouble(pointStr[4]);

                mVision.DownCameraNpointTB.Inputs["InputImage"].Value = image;

                //pma.Run();
                //double pixX = pma.Results[0].GetPose().TranslationX;//像素坐标
                //double pixY = pma.Results[0].GetPose().TranslationY;

                pointList.Add(new CalibNPoint
                {
                    Pix_X = pixX,
                    Pix_Y = pixY,
                    World_X = worldX,
                    World_Y = worldY
                });//添加到集合

                UpdateDgwNpointHandle(pointList);
                int n = nPointTool.Calibration.NumPoints;
                if (pointList.Count == 9)
                {
                    //一般使用九点标定，判断校准工具点数小于9 添加点位
                    while (nPointTool.Calibration.NumPoints < 9)
                    {
                        nPointTool.Calibration.AddPointPair(0, 0, 0, 0);
                    }
                    //设置校准工具参数点位
                    for (int i = 0; i < nPointTool.Calibration.NumPoints; i++)
                    {
                        nPointTool.Calibration.SetUncalibratedPoint(i, pointList[i].Pix_X, pointList[i].Pix_Y);
                        nPointTool.Calibration.SetRawCalibratedPoint(i, pointList[i].World_X, pointList[i].World_Y);
                    }
                    //nPointTool.CalibrationImage = image;
                    nPointTool.Calibration.Calibrate();
                    ShowResult();
                    MessageBox.Show("标定完成");
                    
                    //清空集合
                    pointList.Clear();
                }

            }
            catch (Exception ex)
            {

                CleanResultLbl();
            }

        }
        //更新显示九点标定坐标
        private void UpdateDgwNpointHandle(List<CalibNPoint> list)
        {
            Invoke(new MethodInvoker(() => { UpdateDgwNpoint(list); }));
        }
        private void UpdateDgwNpoint(List<CalibNPoint> list)
        {

            dgwNpoint.DataSource = null;
            dgwNpoint.DataSource = list;

            for (int i = 0; i < dgwNpoint.Columns.Count; i++)
            {
                dgwNpoint.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }
        //更新旋转中心坐标显示
        private void UpdateDgwRCHandler(List<CalibNPoint> list)
        {
            Invoke(new Action(() =>
            {
                dgwRC.DataSource = null;
                dgwRC.DataSource = list;
            }));
            for (int i = 0; i < dgwNpoint.Columns.Count; i++)
            {
                dgwNpoint.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    
        private void ShowResult()
        {
            CogTransform2DLinear linear = (CogTransform2DLinear)nPointTool.Calibration.GetComputedUncalibratedFromCalibratedTransform();
            Invoke(new MethodInvoker(() =>
            {
                if (linear != null)
                {
                    LblPyX.Text = "平移X:" + linear.TranslationX.ToString("0.000");
                    LblPyY.Text = "平移Y:" + linear.TranslationY.ToString("0.000");
                    Lblsf.Text = "缩放:" + linear.Scaling.ToString("0.000");
                    LblSkew.Text = "倾斜" + linear.Skew.ToString("0.000");
                    LblRotation.Text = "旋转:" + linear.Rotation.ToString("0.000");
                    LblRms.Text = "Rms:" + nPointTool.Calibration.ComputedRMSError.ToString("0.000");
                }
                else
                {
                    CleanResultLbl();
                }
            }));
            
            
           
        }
        private void CleanResultLbl()
        {

            Invoke(new MethodInvoker(() =>
            {
                LblPyX.Text = "平移X:";
                LblPyY.Text = "平移Y:";
                Lblsf.Text = "缩放:";
                LblSkew.Text = "倾斜";
                LblRotation.Text = "旋转:";
                LblRms.Text = "Rms:";
            }));
          
        }
        //编辑作业
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmNPointTool frmNPointTool = new FrmNPointTool();
            frmNPointTool.LoadVppEvent += FrmNPointTool_LoadVppEvent;
            frmNPointTool.frmVision = this.mVision;
            frmNPointTool.ShowDialog();
            frmNPointTool.LoadVppEvent -= FrmNPointTool_LoadVppEvent;
        }

        private void FrmNPointTool_LoadVppEvent()
        {
            mVision.LoadToolBlock();
        }

        //保存标定作业
        private void SaveCalib_Click(object sender, EventArgs e)
        {
            mVision.SaveTB();
            DialogResult result = MessageBox.Show("确认保存设置", "保存设置", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                
                mVision.SaveTB();
                MessageBox.Show("保存完成");
            }
        }
        //关闭窗体时移除事件
        private void FrmNPoint_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.FrmNPointInfoEvent -= ReceiveNpointInfoEvent;
            LoadVppEvent?.Invoke();
        }
    }
}
