using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 产品检测.Forms;
using Cognex.VisionPro;
using System.IO;
using 产品检测.Class;

namespace 产品检测 {
	public partial class FormIndex : Form {
		public FormIndex() {
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
		}


		/// <summary>
		/// 串口通信变量声明
		/// </summary>
		SerialPort port = new SerialPort();
		/// <summary>
		/// 串口初始化
		/// </summary>
		string[] portSet = new string[5];

		/// <summary>
		/// 相机和盒子的生成
		/// </summary>
		LoadVpp loadVpp = new LoadVpp();

		


		/// <summary>
		/// 主程序启动时
		/// </summary>
		public void FormIndex_Load(object sender , EventArgs e) {
			#region 串口信息加载

			#region 字符串分割获取串口配置值
			string[] IniSpSet = Ini.IniAPI.INIGetAllItems(loadVpp.iniFilePath,"sp");
			for ( int i = 0; i < IniSpSet.Length; i++ ) {
				portSet[i] = IniSpSet[i].Split('=')[1];
			}
			#endregion

			port.PortName = portSet[0];
			port.BaudRate = int.Parse(portSet[1]);
			port.DataBits = int.Parse(portSet[2]);
			port.Parity = (Parity)System.Enum.Parse(typeof(Parity) , portSet[3]);
			port.StopBits = (StopBits)System.Enum.Parse(typeof(StopBits) , portSet[4]);
			port.DataReceived += port_Date;
			#endregion

			#region 连接串口
			try {
				port.Open();
				//清空运行信息后显示串口连接成功
				MessageList.Items.Clear();
				MessageList.Items.Add("串口连接成功！");
			} catch {
				MessageList.Items.Add("串口连接失败！！！");

				MessageBox.Show("串口连接失败！\n请检查串口后重启软件！" , "警告");

			}
			#endregion

			#region 相机初始化
			if ( !loadVpp.LoadVPP() ) {
				MessageBox.Show("相机连接失败！" , "提示");
				MessageList.Items.Add("相机连接失败！！！");
			} else { 
				MessageList.Items.Add("相机连接成功！");
			}
			#endregion

			

		}



		/// <summary>
		/// 串口信息更新时触发，接收T1时开始运行拍照
		/// </summary>
		private void port_Date(object sender , SerialDataReceivedEventArgs e) {
			int size = port.BytesToRead;

			byte[] data = new byte[size];

			port.Read(data , 0 , size);

			string msg = Encoding.UTF8.GetString(data);

			if ( msg.Contains("T1") ) {
				port.WriteLine("Start running the photo command!");

				#region 开始拍照

				loadVpp.Cam.Run();
				MessageList.Items.Add("开始拍照！");
				cogRecordDisplay1.Image = loadVpp.Cam.OutputImage;
				cogRecordDisplay1.Fit();
				MessageList.Items.Add("拍照完成！");
				#endregion
				#region 开始检测
				MessageList.Items.Add("开始检测！");
				loadVpp.ToolBlock.Inputs["InputImg"].Value = loadVpp.Cam.OutputImage;
				loadVpp.ToolBlock.Run();
				
				//这里总数加加？？？

				if ( loadVpp.ToolBlock.RunStatus.Result == CogToolResultConstants.Accept ) {
					//label1.Text = "Width:" + loadVpp.ToolBlock.Outputs["Width"].Value.ToString();
					//有结果的时候进行总数加加
					int Sum = Ini.IniAPI.GetPrivateProfileInt("lv" , "Sum" , -1 , loadVpp.iniFilePath);
					Sum++;
					Ini.IniAPI.INIWriteValue(loadVpp.iniFilePath , "lv" , "Sum" , Sum.ToString());
					int GP = Ini.IniAPI.GetPrivateProfileInt("lv" , "GProduct" , -1 , loadVpp.iniFilePath);
					if ( (Double)loadVpp.ToolBlock.Outputs["Width"].Value >= 240 ) {
						//🆗
						MessageList.Items.Add("检测完成：OK！");
						IsOK.Text = "OK";
						IsOK.BackColor = Color.Green;
						GP++;
						Ini.IniAPI.INIWriteValue(loadVpp.iniFilePath , "lv" , "GProduct" , GP.ToString());
					} else {
						//NG
						MessageList.Items.Add("检测完成：NG！！！");
						IsOK.Text = "NG";
						IsOK.BackColor = Color.Red;
					}

					//良率计算
					Double YieldNum = Math.Round((Double.Parse(GP.ToString()) /Double.Parse(Sum.ToString())),2)  * 100;
					Ini.IniAPI.INIWriteValue(loadVpp.iniFilePath , "lv" , "Yield" , YieldNum.ToString());
					//Ini.IniAPI.GetPrivateProfileDouble("lv","Yield",-1,loadVpp.iniFilePath);
					textBox1.Text = Ini.IniAPI.GetPrivateProfileInt("lv" , "Sum" , -1 , loadVpp.iniFilePath).ToString();
					textBox2.Text = Ini.IniAPI.GetPrivateProfileInt("lv" , "GProduct" , -1 , loadVpp.iniFilePath).ToString();
					textBox3.Text = Ini.IniAPI.GetPrivateProfileDouble("lv" , "Yield" , -1 , loadVpp.iniFilePath).ToString() + "%";


				} else {
					MessageBox.Show("运行失败，请检查相机配置，或产品位置！");
				}


				cogRecordDisplay2.Record = loadVpp.ToolBlock.CreateLastRunRecord().SubRecords["CogPMAlignTool1.InputImage"];
				cogRecordDisplay2.Fit();
				#endregion

			} else {
				port.WriteLine("Command not present!");
			}
		}





		#region 串口设置
		private void 串口设置ToolStripMenuItem_Click(object sender , EventArgs e) {
			FormSpSet1 formSpSet = new FormSpSet1(loadVpp.iniFilePath,portSet);
			formSpSet.ShowDialog();
			loadVpp.LoadVPP();
		}

		#endregion

		#region 相机设置
		private void 相机设置ToolStripMenuItem_Click(object sender , EventArgs e) {
			FormCamSet formSpSet = new FormCamSet(loadVpp.Cam, loadVpp.path);
			formSpSet.ShowDialog();
			loadVpp.LoadVPP();
		}

		#endregion

		#region 作业设置
		private void 作业设置ToolStripMenuItem_Click(object sender , EventArgs e) {
			FormJobSet formSpSet = new FormJobSet(loadVpp.ToolBlock,loadVpp.tbPath);
			formSpSet.ShowDialog();
			loadVpp.LoadVPP();
		}

		#endregion

		/// <summary>
		/// 窗体关闭时断开相机连接
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormIndex_FormClosing(object sender , FormClosingEventArgs e) {
			loadVpp.CloseCam();
		}
	}
}
//169.254.105.7
