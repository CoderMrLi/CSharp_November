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
    public partial class FrmCam : Form
    {
        public Vision vision;
        public FrmCam()
        {
            InitializeComponent();
        }
        public delegate void LoadVppDelagate();
        public event LoadVppDelagate LoadVppEvent;
        private void FrmCam_Load(object sender, EventArgs e)
        {
            cogAcqFifoEditV21.Subject = vision.DownCam;
        }
        //保存
        private void tsbSave_Click(object sender, EventArgs e)
        {
            vision.DownCam = cogAcqFifoEditV21.Subject;
            //弹窗 第一个参数 显示的文本， 第二个参数 标题文本， 第三个参数 确定和取消按钮，第四个参数 显示的图标 
            DialogResult result = MessageBox.Show("请确认保存作业！", "保存作业", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                vision.SaveCam();
                MessageBox.Show("保存完成!");
            }
        }
        //保存并关闭
        private void tsbSaveAndClose_Click(object sender, EventArgs e)
        {
            vision.DownCam = cogAcqFifoEditV21.Subject;
            DialogResult result = MessageBox.Show("请确认保存相机作业！", "保存作业", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                vision.SaveCam();
                MessageBox.Show("保存完成!");
                this.Close();//关闭当前窗体
            }
           
        }

        private void FrmCam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LoadVppEvent != null)
                LoadVppEvent.Invoke();
        }
    }
}
