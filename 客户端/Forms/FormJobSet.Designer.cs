namespace 客户端.Forms {
	partial class FormJobSet {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存并推出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cogToolBlockEditV21 = new Cognex.VisionPro.ToolBlock.CogToolBlockEditV2();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV21)).BeginInit();
			this.SuspendLayout();
			// 
			// 保存ToolStripMenuItem
			// 
			this.保存ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
			this.保存ToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
			this.保存ToolStripMenuItem.Text = "保存";
			// 
			// 保存并推出ToolStripMenuItem
			// 
			this.保存并推出ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.保存并推出ToolStripMenuItem.Name = "保存并推出ToolStripMenuItem";
			this.保存并推出ToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
			this.保存并推出ToolStripMenuItem.Text = "保存并退出";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.保存并推出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1692, 28);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cogToolBlockEditV21
			// 
			this.cogToolBlockEditV21.AllowDrop = true;
			this.cogToolBlockEditV21.ContextMenuCustomizer = null;
			this.cogToolBlockEditV21.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cogToolBlockEditV21.Location = new System.Drawing.Point(0, 28);
			this.cogToolBlockEditV21.MinimumSize = new System.Drawing.Size(489, 0);
			this.cogToolBlockEditV21.Name = "cogToolBlockEditV21";
			this.cogToolBlockEditV21.ShowNodeToolTips = true;
			this.cogToolBlockEditV21.Size = new System.Drawing.Size(1692, 1035);
			this.cogToolBlockEditV21.SuspendElectricRuns = false;
			this.cogToolBlockEditV21.TabIndex = 4;
			// 
			// FormJobSet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1692, 1063);
			this.Controls.Add(this.cogToolBlockEditV21);
			this.Controls.Add(this.menuStrip1);
			this.Name = "FormJobSet";
			this.Text = "FormJobSet";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV21)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存并推出ToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 cogToolBlockEditV21;
	}
}