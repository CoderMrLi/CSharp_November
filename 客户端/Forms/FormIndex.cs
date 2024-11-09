using 客户端.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 客户端 {
	public partial class FormIndex : Form {
		public FormIndex() {
			InitializeComponent();
			MessageBox.Show("程序启动！");
			//AddRuningMessages("程序启动！");
			RuningMessages.Items.Add("程序启动！");
		}

		#region think
		/* 
		 * 项目启动，提示程序启动
		 * 读取配置信息（统计信息,Socket连接信息），完成后提示读取配置文件完成！
		 * 加载VPP， 完成后提示加载VPP完成！
		 * 建立Socket连接 连接后提示连接服务器, 修改状态栏，计时器时刻检查连接状态，修改文本
		 * 
		 * RuningMessages添加信息导致线程跨越！！！
		 * 
		 * 
		 */

		#endregion


		#region 程序所需变量声明
		/// <summary>
		/// ini路径
		/// </summary>
		string iniFilePath = Directory.GetCurrentDirectory() + "\\ini";
		
		

		/// <summary>
		/// IP终结点
		/// </summary>
		IPEndPoint iPEndPoint;

		/// <summary>
		/// 连接服务端
		/// </summary>
		public Socket Socket;
		
		/// <summary>
		/// 接受数据线程
		/// </summary>
		public Thread t1;
		


		#endregion


		private void FormIndex_Load(object sender , EventArgs e) {
			#region 加载配置
			RuningMessages.Items.Add("开始加载配置文件...");
			BeginMonitor();
			RuningMessages.Items.Add("加载配置文件完成！");
			#endregion

			#region 加载VPP
			RuningMessages.Items.Add("开始加载VPP...");
			LoadVPP();
			RuningMessages.Items.Add("加载VPP完成！");
			#endregion

			#region 连接服务器
			RuningMessages.Items.Add("开始建立连接...");
			try {
				Socket.Connect(iPEndPoint);
				RuningMessages.Items.Add("连接成功！");
				t1 = new Thread(Recive);
				t1.IsBackground = true;
				t1.Start(Socket);
			} catch ( Exception ex  ) {
				MessageBox.Show(ex.Message , "连接服务器引发异常");
			}
			#endregion

			#region 连接成功后检测状态
			//项目加载过程中开启计时器
			timer1.Start();
			#endregion


		}
		/// <summary>
		/// 定时器检测客户端及PLC的连接状态
		/// </summary>
		private void timer1_Tick(object sender , EventArgs e) {
			if ( Socket == null ) {
				ClientStatus.Text = "未连接";
				ClientStatus.ForeColor = Color.Red;
			} else if(Socket.Poll(1000,SelectMode.SelectRead)){
				byte[] bytes = new byte[1024];
				int len = Socket.Receive(bytes);
				if ( len == 0 ) {
					//RuningMessages.Items.Add("服务器断开连接！");
					ClientStatus.Text = "已断开";
					ClientStatus.ForeColor = Color.Red;
					/*
					#region 重新连接
					int j = 0;
					for ( int i = 0; j < 5; i++ ) {
						j++;
						RuningMessages.Items.Add("开始尝试重新建立连接...（" + j + "）");
						try {
							Socket.Connect(iPEndPoint);
							RuningMessages.Items.Add("连接成功！");
							t1 = new Thread(Recive);
							t1.IsBackground = true;
							t1.Start(Socket);
						} catch ( Exception ex ) {
							//MessageBox.Show(ex.Message , "连接服务器引发异常");
						}
					}
					#endregion
					*/
				}
			} else {
				ClientStatus.Text = "已连接";
				ClientStatus.ForeColor = Color.Green;
			}
		}

		
		/// <summary>
		/// 接收消息
		/// </summary>
		/// <param name="state"></param>
		private void Recive(object state) { 
			Socket Rsocket = state as Socket;
			while ( true ) {
				try {
					byte[] buffer = new byte[1024 * 1024];
					int len = Rsocket.Receive(buffer);
					if ( len == 0 ) break;
					string msg = Encoding.Default.GetString(buffer, 0, len);
					AddRuningMessages("接收到数据 -> " + msg);
				} catch ( Exception ex ) {
					MessageBox.Show(ex.Message);
				}
			}
		}


		/// <summary>
		/// RuningMessages添加信息导致线程跨越！！！
		/// </summary>
		/// <param name="megs">需要添加的信息（自动添加时间）</param>
		private void AddRuningMessages(string megs) {
			Invoke(new MethodInvoker( () => {
				RuningMessages.Items.Add(DateTime.Now.ToString("HH:mm:ss") + "：" + megs);
			}));
		}

		/// <summary>
		/// //更新数据（统计信息 and Socket的连接信息）
		/// </summary>
		private void BeginMonitor() {
			//初始化
			Socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
			//更新数据（统计信息 and Socket的连接信息）
			try {
				SumShow.Text = Ini.IniAPI.GetPrivateProfileString("Statistics" , "Sum" , "" , iniFilePath + "\\init.ini");
				GoodProductsShow.Text = Ini.IniAPI.GetPrivateProfileString("Statistics" , "GoodProducts" , "" , iniFilePath + "\\init.ini");
				Double Yield = Double.Parse(GoodProductsShow.Text) / Double.Parse(SumShow.Text) * 100;
				YieldNum.Text = Yield.ToString() == "NaN" ? "0" + "%" : Yield.ToString() + "%";
				//IP终结点
				iPEndPoint = new IPEndPoint(IPAddress.Parse(Ini.IniAPI.GetPrivateProfileString("SocketmMessages","ipPath","",iniFilePath+"\\init.ini")),Ini.IniAPI.GetPrivateProfileInt("SocketmMessages","portNum",0,iniFilePath+"\\init.ini"));
			} catch ( Exception ex ) {
				MessageBox.Show(ex.Message,"配置信息加载触发异常！");
				//throw;
			}
		}

		/// <summary>
		/// 加载VPP
		/// </summary>
		private void LoadVPP() { 
			//相机连接，工具盒加载
			CogLoad cogLoad = new CogLoad();
			if ( !cogLoad.LoadVpp() ) {
				RuningMessages.Items.Add("VPP加载失败！");
			}
		}

		private void 退出ToolStripMenuItem_Click(object sender , EventArgs e) {
			this.Close();
		}

		private void 相机1ToolStripMenuItem_Click(object sender , EventArgs e) {
			Forms.FormCamSet formCamSet = new Forms.FormCamSet();
			formCamSet.ShowDialog();
			//重新加载相机获取使用权限
		}

		private void 作业1ToolStripMenuItem_Click(object sender , EventArgs e) {
			Forms.FormJobSet formJobSet = new Forms.FormJobSet();
			formJobSet.ShowDialog();
			//重新加载作业获取使用权限
		}
	}
}
