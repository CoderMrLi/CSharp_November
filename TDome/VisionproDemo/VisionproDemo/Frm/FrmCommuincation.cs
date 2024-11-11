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
    public partial class FrmCommuincation : Form
    {
        public FrmCommuincation()
        {
            InitializeComponent();
        }
        Cls_Config config = Cls_Config.GetInstance();
        private void FrmCommuincation_Load(object sender, EventArgs e)
        {
            if (Cls_Config.GetInstance().ComAvailable == 1)
            {
                chb_EnableCom.Checked = true;
                txtComName.Enabled = true;
                txtBoundrate.Enabled = true;
                txtDataBits.Enabled = true;
                txtStopBits.Enabled = true;
                txtParity.Enabled = true;
            }
            else
            {
                chb_EnableCom.Checked = false;
                txtComName.Enabled = false;
                txtBoundrate.Enabled = false;
                txtDataBits.Enabled = false;
                txtStopBits.Enabled = false;
                txtParity.Enabled = false;
            }
            if (Cls_Config.GetInstance().TcpAvailable == 1)
            {
                chbTcp.Checked = true;
                txtIP.Enabled = true;
                txt_Port.Enabled = true;
            }
            else
            {
                chbTcp.Checked = false;
                txtIP.Enabled = false;
                txt_Port.Enabled = false;
            }
            txtComName.Text = config.ComName;
            txtBoundrate.Text = config.ComBoundrate.ToString();
            txtParity.Text = config.ComParity.ToString();
            txtStopBits.Text = config.ComStopBits.ToString();
            txtDataBits.Text = config.ComDataBits.ToString();

            txtIP.Text = config.TcpIP;
            txt_Port.Text = config.TcpPort.ToString();
        }

        private void btnSaveCom_Click(object sender, EventArgs e)
        {
            //赋值
            config.ComAvailable = chb_EnableCom.Checked ? 1 : 0;
            config.ComName = txtComName.Text;
            config.ComBoundrate = Convert.ToInt32(txtBoundrate.Text);
            config.ComParity = Convert.ToInt32(txtParity.Text);
            config.ComStopBits = Convert.ToInt32(txtStopBits.Text);
            config.ComDataBits = Convert.ToInt32(txtDataBits.Text);
            //保存
            config.WriteConfig("串口", "ComAvailable", config.ComAvailable.ToString());
            config.WriteConfig("串口", "ComName", config.ComName.ToString());
            config.WriteConfig("串口", "ComBoundrate", config.ComBoundrate.ToString());
            config.WriteConfig("串口", "ComParity", config.ComParity.ToString());
            config.WriteConfig("串口", "ComStopBits", config.ComStopBits.ToString());
            config.WriteConfig("串口", "ComDataBits", config.ComDataBits.ToString());
        }

        private void btnSaveTcp_Click(object sender, EventArgs e)
        {
            //赋值
            config.TcpAvailable = chbTcp.Checked ? 1 : 0;
            config.TcpIP = txtIP.Text;
            config.TcpPort = Convert.ToInt32(txt_Port.Text);
           
            //保存
            config.WriteConfig("网口参数", "TcpAvailable", config.TcpAvailable.ToString());
            config.WriteConfig("网口参数", "TcpIP", config.TcpIP.ToString());
            config.WriteConfig("网口参数", "TcpPort", config.TcpPort.ToString());
            
        }

        private void chb_EnableCom_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_EnableCom.Checked)
            {
                chb_EnableCom.Checked = true;
                txtComName.Enabled = true;
                txtBoundrate.Enabled = true;
                txtDataBits.Enabled = true;
                txtStopBits.Enabled = true;
                txtParity.Enabled = true;
            }
            else
            {

                chb_EnableCom.Checked = false;
                txtComName.Enabled = false;
                txtBoundrate.Enabled = false;
                txtDataBits.Enabled = false;
                txtStopBits.Enabled = false;
                txtParity.Enabled = false;
            }
        }

        private void chbTcp_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTcp.Checked)
            {
                //chbTcp.Enabled = true;
                txtIP.Enabled = true;
                txt_Port.Enabled = true;
            }
            else
            {
                //chbTcp.Enabled = false;
                txtIP.Enabled = false;
                txt_Port.Enabled = false;

            }
        }
    }
}
