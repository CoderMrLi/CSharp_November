using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 产品检测.Class;

namespace 产品检测.Forms {
	public partial class FormSpSet1 : Form {
		/// <summary>
		/// 串口数据数组
		/// </summary>
		//string[] portSet = new string[5];
		
		string iniFilePath = null;
		public FormSpSet1(string iniFilePath , string[] portSet) {
			InitializeComponent();
			//this.portSet = portSet;
			this.iniFilePath = iniFilePath;
		}

		private void button1_Click(object sender , EventArgs e) {
			//运行完成提示！
			if ( Ini.IniAPI.INIWriteValue(iniFilePath , "sp" , "PortName" , SpName.Text)
				&& Ini.IniAPI.INIWriteValue(iniFilePath , "sp" , "BaudRate" , Btl.Text)
				&& Ini.IniAPI.INIWriteValue(iniFilePath , "sp" , "DataBits" , Sjw.Text)
				&& Ini.IniAPI.INIWriteValue(iniFilePath , "sp" , "Parity" , Jyw.Text)
				&& Ini.IniAPI.INIWriteValue(iniFilePath , "sp" , "StopBits" , Tzw.Text) ) {
				MessageBox.Show("配置成功保存至ini文件！" , "提示");
			} else { 
				MessageBox.Show("配置保存失败！","提示");
			}
		}

		private void FormSpSet_Load(object sender , EventArgs e) {
			SpName.Text = Ini.IniAPI.GetPrivateProfileString("sp", "PortName" , "COM",iniFilePath);
			Btl.Text = Ini.IniAPI.GetPrivateProfileString("sp", "BaudRate" , "9600",iniFilePath);
			Sjw.Text = Ini.IniAPI.GetPrivateProfileString("sp", "DataBits" , "8",iniFilePath);
			Jyw.Text = Ini.IniAPI.GetPrivateProfileString("sp", "Parity" , "None",iniFilePath);
			Tzw.Text = Ini.IniAPI.GetPrivateProfileString("sp", "StopBits" , "One",iniFilePath);
			/*if ( portSet != null ) {
				SpName.Text = portSet[0];
				Btl.Text = portSet[1];
				Sjw.Text = portSet[2];
				Jyw.Text = portSet[3];
				Tzw.Text = portSet[4];
			}*/
		}

		private void button2_Click(object sender , EventArgs e) {
			this.Close();
		}

		private void FormSpSet1_FormClosed(object sender , FormClosedEventArgs e) {

		}
	}
}
