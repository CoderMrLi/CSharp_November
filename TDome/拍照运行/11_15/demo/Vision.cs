using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class Vision
    {
        /// <summary>
        /// 12点标定用的TB
        /// </summary>
        public CogToolBlock NPointTB {  get; set; }

        public CogToolBlock detectionTB {  get; set; }

        /// <summary>
        /// 路径
        /// </summary>

        private string NPointTB_path = Directory.GetCurrentDirectory() + "\\vpp\\npointTB.vpp";
        private string DetectionTB_path = Directory.GetCurrentDirectory() + "\\vpp\\detection.vpp";

        /// <summary>
        /// 加载TB
        /// </summary>
        public void load()
        {
            NPointTB = CogSerializer.LoadObjectFromFile(NPointTB_path) as CogToolBlock;
            detectionTB = CogSerializer.LoadObjectFromFile(DetectionTB_path) as CogToolBlock;
        }
    }
}
