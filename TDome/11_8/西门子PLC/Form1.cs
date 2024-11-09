using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionproDemo;
using S7.Net;

namespace 西门子PLC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //声明plc
        SiemensPLC plc;

        private void Form1_Load(object sender, EventArgs e)
        {
            plc = new SiemensPLC(CpuType.S71200, "192.168.8.10", 0, 1);
            //连接
            plc.ConnectPlc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //如果为true 表示T1拍照信号
            if ((bool)plc.Read("DB14.DBX0.0"))
            {
                //拍照

                //运行完了 反馈一个布尔信号 表示让他继续运行
                plc.Write("DB14.DBX0.1",true);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            plc.DisconnectPlc();
        }
    }
}
