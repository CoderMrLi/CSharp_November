namespace TCP通信总和.Forms {
	partial class Service {
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
			this.label1 = new System.Windows.Forms.Label();
			this.IpadsT = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.RuningMessages = new System.Windows.Forms.ListBox();
			this.SecdText = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.PortT = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(51, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP:";
			// 
			// IpadsT
			// 
			this.IpadsT.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.IpadsT.Location = new System.Drawing.Point(115, 105);
			this.IpadsT.Name = "IpadsT";
			this.IpadsT.Size = new System.Drawing.Size(213, 35);
			this.IpadsT.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(29, 260);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 51);
			this.button1.TabIndex = 3;
			this.button1.Text = "开始监听";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RuningMessages);
			this.groupBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.Location = new System.Drawing.Point(376, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(412, 178);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "运行信息：";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.SecdText);
			this.groupBox2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox2.Location = new System.Drawing.Point(379, 196);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(409, 242);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "发送数据：";
			// 
			// RuningMessages
			// 
			this.RuningMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RuningMessages.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.RuningMessages.FormattingEnabled = true;
			this.RuningMessages.ItemHeight = 20;
			this.RuningMessages.Location = new System.Drawing.Point(3, 31);
			this.RuningMessages.Name = "RuningMessages";
			this.RuningMessages.Size = new System.Drawing.Size(406, 144);
			this.RuningMessages.TabIndex = 0;
			// 
			// SecdText
			// 
			this.SecdText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SecdText.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.SecdText.Location = new System.Drawing.Point(3, 31);
			this.SecdText.Multiline = true;
			this.SecdText.Name = "SecdText";
			this.SecdText.Size = new System.Drawing.Size(403, 208);
			this.SecdText.TabIndex = 5;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.Location = new System.Drawing.Point(216, 260);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(133, 51);
			this.button2.TabIndex = 4;
			this.button2.Text = "发送数据";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// PortT
			// 
			this.PortT.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PortT.Location = new System.Drawing.Point(115, 152);
			this.PortT.Name = "PortT";
			this.PortT.Size = new System.Drawing.Size(213, 35);
			this.PortT.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(25, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Port:";
			// 
			// Service
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.PortT);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.IpadsT);
			this.Controls.Add(this.label1);
			this.Name = "Service";
			this.Text = "Service";
			this.Load += new System.EventHandler(this.Service_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox IpadsT;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox RuningMessages;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox SecdText;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox PortT;
		private System.Windows.Forms.Label label2;
	}
}