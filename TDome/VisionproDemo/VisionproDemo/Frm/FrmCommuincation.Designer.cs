
namespace VisionproDemo
{
    partial class FrmCommuincation
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveCom = new System.Windows.Forms.Button();
            this.txtStopBits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataBits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoundrate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chb_EnableCom = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveTcp = new System.Windows.Forms.Button();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chbTcp = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(394, 241);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(386, 215);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "串口";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveCom);
            this.groupBox1.Controls.Add(this.txtStopBits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtParity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDataBits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoundrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtComName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chb_EnableCom);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSaveCom
            // 
            this.btnSaveCom.Location = new System.Drawing.Point(251, 124);
            this.btnSaveCom.Name = "btnSaveCom";
            this.btnSaveCom.Size = new System.Drawing.Size(75, 49);
            this.btnSaveCom.TabIndex = 3;
            this.btnSaveCom.Text = "保存";
            this.btnSaveCom.UseVisualStyleBackColor = true;
            this.btnSaveCom.Click += new System.EventHandler(this.btnSaveCom_Click);
            // 
            // txtStopBits
            // 
            this.txtStopBits.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStopBits.Location = new System.Drawing.Point(131, 153);
            this.txtStopBits.Name = "txtStopBits";
            this.txtStopBits.Size = new System.Drawing.Size(94, 23);
            this.txtStopBits.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(84, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "停止位：";
            // 
            // txtParity
            // 
            this.txtParity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtParity.Location = new System.Drawing.Point(131, 124);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(94, 23);
            this.txtParity.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(84, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "校验位：";
            // 
            // txtDataBits
            // 
            this.txtDataBits.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDataBits.Location = new System.Drawing.Point(131, 95);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(94, 23);
            this.txtDataBits.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(84, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "数据位：";
            // 
            // txtBoundrate
            // 
            this.txtBoundrate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoundrate.Location = new System.Drawing.Point(131, 66);
            this.txtBoundrate.Name = "txtBoundrate";
            this.txtBoundrate.Size = new System.Drawing.Size(94, 23);
            this.txtBoundrate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(84, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            // 
            // txtComName
            // 
            this.txtComName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtComName.Location = new System.Drawing.Point(131, 37);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(94, 23);
            this.txtComName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(84, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口号：";
            // 
            // chb_EnableCom
            // 
            this.chb_EnableCom.AutoSize = true;
            this.chb_EnableCom.Location = new System.Drawing.Point(18, 20);
            this.chb_EnableCom.Name = "chb_EnableCom";
            this.chb_EnableCom.Size = new System.Drawing.Size(48, 16);
            this.chb_EnableCom.TabIndex = 0;
            this.chb_EnableCom.Text = "启用";
            this.chb_EnableCom.UseVisualStyleBackColor = true;
            this.chb_EnableCom.CheckedChanged += new System.EventHandler(this.chb_EnableCom_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TCP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveTcp);
            this.groupBox2.Controls.Add(this.txt_Port);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtIP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.chbTcp);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 369);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnSaveTcp
            // 
            this.btnSaveTcp.Location = new System.Drawing.Point(259, 66);
            this.btnSaveTcp.Name = "btnSaveTcp";
            this.btnSaveTcp.Size = new System.Drawing.Size(75, 49);
            this.btnSaveTcp.TabIndex = 3;
            this.btnSaveTcp.Text = "保存";
            this.btnSaveTcp.UseVisualStyleBackColor = true;
            this.btnSaveTcp.Click += new System.EventHandler(this.btnSaveTcp_Click);
            // 
            // txt_Port
            // 
            this.txt_Port.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Port.Location = new System.Drawing.Point(126, 92);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(94, 23);
            this.txt_Port.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(79, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Port：";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP.Location = new System.Drawing.Point(126, 63);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(94, 23);
            this.txtIP.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(79, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "IP：";
            // 
            // chbTcp
            // 
            this.chbTcp.AutoSize = true;
            this.chbTcp.Location = new System.Drawing.Point(6, 20);
            this.chbTcp.Name = "chbTcp";
            this.chbTcp.Size = new System.Drawing.Size(48, 16);
            this.chbTcp.TabIndex = 0;
            this.chbTcp.Text = "启用";
            this.chbTcp.UseVisualStyleBackColor = true;
            this.chbTcp.CheckedChanged += new System.EventHandler(this.chbTcp_CheckedChanged);
            // 
            // FrmCommuincation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 241);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FrmCommuincation";
            this.Text = "通信设置";
            this.Load += new System.EventHandler(this.FrmCommuincation_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chb_EnableCom;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtStopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoundrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveCom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveTcp;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chbTcp;
    }
}