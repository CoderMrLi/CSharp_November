using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.CalibFix;

namespace VisionproDemo
{ 
    /// <summary>
    /// 视觉类
    /// </summary>
    public class Vision
    {
        /// <summary>
        /// 相机1
        /// </summary>
        public CogAcqFifoTool DownCam { get; set; }
        /// <summary>
        /// 检测ToolBlock
        /// </summary>
        public CogToolBlock InsepectionTB { get; set; }

        /// <summary>
        /// NPoint工具
        /// </summary>
        public CogCalibNPointToNPointTool NPointTool { get; set; }
        /// <summary>
        /// 下相机检测VPP
        /// </summary>
        public CogToolBlock DownCameraInspectTB { get; set; }
        /// <summary>
        /// 下相机NPointVPP
        /// </summary>
        public CogToolBlock DownCameraNpointTB { get; set; }
        /// <summary>
        /// 下相机VPP
        /// </summary>
        public CogToolBlock DownCameraTB { get; set; }

        /// <summary>
        /// 相机2
        /// </summary>
        public CogAcqFifoTool Cam2 { get; set; }

        /// <summary>
        /// 复检VPP
        /// </summary>
        public CogToolBlock RecheckTB { get; set; }

        private string _camPath = Directory.GetCurrentDirectory() + "\\VPP\\DownCam.vpp";
        private string _cam2Path = Directory.GetCurrentDirectory() + "\\VPP\\CogAcqFifoTool2.vpp";
        //private string _inspectTBPath = Directory.GetCurrentDirectory() + "\\VPP\\InspectionTB.vpp";
        private string _downTBPath = Directory.GetCurrentDirectory() + "\\VPP\\CalibNPointTB.vpp";
        private string _recheckTBPath = Directory.GetCurrentDirectory() + "\\VPP\\RecheckTB.vpp";
        //private string path = @"D:\VPP\tb.vpp";
        /// <summary>
        /// 加载VPP
        /// </summary>
        /// <returns></returns>
        public bool LoadToolBlock()
        {
            try
            {
                //DownCam = CogSerializer.LoadObjectFromFile(_camPath) as CogAcqFifoTool;
                //InsepectionTB = CogSerializer.LoadObjectFromFile(_inspectTBPath) as CogToolBlock;
                DownCameraTB = CogSerializer.LoadObjectFromFile(_downTBPath) as CogToolBlock;
                Cam2 = CogSerializer.LoadObjectFromFile(_cam2Path) as CogAcqFifoTool; 
                //InsepectionTB = CogSerializer.LoadObjectFromFile(_inspectTBPath) as CogToolBlock;
                RecheckTB = CogSerializer.LoadObjectFromFile(_recheckTBPath) as CogToolBlock;


                AllotTB();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 分配工具
        /// </summary>
        private void AllotTB()
        {
            DownCameraNpointTB = (CogToolBlock)DownCameraTB.Tools["CalibNPoint"];
            DownCameraInspectTB = (CogToolBlock)DownCameraTB.Tools["Inspection"];
            DownCam = (CogAcqFifoTool)DownCameraTB.Tools["CogAcqFifoTool1"];
        }
        /// <summary>
        /// 保存相机
        /// </summary>
        /// <returns></returns>
        public bool SaveCam()
        {
            try
            {
                //CogSerializer.SaveObjectToFile(DownCam, _camPath);
                CogSerializer.SaveObjectToFile(Cam2, _cam2Path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
        /// <summary>
        /// 保存检测Vpp
        /// </summary>
        /// <returns></returns>
        public bool SaveTB()
        {
            try
            {
                //CogSerializer.SaveObjectToFile(InsepectionTB, _inspectTBPath);
                CogSerializer.SaveObjectToFile(DownCameraTB, _downTBPath);
                CogSerializer.SaveObjectToFile(RecheckTB, _recheckTBPath);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// 关闭相机
        /// </summary>
        public void CloseCam()
        {
            try
            {
                CogFrameGrabbers frameGrabbers = new CogFrameGrabbers();
                foreach (ICogFrameGrabber g in frameGrabbers)
                    g.Disconnect(false);
            }
            catch (Exception ex)
            {

              
            }
           
        }
    }
}
