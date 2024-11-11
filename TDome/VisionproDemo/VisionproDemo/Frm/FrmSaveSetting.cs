using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionproDemo.Properties;

namespace VisionproDemo
{
    public partial class FrmSaveSetting : Form
    {
        public FrmSaveSetting()
        {
            InitializeComponent();
            bSaveData = Settings.Default.bSaveData;
            bSaveImage = Settings.Default.bSaveImage;
            bAutoDelete = Settings.Default.bAutoDelete;
            strSaveDays = Settings.Default.ImageSaveDays;

            strSaveImagePath = Cls_Config.GetInstance().ImageSavePath;
            strSaveDataPath = Cls_Config.GetInstance().DataSavePath;
        }
        public bool bSaveImage;
        public bool bSaveData;
        public bool bAutoDelete;
        public int strSaveDays;
        public string strSaveImagePath;
        public string strSaveDataPath;
        private void FrmSaveSetting_Load(object sender, EventArgs e)
        {
            chb_SaveImage.Checked = bSaveImage ? true : false;
            chbSaveData.Checked = bSaveData ? true : false;
            chb_AutoDelete.Checked = bAutoDelete ? true : false;

            txtSaveDays.Text = strSaveDays.ToString();
            txtSaveDataPath.Text = strSaveDataPath;
            txtSaveImagePath.Text = strSaveImagePath;
        }
        //保存设置
        private void btnSave_Click(object sender, EventArgs e)
        {
            bSaveImage = chb_SaveImage.Checked;
            bSaveData = chbSaveData.Checked;
            bAutoDelete = chb_AutoDelete.Checked;
            strSaveDataPath = txtSaveDataPath.Text;
            strSaveImagePath = txtSaveImagePath.Text;
            strSaveDays = int.Parse(txtSaveDays.Text.Trim());
            Cls_Config.GetInstance().ImageSavePath = strSaveImagePath;
            Cls_Config.GetInstance().DataSavePath = strSaveDataPath;
            Settings.Default.bSaveData = bSaveData ;
            Settings.Default.bSaveImage = bSaveImage;
            Settings.Default.bAutoDelete= bAutoDelete;
            Settings.Default.ImageSaveDays =strSaveDays;

            DialogResult result = MessageBox.Show("确认保存设置", "保存设置", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Settings.Default.Save();//保存设置
                Cls_Config.GetInstance().WriteConfig("路径", "ImageSavePath", strSaveImagePath);
                Cls_Config.GetInstance().WriteConfig("路径", "DataSavePath", strSaveDataPath);
                MessageBox.Show("保存完成");
            }


        }
        //选择图片路径
        private void btnSelectImagePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.SelectedPath = strSaveImagePath;
            
            //DialogResult result = folder.ShowDialog();
            //if (result == DialogResult.OK)
            //{

            //}

            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtSaveImagePath.Text = folder.SelectedPath;
                strSaveImagePath = folder.SelectedPath;
            }
        }
        //选择数据存放路径
        private void btnSelectDataPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.SelectedPath = strSaveDataPath;

            //DialogResult result = folder.ShowDialog();
            //if (result == DialogResult.OK)
            //{

            //}

            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtSaveDataPath.Text = folder.SelectedPath;
                strSaveDataPath = folder.SelectedPath;
            }

        }
    }
}
