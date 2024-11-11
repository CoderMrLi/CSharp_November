
namespace VisionproDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbl_ClientStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.plcStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.cogRecordDisplay2 = new Cognex.VisionPro.CogRecordDisplay();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Yield = new System.Windows.Forms.Label();
            this.lbl_OKNum = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bgw_Vision = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bgwDeleteImage = new System.ComponentModel.BackgroundWorker();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.相机1 = new System.Windows.Forms.ToolStripMenuItem();
            this.相机2toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmEditTB = new System.Windows.Forms.ToolStripMenuItem();
            this.复检toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmSetParam = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton5 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmCommunication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton6 = new System.Windows.Forms.ToolStripSplitButton();
            this.标定toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑标定作业ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslbl_ClientStatus,
            this.toolStripStatusLabel2,
            this.plcStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "客户端状态";
            // 
            // tslbl_ClientStatus
            // 
            this.tslbl_ClientStatus.Name = "tslbl_ClientStatus";
            this.tslbl_ClientStatus.Size = new System.Drawing.Size(44, 17);
            this.tslbl_ClientStatus.Text = "未连接";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel2.Text = "PLC状态";
            // 
            // plcStatusLbl
            // 
            this.plcStatusLbl.Name = "plcStatusLbl";
            this.plcStatusLbl.Size = new System.Drawing.Size(44, 17);
            this.plcStatusLbl.Text = "未连接";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelLeft, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1008, 682);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLeft.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanelLeft.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 2;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.6213F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.3787F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(702, 676);
            this.tableLayoutPanelLeft.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.data,
            this.result});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 548);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(696, 125);
            this.dataGridView1.TabIndex = 1;
            // 
            // date
            // 
            this.date.DataPropertyName = "DT";
            this.date.HeaderText = "时间";
            this.date.Name = "date";
            // 
            // data
            // 
            this.data.DataPropertyName = "Data";
            this.data.HeaderText = "数据";
            this.data.Name = "data";
            // 
            // result
            // 
            this.result.DataPropertyName = "Result";
            this.result.HeaderText = "结果";
            this.result.Name = "result";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cogRecordDisplay1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cogRecordDisplay2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(696, 539);
            this.tableLayoutPanel2.TabIndex = 2;
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
            this.cogRecordDisplay1.Size = new System.Drawing.Size(342, 533);
            this.cogRecordDisplay1.TabIndex = 0;
            // 
            // cogRecordDisplay2
            // 
            this.cogRecordDisplay2.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay2.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay2.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay2.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay2.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay2.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay2.Location = new System.Drawing.Point(351, 3);
            this.cogRecordDisplay2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay2.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay2.Name = "cogRecordDisplay2";
            this.cogRecordDisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay2.OcxState")));
            this.cogRecordDisplay2.Size = new System.Drawing.Size(342, 533);
            this.cogRecordDisplay2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(711, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 676);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_Yield);
            this.groupBox1.Controls.Add(this.lbl_OKNum);
            this.groupBox1.Controls.Add(this.lbl_result);
            this.groupBox1.Controls.Add(this.lbl_Total);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检测结果";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(75, 127);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "良率：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "良品：";
            // 
            // lbl_Yield
            // 
            this.lbl_Yield.BackColor = System.Drawing.Color.White;
            this.lbl_Yield.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Yield.Location = new System.Drawing.Point(75, 83);
            this.lbl_Yield.Name = "lbl_Yield";
            this.lbl_Yield.Size = new System.Drawing.Size(75, 17);
            this.lbl_Yield.TabIndex = 0;
            this.lbl_Yield.Text = "0";
            // 
            // lbl_OKNum
            // 
            this.lbl_OKNum.BackColor = System.Drawing.Color.White;
            this.lbl_OKNum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_OKNum.Location = new System.Drawing.Point(75, 53);
            this.lbl_OKNum.Name = "lbl_OKNum";
            this.lbl_OKNum.Size = new System.Drawing.Size(75, 17);
            this.lbl_OKNum.TabIndex = 0;
            this.lbl_OKNum.Text = "0";
            // 
            // lbl_result
            // 
            this.lbl_result.BackColor = System.Drawing.Color.Red;
            this.lbl_result.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_result.Location = new System.Drawing.Point(188, 26);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(80, 80);
            this.lbl_result.TabIndex = 0;
            this.lbl_result.Text = "Fail";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Total
            // 
            this.lbl_Total.BackColor = System.Drawing.Color.White;
            this.lbl_Total.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Total.Location = new System.Drawing.Point(75, 26);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(75, 17);
            this.lbl_Total.TabIndex = 0;
            this.lbl_Total.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "总计：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 390);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运行信息";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(282, 370);
            this.listBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bgwDeleteImage
            // 
            this.bgwDeleteImage.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDeleteImage_DoWork);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExit});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(48, 22);
            this.toolStripSplitButton1.Text = "系统";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(100, 22);
            this.tsmExit.Text = "退出";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.相机1,
            this.相机2toolStripMenuItem1});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton2.Text = "相机设置";
            // 
            // 相机1
            // 
            this.相机1.Name = "相机1";
            this.相机1.Size = new System.Drawing.Size(107, 22);
            this.相机1.Text = "相机1";
            this.相机1.Click += new System.EventHandler(this.相机1_Click);
            // 
            // 相机2toolStripMenuItem1
            // 
            this.相机2toolStripMenuItem1.Name = "相机2toolStripMenuItem1";
            this.相机2toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.相机2toolStripMenuItem1.Text = "相机2";
            this.相机2toolStripMenuItem1.Click += new System.EventHandler(this.相机2toolStripMenuItem1_Click);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditTB,
            this.复检toolStripMenuItem1});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton3.Text = "编辑作业";
            // 
            // tsmEditTB
            // 
            this.tsmEditTB.Name = "tsmEditTB";
            this.tsmEditTB.Size = new System.Drawing.Size(124, 22);
            this.tsmEditTB.Text = "作业1";
            this.tsmEditTB.Click += new System.EventHandler(this.tsmEditTB_Click);
            // 
            // 复检toolStripMenuItem1
            // 
            this.复检toolStripMenuItem1.Name = "复检toolStripMenuItem1";
            this.复检toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.复检toolStripMenuItem1.Text = "复检作业";
            this.复检toolStripMenuItem1.Click += new System.EventHandler(this.复检toolStripMenuItem1_Click);
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSetParam});
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton4.Text = "参数设置";
            // 
            // tsmSetParam
            // 
            this.tsmSetParam.Name = "tsmSetParam";
            this.tsmSetParam.Size = new System.Drawing.Size(100, 22);
            this.tsmSetParam.Text = "参数";
            this.tsmSetParam.Click += new System.EventHandler(this.tsmSetParam_Click);
            // 
            // toolStripSplitButton5
            // 
            this.toolStripSplitButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCommunication,
            this.tsmSaveImage});
            this.toolStripSplitButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton5.Image")));
            this.toolStripSplitButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton5.Name = "toolStripSplitButton5";
            this.toolStripSplitButton5.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton5.Text = "其他设置";
            // 
            // tsmCommunication
            // 
            this.tsmCommunication.Name = "tsmCommunication";
            this.tsmCommunication.Size = new System.Drawing.Size(124, 22);
            this.tsmCommunication.Text = "通信设置";
            this.tsmCommunication.Click += new System.EventHandler(this.tsmCommunication_Click);
            // 
            // tsmSaveImage
            // 
            this.tsmSaveImage.Name = "tsmSaveImage";
            this.tsmSaveImage.Size = new System.Drawing.Size(124, 22);
            this.tsmSaveImage.Text = "保存图片";
            this.tsmSaveImage.Click += new System.EventHandler(this.tsmSaveImage_Click);
            // 
            // toolStripSplitButton6
            // 
            this.toolStripSplitButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.标定toolStripMenuItem1,
            this.编辑标定作业ToolStripMenuItem});
            this.toolStripSplitButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton6.Image")));
            this.toolStripSplitButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton6.Name = "toolStripSplitButton6";
            this.toolStripSplitButton6.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton6.Text = "标定作业";
            // 
            // 标定toolStripMenuItem1
            // 
            this.标定toolStripMenuItem1.Name = "标定toolStripMenuItem1";
            this.标定toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.标定toolStripMenuItem1.Text = "下相机标定";
            this.标定toolStripMenuItem1.Click += new System.EventHandler(this.标定toolStripMenuItem1_Click);
            // 
            // 编辑标定作业ToolStripMenuItem
            // 
            this.编辑标定作业ToolStripMenuItem.Name = "编辑标定作业ToolStripMenuItem";
            this.编辑标定作业ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.编辑标定作业ToolStripMenuItem.Text = "编辑标定作业";
            this.编辑标定作业ToolStripMenuItem.Click += new System.EventHandler(this.编辑标定作业ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3,
            this.toolStripSplitButton4,
            this.toolStripSplitButton5,
            this.toolStripSplitButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMain";
            this.Text = "Visionpro检测窗体";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Yield;
        private System.Windows.Forms.Label lbl_OKNum;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker bgw_Vision;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslbl_ClientStatus;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker bgwDeleteImage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel plcStatusLbl;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem 相机1;
        private System.Windows.Forms.ToolStripMenuItem 相机2toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem tsmEditTB;
        private System.Windows.Forms.ToolStripMenuItem 复检toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripMenuItem tsmSetParam;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton5;
        private System.Windows.Forms.ToolStripMenuItem tsmCommunication;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveImage;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton6;
        private System.Windows.Forms.ToolStripMenuItem 标定toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 编辑标定作业ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

