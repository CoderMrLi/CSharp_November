using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 九点标定
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //串口
        SerialPort port = new SerialPort();

        private void Form1_Load(object sender, EventArgs e)
        {
            port.PortName = "COM2";
            port.BaudRate = 9600;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            port.DataBits = 8;

            port.DataReceived += Port_DataReceived;

            port.Open();
        }

        FrmNPoint frmNPoint = new FrmNPoint();

        //接收数据事件
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int size = port.BytesToRead;
            byte[] buffer = new byte[size];
            port.Read(buffer, 0, size);

            string msg = Encoding.Default.GetString(buffer);
            //C1标定信号
            if (msg.Contains("C1"))
            {
                frmNPoint.NPointFunc(msg);
            }
            else if (msg.Contains("RC"))
            {
                frmNPoint.RotationFunc(msg);
            }
        }

        //打开窗体
        private void 下相机标定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNPoint.ShowDialog();
        }
    }
}
