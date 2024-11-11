using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cognex.VisionPro;

namespace VisionproDemo
{
    
    public class Inspection
    {
        public Vision vision;
        public Inspection(Vision mvision)
        {
            vision = mvision;
            FrmMain.FrmNPointInfoEvent += FrmMain_ReceivePointMessageEvent;
        }

        private void FrmMain_ReceivePointMessageEvent(string msg, Cognex.VisionPro.ICogImage image)
        {
            if (msg.Contains("T1"))
            {
                vision.DownCameraInspectTB.Run();
                if (true)
                {

                }
            }
        }

        public void RunToolBlock()
        {

        }
    }
}
