using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionproDemo
{
    public partial class FrmCam2 : Form
    {
        public FrmCam2()
        {
            InitializeComponent();
        }
        public Vision frmVision;
        public delegate void LoadVppDelegate();//重新加载Vpp
        public event LoadVppDelegate LoadVppEvent;
        private void FrmCam2_Load(object sender, EventArgs e)
        {
            //显示相机2
            cogAcqFifoEditV21.Subject = frmVision.Cam2;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定保存设置！", "保存设置", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DialogResult.OK == result)
            {
                frmVision.Cam2 = cogAcqFifoEditV21.Subject;
                frmVision.SaveCam();
                MessageBox.Show("保存完成");
            }
        }

        private void tsbSaveAndClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定保存设置！", "保存设置", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DialogResult.OK == result)
            {
                frmVision.Cam2 = cogAcqFifoEditV21.Subject;
                frmVision.SaveCam();
                MessageBox.Show("保存完成");
                this.Close();
            }
        }

        private void FrmCam2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LoadVppEvent != null)//判断事件不为空
            {
                LoadVppEvent.Invoke();//调用
            }
        }
    }
}
