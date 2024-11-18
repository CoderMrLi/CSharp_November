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
    public partial class FrmEditNPointTB : Form
    {
        Vision vision;
        public FrmEditNPointTB(Vision vision)
        {
            InitializeComponent();
            this.vision = vision;
        }

        private void FrmEditNPointTB_Load(object sender, EventArgs e)
        {
            //窗体加载的时候 加载对应的TB
            cogToolBlockEditV21.Subject = vision.NPointTB;
        }
    }
}
