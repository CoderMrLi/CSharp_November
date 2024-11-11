
namespace VisionproDemo
{
    partial class FrmNPoint
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNPoint));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwNpoint = new System.Windows.Forms.DataGridView();
            this.PixX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PixY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorldX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorldY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveCalib = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.LblRms = new System.Windows.Forms.Label();
            this.LblSkew = new System.Windows.Forms.Label();
            this.LblRotation = new System.Windows.Forms.Label();
            this.Lblsf = new System.Windows.Forms.Label();
            this.LblPyY = new System.Windows.Forms.Label();
            this.LblPyX = new System.Windows.Forms.Label();
            this.tableLayoutPanelDIsplay = new System.Windows.Forms.TableLayoutPanel();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtBCR = new System.Windows.Forms.TextBox();
            this.TxtBCY = new System.Windows.Forms.TextBox();
            this.TxtBCX = new System.Windows.Forms.TextBox();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgwRC = new System.Windows.Forms.DataGridView();
            this.FitCircleX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FitCircleY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNpoint)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.tableLayoutPanelDIsplay.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRC)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelDIsplay, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 611);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLeft.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanelLeft.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanelLeft.Controls.Add(this.GroupBox3, 0, 2);
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 4;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.38461F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.61539F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(344, 605);
            this.tableLayoutPanelLeft.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwNpoint);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NPoint参数";
            // 
            // dgwNpoint
            // 
            this.dgwNpoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNpoint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PixX,
            this.PixY,
            this.WorldX,
            this.WorldY});
            this.dgwNpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwNpoint.Location = new System.Drawing.Point(3, 17);
            this.dgwNpoint.Name = "dgwNpoint";
            this.dgwNpoint.RowTemplate.Height = 23;
            this.dgwNpoint.Size = new System.Drawing.Size(332, 264);
            this.dgwNpoint.TabIndex = 0;
            // 
            // PixX
            // 
            this.PixX.DataPropertyName = "Pix_X";
            this.PixX.HeaderText = "PixX";
            this.PixX.Name = "PixX";
            this.PixX.Width = 70;
            // 
            // PixY
            // 
            this.PixY.DataPropertyName = "Pix_Y";
            this.PixY.HeaderText = "PixY";
            this.PixY.Name = "PixY";
            this.PixY.Width = 70;
            // 
            // WorldX
            // 
            this.WorldX.DataPropertyName = "World_X";
            this.WorldX.HeaderText = "WorldX";
            this.WorldX.Name = "WorldX";
            this.WorldX.Width = 70;
            // 
            // WorldY
            // 
            this.WorldY.DataPropertyName = "World_Y";
            this.WorldY.HeaderText = "WorldY";
            this.WorldY.Name = "WorldY";
            this.WorldY.Width = 70;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveCalib);
            this.groupBox2.Controls.Add(this.BtnEdit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑";
            // 
            // SaveCalib
            // 
            this.SaveCalib.Enabled = false;
            this.SaveCalib.Location = new System.Drawing.Point(107, 34);
            this.SaveCalib.Name = "SaveCalib";
            this.SaveCalib.Size = new System.Drawing.Size(111, 36);
            this.SaveCalib.TabIndex = 10;
            this.SaveCalib.Text = "保存标定作业";
            this.SaveCalib.UseVisualStyleBackColor = true;
            this.SaveCalib.Click += new System.EventHandler(this.SaveCalib_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(20, 32);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(81, 38);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "编辑Tool";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.LblRms);
            this.GroupBox3.Controls.Add(this.LblSkew);
            this.GroupBox3.Controls.Add(this.LblRotation);
            this.GroupBox3.Controls.Add(this.Lblsf);
            this.GroupBox3.Controls.Add(this.LblPyY);
            this.GroupBox3.Controls.Add(this.LblPyX);
            this.GroupBox3.Location = new System.Drawing.Point(3, 393);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(338, 92);
            this.GroupBox3.TabIndex = 3;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Result:";
            // 
            // LblRms
            // 
            this.LblRms.AutoSize = true;
            this.LblRms.Location = new System.Drawing.Point(278, 64);
            this.LblRms.Name = "LblRms";
            this.LblRms.Size = new System.Drawing.Size(29, 12);
            this.LblRms.TabIndex = 5;
            this.LblRms.Text = "RMS:";
            // 
            // LblSkew
            // 
            this.LblSkew.AutoSize = true;
            this.LblSkew.Location = new System.Drawing.Point(278, 26);
            this.LblSkew.Name = "LblSkew";
            this.LblSkew.Size = new System.Drawing.Size(35, 12);
            this.LblSkew.TabIndex = 4;
            this.LblSkew.Text = "倾斜:";
            // 
            // LblRotation
            // 
            this.LblRotation.AutoSize = true;
            this.LblRotation.Location = new System.Drawing.Point(156, 64);
            this.LblRotation.Name = "LblRotation";
            this.LblRotation.Size = new System.Drawing.Size(35, 12);
            this.LblRotation.TabIndex = 3;
            this.LblRotation.Text = "旋转:";
            // 
            // Lblsf
            // 
            this.Lblsf.AutoSize = true;
            this.Lblsf.Location = new System.Drawing.Point(156, 26);
            this.Lblsf.Name = "Lblsf";
            this.Lblsf.Size = new System.Drawing.Size(35, 12);
            this.Lblsf.TabIndex = 2;
            this.Lblsf.Text = "缩放:";
            // 
            // LblPyY
            // 
            this.LblPyY.AutoSize = true;
            this.LblPyY.Location = new System.Drawing.Point(18, 64);
            this.LblPyY.Name = "LblPyY";
            this.LblPyY.Size = new System.Drawing.Size(41, 12);
            this.LblPyY.TabIndex = 1;
            this.LblPyY.Text = "平移Y:";
            // 
            // LblPyX
            // 
            this.LblPyX.AutoSize = true;
            this.LblPyX.Location = new System.Drawing.Point(18, 26);
            this.LblPyX.Name = "LblPyX";
            this.LblPyX.Size = new System.Drawing.Size(41, 12);
            this.LblPyX.TabIndex = 0;
            this.LblPyX.Text = "平移X:";
            // 
            // tableLayoutPanelDIsplay
            // 
            this.tableLayoutPanelDIsplay.ColumnCount = 1;
            this.tableLayoutPanelDIsplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDIsplay.Controls.Add(this.cogRecordDisplay1, 0, 0);
            this.tableLayoutPanelDIsplay.Controls.Add(this.GroupBox4, 0, 1);
            this.tableLayoutPanelDIsplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDIsplay.Location = new System.Drawing.Point(353, 3);
            this.tableLayoutPanelDIsplay.Name = "tableLayoutPanelDIsplay";
            this.tableLayoutPanelDIsplay.RowCount = 2;
            this.tableLayoutPanelDIsplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDIsplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDIsplay.Size = new System.Drawing.Size(395, 605);
            this.tableLayoutPanelDIsplay.TabIndex = 1;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.BtnSave);
            this.GroupBox4.Controls.Add(this.Label3);
            this.GroupBox4.Controls.Add(this.Label2);
            this.GroupBox4.Controls.Add(this.Label1);
            this.GroupBox4.Controls.Add(this.TxtBCR);
            this.GroupBox4.Controls.Add(this.TxtBCY);
            this.GroupBox4.Controls.Add(this.TxtBCX);
            this.GroupBox4.Location = new System.Drawing.Point(3, 305);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(308, 113);
            this.GroupBox4.TabIndex = 5;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "补偿";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(213, 20);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "保存补偿";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 80);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 12);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "R补偿：";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(10, 53);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 12);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Y补偿：";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 12);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "X补偿：";
            // 
            // TxtBCR
            // 
            this.TxtBCR.Location = new System.Drawing.Point(78, 77);
            this.TxtBCR.Name = "TxtBCR";
            this.TxtBCR.Size = new System.Drawing.Size(100, 21);
            this.TxtBCR.TabIndex = 3;
            // 
            // TxtBCY
            // 
            this.TxtBCY.Location = new System.Drawing.Point(78, 50);
            this.TxtBCY.Name = "TxtBCY";
            this.TxtBCY.Size = new System.Drawing.Size(100, 21);
            this.TxtBCY.TabIndex = 2;
            // 
            // TxtBCX
            // 
            this.TxtBCX.Location = new System.Drawing.Point(78, 23);
            this.TxtBCX.Name = "TxtBCX";
            this.TxtBCX.Size = new System.Drawing.Size(100, 21);
            this.TxtBCX.TabIndex = 4;
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(3, 3);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(389, 296);
            this.cogRecordDisplay1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgwRC);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(754, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(244, 605);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "旋转中心参数";
            // 
            // dgwRC
            // 
            this.dgwRC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FitCircleX,
            this.FitCircleY});
            this.dgwRC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwRC.Location = new System.Drawing.Point(3, 17);
            this.dgwRC.Name = "dgwRC";
            this.dgwRC.RowTemplate.Height = 23;
            this.dgwRC.Size = new System.Drawing.Size(238, 585);
            this.dgwRC.TabIndex = 0;
            // 
            // FitCircleX
            // 
            this.FitCircleX.HeaderText = "WorldX";
            this.FitCircleX.Name = "FitCircleX";
            // 
            // FitCircleY
            // 
            this.FitCircleY.HeaderText = "WorldY";
            this.FitCircleY.Name = "FitCircleY";
            // 
            // FrmNPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmNPoint";
            this.Text = "FrmNPoint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNPoint_FormClosing);
            this.Load += new System.EventHandler(this.FrmNPoint_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelLeft.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNpoint)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.tableLayoutPanelDIsplay.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwNpoint;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button SaveCalib;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label LblRms;
        internal System.Windows.Forms.Label LblSkew;
        internal System.Windows.Forms.Label LblRotation;
        internal System.Windows.Forms.Label Lblsf;
        internal System.Windows.Forms.Label LblPyY;
        internal System.Windows.Forms.Label LblPyX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDIsplay;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtBCR;
        internal System.Windows.Forms.TextBox TxtBCY;
        internal System.Windows.Forms.TextBox TxtBCX;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PixX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PixY;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorldX;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorldY;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgwRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FitCircleX;
        private System.Windows.Forms.DataGridViewTextBoxColumn FitCircleY;
    }
}