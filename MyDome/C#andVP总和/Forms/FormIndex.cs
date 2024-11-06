using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_andVP总和 {
	public partial class FormIndex : Form {

		#region think
		/*项目启动，提示程序启动
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
		


		#endregion


		private void FormIndex_Load(object sender , EventArgs e) {

			//项目加载过程中开启计时器
			timer1.Start();

		}
		/// <summary>
		/// 定时器检测客户端及PLC的连接状态
		/// </summary>
		private void timer1_Tick(object sender , EventArgs e) {

		}











		public FormIndex() {
			InitializeComponent();
			MessageBox.Show("程序启动！");
			RuningMessages.Items.Add("程序启动！");

		}

		
	}
}
