using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 九点标定
{
    internal class Vision
    {
        //标定的TB
        public CogToolBlock NPointTB;
        //相机
        public CogAcqFifoTool FifoTool;

        private string NPointTB_path = Directory.GetCurrentDirectory() + "\\vpp\\NPoint.vpp";
        private string FifoTool_path = Directory.GetCurrentDirectory() + "\\vpp\\AcqFifoTool.vpp";

        public void Load()
        {
            NPointTB = CogSerializer.LoadObjectFromFile(NPointTB_path) as CogToolBlock;
            FifoTool = CogSerializer.LoadObjectFromFile(FifoTool_path) as CogAcqFifoTool;
        }
    }
}
