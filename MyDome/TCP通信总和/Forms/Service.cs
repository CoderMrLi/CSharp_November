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

namespace TCP通信总和.Forms {
	public partial class Service : Form {
		public Service() {
			InitializeComponent();
		}

		public Socket ServiceSocket;
		public Socket AcceptSocket;
		public Socket socket;

		public Thread t1;
		public Thread t2;

		private void button1_Click(object sender , EventArgs e) {
			ServiceSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

			IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(IpadsT.Text),int.Parse(PortT.Text));

			try {
				ServiceSocket.Bind(iPEndPoint);
				ServiceSocket.Listen(10);

				RuningMessages.Items.Add("开始监听");
				t1 = new Thread(Listen);
				t1.IsBackground = true;
				t1.Start(ServiceSocket);

			} catch ( Exception ex ) {
				MessageBox.Show(ex.Message,"提示");
				//throw;
			}

		}

		private void Listen(object state) { 
			AcceptSocket = state as Socket;
			try {

				while (true) { 
					socket = AcceptSocket.Accept();
					RuningMessages.Items.Add(DateTime.Now.ToString("HH:mm:ss") +":有客户端连接 ->" + socket.RemoteEndPoint.ToString());

					t2 = new Thread(Recive);
					t2.IsBackground = true;
					t2.Start(socket);

				}


			} catch ( Exception ex ) {
				MessageBox.Show(ex.Message,"提示");
				//throw;
			}

		}

		private void Recive(object state) { 
			socket = state as Socket;
			while ( true ) {
				try {
					byte[] bytes = new byte[1024 * 1024];
					int len = socket.Receive(bytes);
					if ( len == 0 ) break;
					string mes = Encoding.Default.GetString(bytes);
					RuningMessages.Items.Add(DateTime.Now.ToString("HH:mm:ss") + ":接收到消息 -> " +mes);
				} catch ( Exception ex ) {
					MessageBox.Show(ex.Message,"提示");
					return;
				}
			}

		}

		private void Service_Load(object sender , EventArgs e) {
			Control.CheckForIllegalCrossThreadCalls = false;
		}
		
		private void button2_Click(object sender , EventArgs e) {
			if ( socket.Connected ) {
				byte[] bytes = new byte[1024 * 1024];
				bytes = Encoding.Default.GetBytes(SecdText.Text);
				socket.Send(bytes);
			} else {
				MessageBox.Show("未连接！","提示");
			}
		}
	}
}
