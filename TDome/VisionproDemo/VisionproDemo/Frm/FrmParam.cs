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
    public partial class FrmParam : Form
    {
        public FrmParam()
        {
            InitializeComponent();
        }
        Cls_Config config = Cls_Config.GetInstance();
        private void FrmParam_Load(object sender, EventArgs e)
        {
            txtBaseX.Text = config.BaseX.ToString();
            txtBaseY.Text = config.BaseY.ToString();
            txtBaseA.Text = config.BaseA.ToString();
            txtTieheX.Text = config.TieHeX.ToString();
            txtTieheY.Text = config.TieHeY.ToString();
            txtTieheA.Text = config.TieHeA.ToString();
            txtOrgX.Text = config.OrgX.ToString();
            txtOrgY.Text = config.OrgY.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult res = MessageBox.Show("请确认保存设置！", "参数保存", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.Cancel) return;
                config.BaseX = Convert.ToDouble(txtBaseX.Text.Trim());
                config.BaseY = Convert.ToDouble(txtBaseY.Text.Trim());
                config.BaseA = Convert.ToDouble(txtBaseA.Text.Trim());
                config.TieHeX = Convert.ToDouble(txtTieheX.Text.Trim());
                config.TieHeY = Convert.ToDouble(txtTieheY.Text.Trim());
                config.TieHeA = Convert.ToDouble(txtTieheA.Text.Trim());
                config.OrgX = Convert.ToDouble(txtOrgX.Text.Trim());
                config.OrgY = Convert.ToDouble(txtOrgY.Text.Trim());

                config.WriteConfig("点位", "BaseX", config.BaseX.ToString());
                config.WriteConfig("点位", "BaseY", config.BaseY.ToString());
                config.WriteConfig("点位", "BaseA", config.BaseA.ToString());
                config.WriteConfig("点位", "TieHeX", config.TieHeX.ToString());
                config.WriteConfig("点位", "TieHeY", config.TieHeY.ToString());
                config.WriteConfig("点位", "TieHeA", config.TieHeA.ToString());
                config.WriteConfig("点位", "OrgX", config.OrgX.ToString());
                config.WriteConfig("点位", "OrgY", config.OrgY.ToString());

                MessageBox.Show("保存完成！");

            }
            catch (Exception ex)
            {

                MessageBox.Show("输入的格式不正确" + ex.Message);
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
