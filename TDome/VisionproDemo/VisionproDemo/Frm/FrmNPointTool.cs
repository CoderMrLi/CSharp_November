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
namespace VisionproDemo
{
    
    public partial class FrmNPointTool : Form
    {
        public Vision frmVision;
        public delegate void LoadVppDelagate();
        public event LoadVppDelagate LoadVppEvent;
        public FrmNPointTool()
        {
            InitializeComponent();
        }

        private void FrmNPointTool_Load(object sender, EventArgs e)
        {
            cogToolBlockEditV21.Subject = frmVision.DownCameraNpointTB;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认保存设置", "保存设置", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                frmVision.DownCameraNpointTB = cogToolBlockEditV21.Subject;
                //frmVision.SaveTB();
                MessageBox.Show("保存完成");
            }
        }

        private void FrmNPointTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadVppEvent?.Invoke();
        }
    }
}
