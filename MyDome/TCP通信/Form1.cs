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

namespace TCP通信 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		/// <summary>
		/// 用于创建监听的socket
		/// </summary>
		public Socket ServerSocket;
		/// <summary>
		/// 用于接收监听到动态信息
		/// </summary>
		public Socket AcceptSocket;
		/// <summary>
		/// 用于通信
		/// </summary>
		public Socket socket;
		/// <summary>
		/// 用于接收客户端连接的线程
		/// </summary>
		public Thread t1;
		/// <summary>
		/// 用于通信的线程
		/// </summary>
		public Thread t2;




		private void button1_Click(object sender , EventArgs e) {
			//初始化套接字（通讯方案 使用IPv4协议，使用什么方式进行交互 使用流方式，使用TCP协议）
			ServerSocket = new Socket(AddressFamily.InterNetwork , SocketType.Stream , ProtocolType.Tcp);
			//获取IP框中的IP
			IPAddress ip = IPAddress.Parse(ipadds.Text);
			//获取端口框中的端口
			int port = int.Parse(Port.Text);
			//IP和端口 和在一起 得到一个 网络终结点
			IPEndPoint iPEndPoint = new IPEndPoint(ip, port);

			try {
				//绑定终结点准备进行监听
				ServerSocket.Bind(iPEndPoint);
				//开始监听（允许最大连接数量）
				ServerSocket.Listen(10);
				RuningMessage.Items.Add("开始监听");


				//等待客户端的来连接将会停止主线程
				//所以新创建一个线程用来处理连接这件事
				//当有客户端连接时新建一个socket接收这个通信
				//ServerSocket.Accept();

				t1 = new Thread(Listen);
				t1.IsBackground = true;
				t1.Start(ServerSocket);


			} catch ( Exception ex ) {
				MessageBox.Show(ex.Message);
			}

		}

		/// <summary>
		/// 接受客户端的连接
		/// </summary>
		private void Listen(object state) { 
			AcceptSocket = state as Socket;
			try {
				//死循环 不断的接收客户端的连接
				while ( true ) {
					//等待客户端的连接会阻塞线程
					socket = AcceptSocket.Accept();
					//MessageBox.Show("有客户端连接：" + socket.RemoteEndPoint.ToString());
					RuningMessage.Items.Add("有客户端连接：" + socket.RemoteEndPoint.ToString());
					//创建用于接收消息的线程
					t2 = new Thread(Recive);
					t2.IsBackground = true;
					t2.Start(socket);

				}
			} catch ( Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
		/// <summary>
		/// 接收消息
		/// </summary>
		/// <param name="state"></param>
		private void Recive(object state) { 
			socket = state as Socket;
			while ( true ) {
				try {
					byte[] buffer = new byte[1024 * 1024];
					int len = socket.Receive(buffer);
					if ( len == 0 ) break;

					string msg = Encoding.Default.GetString(buffer);
					RuningMessage.Items.Add("接收到消息 -> " + msg);


				} catch ( Exception ex) {
					MessageBox.Show(ex.Message);
					//throw;
				}
			}
		}

		private void Form1_Load(object sender , EventArgs e) {
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		private void button2_Click(object sender , EventArgs e) {
			try {
				byte[] bytes = new byte[1024 * 1024];
				bytes = Encoding.Default.GetBytes(textBox1.Text);
				socket.Send(bytes);
			} catch ( Exception ex ) { 
				
				MessageBox.Show(ex.Message);
			}
		}

		private void Form1_FormClosing(object sender , FormClosingEventArgs e) {
			if ( socket != null ) {
				t2.Abort();
				socket.Shutdown(SocketShutdown.Both);
				socket.Close();

				
			}
			ServerSocket.Close();
			AcceptSocket.Close();
			t1.Abort();
		}
	}
}
