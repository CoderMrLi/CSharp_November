using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
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
	public partial class FormJobSet : Form {

		CogToolBlock CogToolBlock;
		string path = null;
		public FormJobSet(CogToolBlock CogToolBlock, string path) {
			InitializeComponent();
			this.CogToolBlock = CogToolBlock;
			this.path = path;
		}

		private void FormJobSet_Load(object sender , EventArgs e) {
			//CogToolBlock = CogSerializer.LoadObjectFromFile(path) as CogToolBlock;
			cogToolBlockEditV21.Subject = CogToolBlock;
		}

		private void 保存ToolStripMenuItem_Click(object sender , EventArgs e) {
			CogSerializer.SaveObjectToFile(CogToolBlock,path);
			MessageBox.Show("已将作业配置保存至指定文件夹！","提示");
		}

		private void 退出ToolStripMenuItem_Click(object sender , EventArgs e) {
			this.Close();
		}
	}
}
