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
    public partial class FrmRecheck : Form
    {
        public FrmRecheck()
        {
            InitializeComponent();
        }
        public Vision frmVision;
        public delegate void LoadVppdelegate();
        public event LoadVppdelegate LoadVppEvent;
        private void FrmRecheck_Load(object sender, EventArgs e)
        {
            cogToolBlockEditV21.Subject = frmVision.RecheckTB;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认保存设置", "保存", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                frmVision.RecheckTB = cogToolBlockEditV21.Subject;
                frmVision.SaveTB();
                MessageBox.Show("保存完成");


            }
        }

        private void FrmRecheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (LoadVppEvent != null)
            //    LoadVppEvent.Invoke();

            LoadVppEvent?.Invoke();//首先判断事件不为空，然后进行调用

        }
    }
}
