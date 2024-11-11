
namespace VisionproDemo
{
    partial class FrmEditTB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditTB));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAndClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cogToolBlockEditV21 = new Cognex.VisionPro.ToolBlock.CogToolBlockEditV2();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV21)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbSaveAndClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1083, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(36, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbSaveAndClose
            // 
            this.tsbSaveAndClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSaveAndClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAndClose.Image")));
            this.tsbSaveAndClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAndClose.Name = "tsbSaveAndClose";
            this.tsbSaveAndClose.Size = new System.Drawing.Size(72, 22);
            this.tsbSaveAndClose.Text = "保存并关闭";
            this.tsbSaveAndClose.Click += new System.EventHandler(this.tsbSaveAndClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cogToolBlockEditV21);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1083, 602);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cogToolBlockEditV21
            // 
            this.cogToolBlockEditV21.AllowDrop = true;
            this.cogToolBlockEditV21.ContextMenuCustomizer = null;
            this.cogToolBlockEditV21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogToolBlockEditV21.Location = new System.Drawing.Point(3, 17);
            this.cogToolBlockEditV21.MinimumSize = new System.Drawing.Size(489, 0);
            this.cogToolBlockEditV21.Name = "cogToolBlockEditV21";
            this.cogToolBlockEditV21.ShowNodeToolTips = true;
            this.cogToolBlockEditV21.Size = new System.Drawing.Size(1077, 582);
            this.cogToolBlockEditV21.SuspendElectricRuns = false;
            this.cogToolBlockEditV21.TabIndex = 0;
            // 
            // FrmEditTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 627);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmEditTB";
            this.Text = "Inspection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditTB_FormClosing);
            this.Load += new System.EventHandler(this.FrmEditTB_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbSaveAndClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 cogToolBlockEditV21;
    }
}