
namespace VisionproDemo
{
    partial class FrmSaveSetting
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
            this.chb_SaveImage = new System.Windows.Forms.CheckBox();
            this.chb_AutoDelete = new System.Windows.Forms.CheckBox();
            this.txtSaveDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaveImagePath = new System.Windows.Forms.TextBox();
            this.btnSelectImagePath = new System.Windows.Forms.Button();
            this.chbSaveData = new System.Windows.Forms.CheckBox();
            this.txtSaveDataPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectDataPath = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chb_SaveImage
            // 
            this.chb_SaveImage.AutoSize = true;
            this.chb_SaveImage.Location = new System.Drawing.Point(108, 58);
            this.chb_SaveImage.Name = "chb_SaveImage";
            this.chb_SaveImage.Size = new System.Drawing.Size(72, 16);
            this.chb_SaveImage.TabIndex = 0;
            this.chb_SaveImage.Text = "保存图片";
            this.chb_SaveImage.UseVisualStyleBackColor = true;
            // 
            // chb_AutoDelete
            // 
            this.chb_AutoDelete.AutoSize = true;
            this.chb_AutoDelete.Location = new System.Drawing.Point(219, 58);
            this.chb_AutoDelete.Name = "chb_AutoDelete";
            this.chb_AutoDelete.Size = new System.Drawing.Size(72, 16);
            this.chb_AutoDelete.TabIndex = 1;
            this.chb_AutoDelete.Text = "自动删除";
            this.chb_AutoDelete.UseVisualStyleBackColor = true;
            // 
            // txtSaveDays
            // 
            this.txtSaveDays.Location = new System.Drawing.Point(314, 56);
            this.txtSaveDays.Name = "txtSaveDays";
            this.txtSaveDays.Size = new System.Drawing.Size(100, 21);
            this.txtSaveDays.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "天前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "保存路径";
            // 
            // txtSaveImagePath
            // 
            this.txtSaveImagePath.Location = new System.Drawing.Point(165, 103);
            this.txtSaveImagePath.Name = "txtSaveImagePath";
            this.txtSaveImagePath.Size = new System.Drawing.Size(249, 21);
            this.txtSaveImagePath.TabIndex = 2;
            // 
            // btnSelectImagePath
            // 
            this.btnSelectImagePath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectImagePath.Location = new System.Drawing.Point(422, 103);
            this.btnSelectImagePath.Name = "btnSelectImagePath";
            this.btnSelectImagePath.Size = new System.Drawing.Size(39, 23);
            this.btnSelectImagePath.TabIndex = 5;
            this.btnSelectImagePath.Text = "...";
            this.btnSelectImagePath.UseVisualStyleBackColor = true;
            this.btnSelectImagePath.Click += new System.EventHandler(this.btnSelectImagePath_Click);
            // 
            // chbSaveData
            // 
            this.chbSaveData.AutoSize = true;
            this.chbSaveData.Location = new System.Drawing.Point(108, 163);
            this.chbSaveData.Name = "chbSaveData";
            this.chbSaveData.Size = new System.Drawing.Size(72, 16);
            this.chbSaveData.TabIndex = 0;
            this.chbSaveData.Text = "保存数据";
            this.chbSaveData.UseVisualStyleBackColor = true;
            // 
            // txtSaveDataPath
            // 
            this.txtSaveDataPath.Location = new System.Drawing.Point(165, 208);
            this.txtSaveDataPath.Name = "txtSaveDataPath";
            this.txtSaveDataPath.Size = new System.Drawing.Size(249, 21);
            this.txtSaveDataPath.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "保存路径";
            // 
            // btnSelectDataPath
            // 
            this.btnSelectDataPath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectDataPath.Location = new System.Drawing.Point(422, 208);
            this.btnSelectDataPath.Name = "btnSelectDataPath";
            this.btnSelectDataPath.Size = new System.Drawing.Size(39, 23);
            this.btnSelectDataPath.TabIndex = 5;
            this.btnSelectDataPath.Text = "...";
            this.btnSelectDataPath.UseVisualStyleBackColor = true;
            this.btnSelectDataPath.Click += new System.EventHandler(this.btnSelectDataPath_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmSaveSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 309);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectDataPath);
            this.Controls.Add(this.btnSelectImagePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaveDataPath);
            this.Controls.Add(this.txtSaveImagePath);
            this.Controls.Add(this.txtSaveDays);
            this.Controls.Add(this.chb_AutoDelete);
            this.Controls.Add(this.chbSaveData);
            this.Controls.Add(this.chb_SaveImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaveSetting";
            this.Text = "保存设置";
            this.Load += new System.EventHandler(this.FrmSaveSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb_SaveImage;
        private System.Windows.Forms.CheckBox chb_AutoDelete;
        private System.Windows.Forms.TextBox txtSaveDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaveImagePath;
        private System.Windows.Forms.Button btnSelectImagePath;
        private System.Windows.Forms.CheckBox chbSaveData;
        private System.Windows.Forms.TextBox txtSaveDataPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectDataPath;
        private System.Windows.Forms.Button btnSave;
    }
}