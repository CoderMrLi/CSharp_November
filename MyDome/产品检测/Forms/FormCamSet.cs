using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 产品检测.Forms {
	public partial class FormCamSet : Form {
		string path = null;
		CogAcqFifoTool Cam = null;
		public FormCamSet(CogAcqFifoTool Cam , string path) {
			InitializeComponent();
			this.path = path;
			this.Cam = Cam;
		}

		private void FormCamSet_Load(object sender , EventArgs e) {
			//加载相机配置
			//Cam = CogSerializer.LoadObjectFromFile(path) as CogAcqFifoTool;
			cogAcqFifoEditV21.Subject = Cam;
		}

		private void 保存ToolStripMenuItem_Click(object sender , EventArgs e) {
			CogSerializer.SaveObjectToFile(Cam,path);
			MessageBox.Show("已将相机配置保存至指定文件夹！" , "提示");
		}

		private void 退出ToolStripMenuItem_Click(object sender , EventArgs e) {
			this.Close();
		}
	}
}
