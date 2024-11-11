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
    public partial class FrmEditTB : Form
    {
        public Vision vision; // = Vision.GetInstance();
        public delegate void LoadVppDelagate();
        public event LoadVppDelagate LoadVppEvent;
        public FrmEditTB()
        {
            InitializeComponent();
        }

        private void FrmEditTB_Load(object sender, EventArgs e)
        {
            cogToolBlockEditV21.Subject = vision.DownCameraInspectTB;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            vision.DownCameraInspectTB = cogToolBlockEditV21.Subject;
            //弹窗 第一个参数 显示的文本， 第二个参数 标题文本， 第三个参数 确定和取消按钮，第四个参数 显示的图标 
            DialogResult result = MessageBox.Show("请确认保存相机设置！", "保存设置", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                vision.SaveTB();
               
                MessageBox.Show("保存完成!");
            }
        }

        private void tsbSaveAndClose_Click(object sender, EventArgs e)
        {
            vision.DownCameraInspectTB = cogToolBlockEditV21.Subject;
            //弹窗 第一个参数 显示的文本， 第二个参数 标题文本， 第三个参数 确定和取消按钮，第四个参数 显示的图标 
            DialogResult result = MessageBox.Show("请确认保存相机设置！", "保存设置", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                vision.SaveTB();
               
                MessageBox.Show("保存完成!");
                this.Close();
            }
            
        }

        private void FrmEditTB_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LoadVppEvent != null)
                LoadVppEvent.Invoke();
        }
    }
}
