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

namespace TCP通信
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public Socket serverSocket; //用来创建用于监听的socket
        public Socket acceptSocket; //用于接收
        public Socket socket; //用于通信

        public Thread t1; //用于接收客户端连接
        public Thread t2; //用于通信

        //开启监听
        private void button1_Click(object sender, EventArgs e)
        {
            //初始化套接字(通信方案 使用IPv4协议,使用什么方式进行交互 使用流方式,使用TCP协议)
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //使用框中的IP 转换为IP地址类型
            IPAddress ip = IPAddress.Parse(ipText.Text);
            //端口
            int port = Convert.ToInt32(portText.Text);
            //IP和端口拼接起来 得到一个网络终结点
            IPEndPoint iPEndPoint = new IPEndPoint(ip, port);

            try
            {
                //绑定IP
                serverSocket.Bind(iPEndPoint);
                //开始监听 (最大的连接数量)
                serverSocket.Listen(10);

                //等待客户端连接 如果在这里等待连接 会阻塞主线程
                //所以我们使用一个新的线程负责这件事情
                //serverSocket.Accept();

                listBox1.Items.Add("开始监听");

                t1 = new Thread(Listen);
                //设置为后台线程
                t1.IsBackground = true;
                //启动线程
                t1.Start(serverSocket);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 用于接收客户端的连接
        /// </summary>
        private void Listen(object state)
        {
            acceptSocket = state as Socket;
            try
            {
                //死循环 不断的接收客户端的连接
                while (true)
                {
                    //等待客户端连接 会阻塞线程
                    socket = acceptSocket.Accept();
                    MessageBox.Show($"有客户端建立连接:{socket.RemoteEndPoint.ToString()}");

                    //创建新线程用于接收消息
                    t2 = new Thread(Recive);
                    t2.IsBackground = true;
                    t2.Start(socket);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 接收消息
        /// </summary>
        private void Recive(object state)
        {
            socket = state as Socket;

            //不断接收消息
            while (true)
            {
                try
                {
                    //创建个数组 用于接收消息
                    //1byte = 1b
                    //1024b = 1kb
                    //1024kb = 1mb
                    //最大接收1mb数据
                    byte[] buffer = new byte[1024 * 1024];

                    //接收数据 保存到buffer里面 返回收到的字节数
                    int len = socket.Receive(buffer);
                    //如果没有接收到消息
                    if (len == 0)
                        break;

                    //转换为字符串
                    string msg = Encoding.Default.GetString(buffer, 0, len);
                    listBox1.Items.Add($"接收到消息 -> {msg}");

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //不再捕获垮线程的异常
            //取消跨线程检查
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
