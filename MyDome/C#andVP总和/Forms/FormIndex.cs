﻿using C_andVP总和.Class;
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

namespace C_andVP总和 {
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
		/// vpp路径
		/// </summary>
		string vppFilePath = Directory.GetCurrentDirectory() + "\\vpp";

		/// <summary>
		/// 监听
		/// </summary>
		public Socket Socket;
		/// <summary>
		/// 连接客户端
		/// </summary>
		public Socket LinkSocket;
		/// <summary>
		/// 接收信息
		/// </summary>
		public Socket ReceiveSocket;
		/// <summary>
		/// 建立连接线程
		/// </summary>
		public Thread t1;
		/// <summary>
		/// 收发数据线程
		/// </summary>
		public Thread t2;
		


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
				Socket.Listen(10);
				t1 = new Thread(Listen);
				t1.IsBackground = true;
				t1.Start(Socket);
			} catch ( Exception ex ) {
				MessageBox.Show(ex.Message,"建立连接引发异常！");
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
			if ( ReceiveSocket == null ) {
				ClientStatus.Text = "未连接";
				ClientStatus.ForeColor = Color.Red;
			} else if(ReceiveSocket.Poll(1000,SelectMode.SelectRead)){
				byte[] bytes = new byte[1024];
				int len = ReceiveSocket.Receive(bytes);
				if ( len == 0 ) {
					ClientStatus.Text = "已断开";
					ClientStatus.ForeColor = Color.Red;
				}
			} else {
				ClientStatus.Text = "已连接";
				ClientStatus.ForeColor = Color.Green;
			}
		}

		/// <summary>
		/// 监听消息
		/// </summary>
		/// <param name="state"></param>
		private void Listen(Object state) { 
			LinkSocket = state as Socket;
			try {
				while ( true ) { 
					ReceiveSocket = LinkSocket.Accept();
					MessageBox.Show("有客户端建立连接："+ ReceiveSocket.RemoteEndPoint.ToString());
					AddRuningMessages("客户端建立连接 -> " + ReceiveSocket.RemoteEndPoint.ToString());

					t2 = new Thread(Recive);
					t2.IsBackground = true;
					t2.Start(ReceiveSocket);

				}
			} catch ( Exception ex ) {
				MessageBox.Show(ex.Message,"连接服务器触发异常");
			}
		}
		/// <summary>
		/// 接收消息
		/// </summary>
		/// <param name="state"></param>
		private void Recive(object state) { 
			ReceiveSocket = state as Socket;
			while ( true ) {
				try {
					byte[] bytes = new byte[1024 * 1024];
					int len = ReceiveSocket.Receive(bytes);
					if ( len == 0 ) break;
					string megs = Encoding.Default.GetString(bytes);
					AddRuningMessages("接收到消息 -> " + megs);
				} catch ( Exception ex ) {
					MessageBox.Show(ex.Message,"接收消息触发异常");
					return;
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
				IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(Ini.IniAPI.GetPrivateProfileString("SocketmMessages","ipPath","",iniFilePath+"\\init.ini")),Ini.IniAPI.GetPrivateProfileInt("SocketmMessages","portNum",0,iniFilePath+"\\init.ini"));
				Socket.Bind(iPEndPoint);
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

	}
}
