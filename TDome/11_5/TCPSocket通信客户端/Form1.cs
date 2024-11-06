using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPSocket通信客户端
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消跨线程检查
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        private Socket clientSocket;
        private Thread t1;

        private void button1_Click(object sender, EventArgs e)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IP和端口
            IPAddress ip = IPAddress.Parse(ipText.Text);
            int port = Convert.ToInt32(portText.Text);

            IPEndPoint ipendpoint = new IPEndPoint(ip, port);

            try
            {

                listBox1.Items.Add("开始尝试建立连接");
                //尝试和对应的地址建立连接
                clientSocket.Connect(ipendpoint);
                listBox1.Items.Add("连接成功");

                t1 = new Thread(Recive);
                t1.IsBackground = true;
                t1.Start(clientSocket);


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //接收数据
        private void Recive(object state)
        {
            Socket socket = state as Socket;

            while (true)
            {
                try
                {

                    byte[] buffer = new byte[1024 * 1024];
                    //接收数据
                    int len = socket.Receive(buffer);
                    if (len == 0)
                        break;
                    //转换为字符串
                    string msg = Encoding.Default.GetString(buffer, 0, len);

                    listBox1.Items.Add($"接收到数据 -> {msg}");


                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[1024 * 1024];
                //转为字节数组
                buffer = Encoding.Default.GetBytes(sendText.Text);

                //如果连接中 发送数据
                if (clientSocket.Connected)
                {
                    clientSocket.Send(buffer);
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clientSocket.Connected)
            {
                t1.Abort();
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
        }
    }
}
