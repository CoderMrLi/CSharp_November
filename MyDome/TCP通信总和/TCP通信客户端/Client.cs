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

namespace TCP通信客户端.Forms {
	public partial class Client : Form {
		public Client() {
			InitializeComponent();
		}
		public Socket Accsocket;
		public Thread t1;

		private void Client_Load(object sender , EventArgs e) {
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		private void button1_Click(object sender , EventArgs e) {
			Accsocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
			IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ipT.Text),int.Parse(portT.Text));
			try {
				RuningMessages.Items.Add(DateTime.Now.ToString("HH:mm:ss") + ":开始尝试连接！");
				Accsocket.Connect(iPEndPoint);
				RuningMessages.Items.Add(DateTime.Now.ToString("HH:mm:ss") + ":连接成功！");
				t1 = new Thread(Recive);
				t1.IsBackground = true;
				t1.Start(Accsocket);
			} catch ( Exception ex  ) {
				MessageBox.Show(ex.Message,"提示");
			}
		}
		private void Recive(object state) { 
			Socket socket = state as Socket;
			while ( true ) {
				try {
					byte[] bytes = new byte[1024 * 1024];
					int len = socket.Receive(bytes);
					if ( len == 0 ) break;
					string mes = Encoding.Default.GetString(bytes);
					RuningMessages.Items.Add(DateTime.Now.ToString("HH:mm:ss") + ":接收到数据 -> " + mes);
				} catch ( Exception ex ) {
					MessageBox.Show(ex.Message,"提示");
				}
			}
		}

		private void button2_Click(object sender , EventArgs e) {
			try {
				byte[] bytes = new byte[1024 * 1024];
				bytes = Encoding.Default.GetBytes(SendT.Text);
				if ( Accsocket.Connected ) {
					Accsocket.Send(bytes);
				}

			} catch(Exception ex ) {
				MessageBox.Show(ex.Message,"提示");
			}
		}

		private void Client_FormClosing(object sender , FormClosingEventArgs e) {
			t1.Abort();
			Accsocket.Shutdown(SocketShutdown.Both);
			Accsocket.Close();
		}
	}
}
