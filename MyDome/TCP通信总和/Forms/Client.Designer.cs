namespace TCP通信总和.Forms {
	partial class Client {
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
			this.ipT = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.RuningMessages = new System.Windows.Forms.ListBox();
			this.SendT = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.portT = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(63, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP:";
			// 
			// ipT
			// 
			this.ipT.Font = new System.Drawing.Font("宋体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ipT.Location = new System.Drawing.Point(124, 89);
			this.ipT.Name = "ipT";
			this.ipT.Size = new System.Drawing.Size(198, 35);
			this.ipT.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(45, 241);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 47);
			this.button1.TabIndex = 3;
			this.button1.Text = "连接";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RuningMessages);
			this.groupBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.Location = new System.Drawing.Point(399, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(389, 188);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.SendT);
			this.groupBox2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox2.Location = new System.Drawing.Point(399, 210);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(389, 228);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// RuningMessages
			// 
			this.RuningMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RuningMessages.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.RuningMessages.FormattingEnabled = true;
			this.RuningMessages.ItemHeight = 20;
			this.RuningMessages.Location = new System.Drawing.Point(3, 31);
			this.RuningMessages.Name = "RuningMessages";
			this.RuningMessages.Size = new System.Drawing.Size(383, 154);
			this.RuningMessages.TabIndex = 0;
			// 
			// SendT
			// 
			this.SendT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SendT.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.SendT.Location = new System.Drawing.Point(3, 31);
			this.SendT.Multiline = true;
			this.SendT.Name = "SendT";
			this.SendT.Size = new System.Drawing.Size(383, 194);
			this.SendT.TabIndex = 5;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("宋体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.Location = new System.Drawing.Point(214, 241);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(123, 47);
			this.button2.TabIndex = 4;
			this.button2.Text = "发送数据";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// portT
			// 
			this.portT.Font = new System.Drawing.Font("宋体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.portT.Location = new System.Drawing.Point(124, 137);
			this.portT.Name = "portT";
			this.portT.Size = new System.Drawing.Size(198, 35);
			this.portT.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(37, 142);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(75, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Port:";
			// 
			// Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.portT);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ipT);
			this.Controls.Add(this.label1);
			this.Name = "Client";
			this.Text = "Client";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
			this.Load += new System.EventHandler(this.Client_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ipT;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox RuningMessages;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox SendT;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox portT;
		private System.Windows.Forms.Label label2;
	}
}