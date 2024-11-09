using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 客户端.Class {
	internal class CogLoad {
		/// <summary>
		/// 相机工具
		/// </summary>
		public CogAcqFifoTool CamTool {  get; set; }
		/// <summary>
		/// 工具盒工具
		/// </summary>
		public CogToolBlock ToolBlock { get; set; }

		string CamPath = Directory.GetCurrentDirectory() + "\\vpp\\CamFifo.vpp";
		string TBPath = Directory.GetCurrentDirectory() + "\\vpp\\TB.vpp";

		/// <summary>
		/// 加载VPP
		/// </summary>
		/// <returns>是否加载VPP成功</returns>
		public bool LoadVpp() { 
			CamTool	= CogSerializer.LoadObjectFromFile(CamPath) as CogAcqFifoTool;
			
			ToolBlock = CogSerializer.LoadObjectFromFile(TBPath) as CogToolBlock;
			if ( CamTool == null || ToolBlock == null ) {
				return false;
			} else { 
				return true;
			}
		}
		/// <summary>
		/// 关闭相机
		/// </summary>
		public void CloseCam() {
			if ( CamTool != null ) { 
				//CamTool.Container.Dispose();
				CamTool.Dispose();
			}
		}
	}
}
