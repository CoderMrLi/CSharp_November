using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 产品检测.Class {
	internal class LoadVpp {
		/// <summary>
		/// 相机
		/// </summary>
		public CogAcqFifoTool Cam { get; set; }
		/// <summary>
		/// 工具盒
		/// </summary>
		public CogToolBlock ToolBlock { get; set; }
		/// <summary>
		/// 相机的配置地址
		/// </summary>
		public string path = Directory.GetCurrentDirectory() + "\\vpp\\CamSet.vpp";
		/// <summary>
		/// 工具的配置地址
		/// </summary>
		public string tbPath = Directory.GetCurrentDirectory() + "\\vpp\\ToolBlockSet.vpp";
		/// <summary>
		/// ini文件地址
		/// </summary>
		public string iniFilePath = Directory.GetCurrentDirectory() + "\\ini\\init.ini";

		/// <summary>
		/// 加载配置
		/// </summary>
		/// <returns></returns>
		public bool LoadVPP() {
			//更新配置


			//初始化写入ini文件
			Ini.IniAPI.INIWriteItems(iniFilePath , "sp" , "PortName=COM2\0BaudRate=9600\0DataBits=8\0Parity=None\0StopBits=One");
			Ini.IniAPI.INIWriteItems(iniFilePath , "lv" , "Sum=0\0GProduct=0\0Yield=0");

			Cam = CogSerializer.LoadObjectFromFile(path) as CogAcqFifoTool;
			ToolBlock = CogSerializer.LoadObjectFromFile(tbPath) as CogToolBlock;
			if ( Cam.Operator.FrameGrabber == null || ToolBlock == null ) {
				return false;
			} else {
				return true;
			}

			

		}

		/// <summary>
		/// 关闭相机
		/// </summary>
		public void CloseCam() {
			/*if ( Cam != null ) {
				Cam.Dispose();
			}*/
			if ( Cam != null && Cam.Operator.FrameGrabber != null ) {
				Cam.Operator.FrameGrabber.Disconnect(false);
			}
		}

	}
}
