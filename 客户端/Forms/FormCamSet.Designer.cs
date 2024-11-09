namespace 客户端.Forms {
	partial class FormCamSet {
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
			this.cogAcqFifoEditV21 = new Cognex.VisionPro.CogAcqFifoEditV2();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存并推出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.cogAcqFifoEditV21)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cogAcqFifoEditV21
			// 
			this.cogAcqFifoEditV21.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cogAcqFifoEditV21.Location = new System.Drawing.Point(0, 28);
			this.cogAcqFifoEditV21.MinimumSize = new System.Drawing.Size(489, 0);
			this.cogAcqFifoEditV21.Name = "cogAcqFifoEditV21";
			this.cogAcqFifoEditV21.Size = new System.Drawing.Size(1694, 1032);
			this.cogAcqFifoEditV21.SuspendElectricRuns = false;
			this.cogAcqFifoEditV21.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.保存并推出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1694, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
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
			// FormCamSet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1694, 1060);
			this.Controls.Add(this.cogAcqFifoEditV21);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormCamSet";
			this.Text = "FormCamSet";
			((System.ComponentModel.ISupportInitialize)(this.cogAcqFifoEditV21)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Cognex.VisionPro.CogAcqFifoEditV2 cogAcqFifoEditV21;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存并推出ToolStripMenuItem;
	}
}