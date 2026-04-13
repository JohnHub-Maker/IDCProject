namespace IDCProject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.wave1 = new HZH_Controls.Controls.UCProcessWave();
            this.lbl_Hum1 = new Sunny.UI.UIDigitalLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Tem1 = new Sunny.UI.UIDigitalLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meter1 = new Sunny.UI.UIMeter();
            this.led_Time = new HZH_Controls.Controls.UCLEDTime();
            this.label4 = new System.Windows.Forms.Label();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.lbl_CurrentUser = new System.Windows.Forms.Label();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.wave2 = new HZH_Controls.Controls.UCProcessWave();
            this.lbl_Hum2 = new Sunny.UI.UIDigitalLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Tem2 = new Sunny.UI.UIDigitalLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.meter2 = new Sunny.UI.UIMeter();
            this.btn_Exit = new Sunny.UI.UISymbolButton();
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.dgv_DataList = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.led_PreData = new Sunny.UI.UILight();
            this.lbl_PreStatus = new System.Windows.Forms.Label();
            this.led_THData = new Sunny.UI.UILight();
            this.lbl_THStatus = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.led_Connect = new Sunny.UI.UILight();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_ConnectStatus = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.wPump4 = new ControlsLib.WPump();
            this.wPump3 = new ControlsLib.WPump();
            this.wPump2 = new ControlsLib.WPump();
            this.wPump1 = new ControlsLib.WPump();
            this.btn_WPump2 = new Sunny.UI.UISwitch();
            this.btn_WPump4 = new Sunny.UI.UISwitch();
            this.btn_WPump3 = new Sunny.UI.UISwitch();
            this.btn_WPump1 = new Sunny.UI.UISwitch();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dp2 = new HZH_Controls.Controls.UCMeter();
            this.dp1 = new HZH_Controls.Controls.UCMeter();
            this.btn_UserLogin = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_TurnOff = new System.Windows.Forms.Button();
            this.btn_Config = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CollectionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressureIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressureOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressureStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataList)).BeginInit();
            this.uiPanel5.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDC Data Acquisition Platform";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(323, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "IDC数据采集平台";
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Controls.Add(this.wave1);
            this.uiPanel1.Controls.Add(this.lbl_Hum1);
            this.uiPanel1.Controls.Add(this.label7);
            this.uiPanel1.Controls.Add(this.lbl_Tem1);
            this.uiPanel1.Controls.Add(this.label6);
            this.uiPanel1.Controls.Add(this.label2);
            this.uiPanel1.Controls.Add(this.meter1);
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(27)))), ((int)(((byte)(50)))));
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(22, 161);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 30;
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(302, 244);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wave1
            // 
            this.wave1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.wave1.BubbleIntervalTime = 500;
            this.wave1.BubbleSpeed = 0;
            this.wave1.ConerRadius = 0;
            this.wave1.FillColor = System.Drawing.Color.Empty;
            this.wave1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wave1.ForeColor = System.Drawing.Color.Black;
            this.wave1.IsRadius = false;
            this.wave1.IsRectangle = true;
            this.wave1.IsShowRect = true;
            this.wave1.Location = new System.Drawing.Point(203, 54);
            this.wave1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wave1.MaxValue = 100;
            this.wave1.Name = "wave1";
            this.wave1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.wave1.RectWidth = 5;
            this.wave1.Size = new System.Drawing.Size(74, 134);
            this.wave1.TabIndex = 2;
            this.wave1.Value = 0;
            this.wave1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // lbl_Hum1
            // 
            this.lbl_Hum1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hum1.DecimalPlaces = 1;
            this.lbl_Hum1.DigitalSize = 15;
            this.lbl_Hum1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Hum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(223)))), ((int)(((byte)(73)))));
            this.lbl_Hum1.Location = new System.Drawing.Point(197, 196);
            this.lbl_Hum1.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbl_Hum1.Name = "lbl_Hum1";
            this.lbl_Hum1.Size = new System.Drawing.Size(61, 42);
            this.lbl_Hum1.TabIndex = 3;
            this.lbl_Hum1.Text = "uiDigitalLabel1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(223)))), ((int)(((byte)(73)))));
            this.label7.Location = new System.Drawing.Point(253, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "%";
            // 
            // lbl_Tem1
            // 
            this.lbl_Tem1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tem1.DecimalPlaces = 1;
            this.lbl_Tem1.DigitalSize = 15;
            this.lbl_Tem1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Tem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(223)))), ((int)(((byte)(73)))));
            this.lbl_Tem1.Location = new System.Drawing.Point(56, 196);
            this.lbl_Tem1.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbl_Tem1.Name = "lbl_Tem1";
            this.lbl_Tem1.Size = new System.Drawing.Size(61, 42);
            this.lbl_Tem1.TabIndex = 3;
            this.lbl_Tem1.Text = "uiDigitalLabel1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(223)))), ((int)(((byte)(73)))));
            this.label6.Location = new System.Drawing.Point(112, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "℃";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "1#机房温湿度";
            // 
            // meter1
            // 
            this.meter1.ArcColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.meter1.FillColor = System.Drawing.Color.Transparent;
            this.meter1.FillColor2 = System.Drawing.Color.Transparent;
            this.meter1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meter1.ForeColor = System.Drawing.Color.RosyBrown;
            this.meter1.InnerSize = 70;
            this.meter1.Location = new System.Drawing.Point(15, 50);
            this.meter1.MaxValue = 100F;
            this.meter1.MinimumSize = new System.Drawing.Size(1, 1);
            this.meter1.MinValue = 0F;
            this.meter1.Name = "meter1";
            this.meter1.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.meter1.OuterSize = 80;
            this.meter1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.meter1.ScaleDecimalPlaces = 0;
            this.meter1.ScaleFont = new System.Drawing.Font("宋体", 10.5F);
            this.meter1.Size = new System.Drawing.Size(176, 158);
            this.meter1.StartPos = new System.Drawing.Point(5, 5);
            this.meter1.TabIndex = 0;
            this.meter1.Text = "uiMeter1";
            this.meter1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.meter1.Unit = "";
            this.meter1.Value = 0F;
            this.meter1.ValueOffset = new System.Drawing.Point(0, 0);
            // 
            // led_Time
            // 
            this.led_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(187)))), ((int)(((byte)(86)))));
            this.led_Time.LineWidth = 3;
            this.led_Time.Location = new System.Drawing.Point(180, 84);
            this.led_Time.Name = "led_Time";
            this.led_Time.Size = new System.Drawing.Size(162, 31);
            this.led_Time.TabIndex = 0;
            this.led_Time.Value = new System.DateTime(2026, 4, 8, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(187)))), ((int)(((byte)(86)))));
            this.label4.Location = new System.Drawing.Point(53, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "当前时间：";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(987, 101);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(115, 35);
            this.uiSymbolLabel1.Symbol = 61447;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.uiSymbolLabel1.TabIndex = 4;
            this.uiSymbolLabel1.Text = "当前用户:";
            // 
            // lbl_CurrentUser
            // 
            this.lbl_CurrentUser.AutoSize = true;
            this.lbl_CurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CurrentUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CurrentUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lbl_CurrentUser.Location = new System.Drawing.Point(1108, 110);
            this.lbl_CurrentUser.Name = "lbl_CurrentUser";
            this.lbl_CurrentUser.Size = new System.Drawing.Size(58, 16);
            this.lbl_CurrentUser.TabIndex = 5;
            this.lbl_CurrentUser.Text = "未登录";
            this.lbl_CurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Controls.Add(this.wave2);
            this.uiPanel2.Controls.Add(this.lbl_Hum2);
            this.uiPanel2.Controls.Add(this.label8);
            this.uiPanel2.Controls.Add(this.lbl_Tem2);
            this.uiPanel2.Controls.Add(this.label9);
            this.uiPanel2.Controls.Add(this.label10);
            this.uiPanel2.Controls.Add(this.meter2);
            this.uiPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(27)))), ((int)(((byte)(50)))));
            this.uiPanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(22, 439);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Radius = 30;
            this.uiPanel2.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Size = new System.Drawing.Size(302, 244);
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wave2
            // 
            this.wave2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.wave2.BubbleIntervalTime = 500;
            this.wave2.BubbleSpeed = 0;
            this.wave2.ConerRadius = 0;
            this.wave2.FillColor = System.Drawing.Color.Empty;
            this.wave2.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wave2.ForeColor = System.Drawing.Color.Black;
            this.wave2.IsRadius = false;
            this.wave2.IsRectangle = true;
            this.wave2.IsShowRect = true;
            this.wave2.Location = new System.Drawing.Point(203, 54);
            this.wave2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wave2.MaxValue = 100;
            this.wave2.Name = "wave2";
            this.wave2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.wave2.RectWidth = 5;
            this.wave2.Size = new System.Drawing.Size(74, 134);
            this.wave2.TabIndex = 2;
            this.wave2.Value = 0;
            this.wave2.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // lbl_Hum2
            // 
            this.lbl_Hum2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hum2.DecimalPlaces = 1;
            this.lbl_Hum2.DigitalSize = 15;
            this.lbl_Hum2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Hum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(223)))), ((int)(((byte)(73)))));
            this.lbl_Hum2.Location = new System.Drawing.Point(197, 196);
            this.lbl_Hum2.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbl_Hum2.Name = "lbl_Hum2";
            this.lbl_Hum2.Size = new System.Drawing.Size(61, 42);
            this.lbl_Hum2.TabIndex = 3;
            this.lbl_Hum2.Text = "uiDigitalLabel1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(223)))), ((int)(((byte)(73)))));
            this.label8.Location = new System.Drawing.Point(253, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "%";
            // 
            // lbl_Tem2
            // 
            this.lbl_Tem2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tem2.DecimalPlaces = 1;
            this.lbl_Tem2.DigitalSize = 15;
            this.lbl_Tem2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Tem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(223)))), ((int)(((byte)(73)))));
            this.lbl_Tem2.Location = new System.Drawing.Point(56, 196);
            this.lbl_Tem2.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbl_Tem2.Name = "lbl_Tem2";
            this.lbl_Tem2.Size = new System.Drawing.Size(61, 42);
            this.lbl_Tem2.TabIndex = 3;
            this.lbl_Tem2.Text = "uiDigitalLabel1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(223)))), ((int)(((byte)(73)))));
            this.label9.Location = new System.Drawing.Point(112, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 27);
            this.label9.TabIndex = 4;
            this.label9.Text = "℃";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(9, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "2#机房温湿度";
            // 
            // meter2
            // 
            this.meter2.ArcColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.meter2.FillColor = System.Drawing.Color.Transparent;
            this.meter2.FillColor2 = System.Drawing.Color.Transparent;
            this.meter2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meter2.ForeColor = System.Drawing.Color.RosyBrown;
            this.meter2.InnerSize = 70;
            this.meter2.Location = new System.Drawing.Point(15, 50);
            this.meter2.MaxValue = 100F;
            this.meter2.MinimumSize = new System.Drawing.Size(1, 1);
            this.meter2.MinValue = 0F;
            this.meter2.Name = "meter2";
            this.meter2.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.meter2.OuterSize = 80;
            this.meter2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.meter2.ScaleDecimalPlaces = 0;
            this.meter2.ScaleFont = new System.Drawing.Font("宋体", 10.5F);
            this.meter2.Size = new System.Drawing.Size(176, 158);
            this.meter2.StartPos = new System.Drawing.Point(5, 5);
            this.meter2.TabIndex = 0;
            this.meter2.Text = "uiMeter1";
            this.meter2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.meter2.Unit = "";
            this.meter2.Value = 0F;
            this.meter2.ValueOffset = new System.Drawing.Point(0, 0);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FillColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_Exit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(207)))), ((int)(((byte)(242)))));
            this.btn_Exit.Location = new System.Drawing.Point(1145, 33);
            this.btn_Exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.RectColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Size = new System.Drawing.Size(76, 35);
            this.btn_Exit.Symbol = 361457;
            this.btn_Exit.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(207)))), ((int)(((byte)(242)))));
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "关闭";
            this.btn_Exit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Exit.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSmoothLabel1.Location = new System.Drawing.Point(505, 101);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.RectColor = System.Drawing.Color.CornflowerBlue;
            this.uiSmoothLabel1.RectSize = 1;
            this.uiSmoothLabel1.Size = new System.Drawing.Size(291, 44);
            this.uiSmoothLabel1.TabIndex = 7;
            this.uiSmoothLabel1.Text = "供水加压控制系统";
            this.uiSmoothLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel4
            // 
            this.uiPanel4.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel4.Controls.Add(this.dgv_DataList);
            this.uiPanel4.Controls.Add(this.label11);
            this.uiPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(27)))), ((int)(((byte)(50)))));
            this.uiPanel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel4.Location = new System.Drawing.Point(968, 161);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Radius = 30;
            this.uiPanel4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(187)))), ((int)(((byte)(218)))));
            this.uiPanel4.Size = new System.Drawing.Size(283, 313);
            this.uiPanel4.TabIndex = 2;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_DataList
            // 
            this.dgv_DataList.AllowUserToAddRows = false;
            this.dgv_DataList.AllowUserToDeleteRows = false;
            this.dgv_DataList.AllowUserToResizeColumns = false;
            this.dgv_DataList.AllowUserToResizeRows = false;
            this.dgv_DataList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(27)))), ((int)(((byte)(50)))));
            this.dgv_DataList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DataList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(187)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DataList.ColumnHeadersHeight = 20;
            this.dgv_DataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CollectionTime,
            this.PressureIn,
            this.PressureOut,
            this.PressureStatus});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DataList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DataList.EnableHeadersVisualStyles = false;
            this.dgv_DataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(187)))), ((int)(((byte)(218)))));
            this.dgv_DataList.Location = new System.Drawing.Point(0, 43);
            this.dgv_DataList.Name = "dgv_DataList";
            this.dgv_DataList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_DataList.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_DataList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DataList.RowTemplate.Height = 23;
            this.dgv_DataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DataList.Size = new System.Drawing.Size(283, 250);
            this.dgv_DataList.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(14, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 26);
            this.label11.TabIndex = 1;
            this.label11.Text = "压力采集表";
            // 
            // uiPanel5
            // 
            this.uiPanel5.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel5.Controls.Add(this.led_PreData);
            this.uiPanel5.Controls.Add(this.lbl_PreStatus);
            this.uiPanel5.Controls.Add(this.led_THData);
            this.uiPanel5.Controls.Add(this.lbl_THStatus);
            this.uiPanel5.Controls.Add(this.label17);
            this.uiPanel5.Controls.Add(this.led_Connect);
            this.uiPanel5.Controls.Add(this.label15);
            this.uiPanel5.Controls.Add(this.lbl_ConnectStatus);
            this.uiPanel5.Controls.Add(this.label12);
            this.uiPanel5.Controls.Add(this.label13);
            this.uiPanel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(27)))), ((int)(((byte)(50)))));
            this.uiPanel5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel5.Location = new System.Drawing.Point(968, 493);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.Radius = 30;
            this.uiPanel5.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel5.Size = new System.Drawing.Size(283, 190);
            this.uiPanel5.TabIndex = 2;
            this.uiPanel5.Text = null;
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // led_PreData
            // 
            this.led_PreData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.led_PreData.Location = new System.Drawing.Point(125, 127);
            this.led_PreData.MinimumSize = new System.Drawing.Size(1, 1);
            this.led_PreData.Name = "led_PreData";
            this.led_PreData.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(144)))), ((int)(((byte)(107)))));
            this.led_PreData.Radius = 35;
            this.led_PreData.Size = new System.Drawing.Size(35, 35);
            this.led_PreData.State = Sunny.UI.UILightState.Off;
            this.led_PreData.TabIndex = 3;
            this.led_PreData.Text = "uiLight1";
            // 
            // lbl_PreStatus
            // 
            this.lbl_PreStatus.AutoSize = true;
            this.lbl_PreStatus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PreStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_PreStatus.Location = new System.Drawing.Point(162, 135);
            this.lbl_PreStatus.Name = "lbl_PreStatus";
            this.lbl_PreStatus.Size = new System.Drawing.Size(74, 22);
            this.lbl_PreStatus.TabIndex = 0;
            this.lbl_PreStatus.Text = "暂无数据";
            // 
            // led_THData
            // 
            this.led_THData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.led_THData.Location = new System.Drawing.Point(125, 86);
            this.led_THData.MinimumSize = new System.Drawing.Size(1, 1);
            this.led_THData.Name = "led_THData";
            this.led_THData.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(144)))), ((int)(((byte)(107)))));
            this.led_THData.Radius = 35;
            this.led_THData.Size = new System.Drawing.Size(35, 35);
            this.led_THData.State = Sunny.UI.UILightState.Off;
            this.led_THData.TabIndex = 3;
            this.led_THData.Text = "uiLight1";
            // 
            // lbl_THStatus
            // 
            this.lbl_THStatus.AutoSize = true;
            this.lbl_THStatus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_THStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_THStatus.Location = new System.Drawing.Point(162, 94);
            this.lbl_THStatus.Name = "lbl_THStatus";
            this.lbl_THStatus.Size = new System.Drawing.Size(74, 22);
            this.lbl_THStatus.TabIndex = 0;
            this.lbl_THStatus.Text = "暂无数据";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label17.Location = new System.Drawing.Point(17, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 22);
            this.label17.TabIndex = 0;
            this.label17.Text = "进出水压力：";
            // 
            // led_Connect
            // 
            this.led_Connect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.led_Connect.Location = new System.Drawing.Point(125, 45);
            this.led_Connect.MinimumSize = new System.Drawing.Size(1, 1);
            this.led_Connect.Name = "led_Connect";
            this.led_Connect.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(144)))), ((int)(((byte)(107)))));
            this.led_Connect.Radius = 35;
            this.led_Connect.Size = new System.Drawing.Size(35, 35);
            this.led_Connect.State = Sunny.UI.UILightState.Off;
            this.led_Connect.TabIndex = 3;
            this.led_Connect.Text = "uiLight1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.Location = new System.Drawing.Point(17, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 22);
            this.label15.TabIndex = 0;
            this.label15.Text = "机房温湿度：";
            // 
            // lbl_ConnectStatus
            // 
            this.lbl_ConnectStatus.AutoSize = true;
            this.lbl_ConnectStatus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ConnectStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_ConnectStatus.Location = new System.Drawing.Point(162, 53);
            this.lbl_ConnectStatus.Name = "lbl_ConnectStatus";
            this.lbl_ConnectStatus.Size = new System.Drawing.Size(58, 22);
            this.lbl_ConnectStatus.TabIndex = 0;
            this.lbl_ConnectStatus.Text = "未连接";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(33, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "串口连接：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(14, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "系统状态监控";
            // 
            // uiPanel3
            // 
            this.uiPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(27)))), ((int)(((byte)(50)))));
            this.uiPanel3.BackgroundImage = global::IDCProject.Properties.Resources.StorageTank;
            this.uiPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiPanel3.Controls.Add(this.wPump4);
            this.uiPanel3.Controls.Add(this.wPump3);
            this.uiPanel3.Controls.Add(this.wPump2);
            this.uiPanel3.Controls.Add(this.wPump1);
            this.uiPanel3.Controls.Add(this.btn_WPump2);
            this.uiPanel3.Controls.Add(this.btn_WPump4);
            this.uiPanel3.Controls.Add(this.btn_WPump3);
            this.uiPanel3.Controls.Add(this.btn_WPump1);
            this.uiPanel3.Controls.Add(this.label20);
            this.uiPanel3.Controls.Add(this.label19);
            this.uiPanel3.Controls.Add(this.dp2);
            this.uiPanel3.Controls.Add(this.dp1);
            this.uiPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(27)))), ((int)(((byte)(50)))));
            this.uiPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(27)))), ((int)(((byte)(50)))));
            this.uiPanel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel3.Location = new System.Drawing.Point(345, 161);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Radius = 30;
            this.uiPanel3.RectColor = System.Drawing.Color.IndianRed;
            this.uiPanel3.Size = new System.Drawing.Size(604, 522);
            this.uiPanel3.TabIndex = 2;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wPump4
            // 
            this.wPump4.BackColor = System.Drawing.Color.Transparent;
            this.wPump4.IsRun = false;
            this.wPump4.Location = new System.Drawing.Point(475, 357);
            this.wPump4.Name = "wPump4";
            this.wPump4.Size = new System.Drawing.Size(83, 100);
            this.wPump4.TabIndex = 9;
            // 
            // wPump3
            // 
            this.wPump3.BackColor = System.Drawing.Color.Transparent;
            this.wPump3.IsRun = false;
            this.wPump3.Location = new System.Drawing.Point(358, 357);
            this.wPump3.Name = "wPump3";
            this.wPump3.Size = new System.Drawing.Size(83, 100);
            this.wPump3.TabIndex = 9;
            // 
            // wPump2
            // 
            this.wPump2.BackColor = System.Drawing.Color.Transparent;
            this.wPump2.IsRun = false;
            this.wPump2.Location = new System.Drawing.Point(240, 357);
            this.wPump2.Name = "wPump2";
            this.wPump2.Size = new System.Drawing.Size(83, 100);
            this.wPump2.TabIndex = 9;
            // 
            // wPump1
            // 
            this.wPump1.BackColor = System.Drawing.Color.Transparent;
            this.wPump1.IsRun = false;
            this.wPump1.Location = new System.Drawing.Point(123, 357);
            this.wPump1.Name = "wPump1";
            this.wPump1.Size = new System.Drawing.Size(83, 100);
            this.wPump1.TabIndex = 9;
            // 
            // btn_WPump2
            // 
            this.btn_WPump2.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(2)))));
            this.btn_WPump2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WPump2.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.btn_WPump2.Location = new System.Drawing.Point(240, 465);
            this.btn_WPump2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_WPump2.Name = "btn_WPump2";
            this.btn_WPump2.Size = new System.Drawing.Size(83, 29);
            this.btn_WPump2.TabIndex = 7;
            this.btn_WPump2.Tag = "swi_pump2;";
            this.btn_WPump2.Text = "uiSwitch1";
            // 
            // btn_WPump4
            // 
            this.btn_WPump4.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(2)))));
            this.btn_WPump4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WPump4.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.btn_WPump4.Location = new System.Drawing.Point(475, 465);
            this.btn_WPump4.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_WPump4.Name = "btn_WPump4";
            this.btn_WPump4.Size = new System.Drawing.Size(83, 29);
            this.btn_WPump4.TabIndex = 7;
            this.btn_WPump4.Tag = "swi_pump4;";
            this.btn_WPump4.Text = "uiSwitch1";
            // 
            // btn_WPump3
            // 
            this.btn_WPump3.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(2)))));
            this.btn_WPump3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WPump3.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.btn_WPump3.Location = new System.Drawing.Point(358, 465);
            this.btn_WPump3.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_WPump3.Name = "btn_WPump3";
            this.btn_WPump3.Size = new System.Drawing.Size(83, 29);
            this.btn_WPump3.TabIndex = 7;
            this.btn_WPump3.Tag = "swi_pump3;";
            this.btn_WPump3.Text = "uiSwitch1";
            // 
            // btn_WPump1
            // 
            this.btn_WPump1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(2)))));
            this.btn_WPump1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WPump1.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.btn_WPump1.Location = new System.Drawing.Point(123, 465);
            this.btn_WPump1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_WPump1.Name = "btn_WPump1";
            this.btn_WPump1.Size = new System.Drawing.Size(83, 29);
            this.btn_WPump1.TabIndex = 7;
            this.btn_WPump1.Tag = "swi_pump1;";
            this.btn_WPump1.Text = "uiSwitch1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(118)))));
            this.label20.Location = new System.Drawing.Point(223, 122);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 16);
            this.label20.TabIndex = 8;
            this.label20.Text = "R";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(118)))));
            this.label19.Location = new System.Drawing.Point(223, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 16);
            this.label19.TabIndex = 8;
            this.label19.Text = "L";
            // 
            // dp2
            // 
            this.dp2.BackColor = System.Drawing.Color.Transparent;
            this.dp2.BoundaryLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dp2.ExternalRoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dp2.FixedText = null;
            this.dp2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dp2.InsideRoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dp2.Location = new System.Drawing.Point(208, 112);
            this.dp2.MaxValue = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.dp2.MeterDegrees = 180;
            this.dp2.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dp2.Name = "dp2";
            this.dp2.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(223)))), ((int)(((byte)(73)))));
            this.dp2.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dp2.ScaleValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dp2.Size = new System.Drawing.Size(193, 125);
            this.dp2.SplitCount = 10;
            this.dp2.TabIndex = 2;
            this.dp2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(97)))));
            this.dp2.TextFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dp2.TextLocation = HZH_Controls.Controls.MeterTextLocation.Top;
            this.dp2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dp1
            // 
            this.dp1.BackColor = System.Drawing.Color.Transparent;
            this.dp1.BoundaryLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dp1.ExternalRoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dp1.FixedText = null;
            this.dp1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dp1.InsideRoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dp1.Location = new System.Drawing.Point(207, 3);
            this.dp1.MaxValue = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.dp1.MeterDegrees = 180;
            this.dp1.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dp1.Name = "dp1";
            this.dp1.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(223)))), ((int)(((byte)(73)))));
            this.dp1.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dp1.ScaleValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dp1.Size = new System.Drawing.Size(193, 125);
            this.dp1.SplitCount = 10;
            this.dp1.TabIndex = 2;
            this.dp1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(97)))));
            this.dp1.TextFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dp1.TextLocation = HZH_Controls.Controls.MeterTextLocation.Top;
            this.dp1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // btn_UserLogin
            // 
            this.btn_UserLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_UserLogin.BackgroundImage = global::IDCProject.Properties.Resources.Button_None;
            this.btn_UserLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_UserLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UserLogin.FlatAppearance.BorderSize = 0;
            this.btn_UserLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_UserLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_UserLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_UserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserLogin.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_UserLogin.ForeColor = System.Drawing.Color.White;
            this.btn_UserLogin.Location = new System.Drawing.Point(955, 21);
            this.btn_UserLogin.Name = "btn_UserLogin";
            this.btn_UserLogin.Size = new System.Drawing.Size(147, 58);
            this.btn_UserLogin.TabIndex = 1;
            this.btn_UserLogin.Text = "用户登录";
            this.btn_UserLogin.UseVisualStyleBackColor = false;
            this.btn_UserLogin.Click += new System.EventHandler(this.btn_UserLogin_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.Transparent;
            this.btn_Connect.BackgroundImage = global::IDCProject.Properties.Resources.Button_None;
            this.btn_Connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Connect.FlatAppearance.BorderSize = 0;
            this.btn_Connect.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connect.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Connect.ForeColor = System.Drawing.Color.White;
            this.btn_Connect.Location = new System.Drawing.Point(649, 21);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(147, 58);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Tag = "0";
            this.btn_Connect.Text = "连接设备";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_TurnOff
            // 
            this.btn_TurnOff.BackColor = System.Drawing.Color.Transparent;
            this.btn_TurnOff.BackgroundImage = global::IDCProject.Properties.Resources.Button_None;
            this.btn_TurnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TurnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TurnOff.FlatAppearance.BorderSize = 0;
            this.btn_TurnOff.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_TurnOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_TurnOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_TurnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TurnOff.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_TurnOff.ForeColor = System.Drawing.Color.White;
            this.btn_TurnOff.Location = new System.Drawing.Point(802, 21);
            this.btn_TurnOff.Name = "btn_TurnOff";
            this.btn_TurnOff.Size = new System.Drawing.Size(147, 58);
            this.btn_TurnOff.TabIndex = 1;
            this.btn_TurnOff.Tag = "0";
            this.btn_TurnOff.Text = "实时监控";
            this.btn_TurnOff.UseVisualStyleBackColor = false;
            this.btn_TurnOff.Click += new System.EventHandler(this.btn_TurnOff_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.BackColor = System.Drawing.Color.Transparent;
            this.btn_Config.BackgroundImage = global::IDCProject.Properties.Resources.Button_None;
            this.btn_Config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Config.FlatAppearance.BorderSize = 0;
            this.btn_Config.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Config.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Config.ForeColor = System.Drawing.Color.White;
            this.btn_Config.Location = new System.Drawing.Point(496, 21);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(147, 58);
            this.btn_Config.TabIndex = 1;
            this.btn_Config.Text = "通信配置";
            this.btn_Config.UseVisualStyleBackColor = false;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            this.btn_Config.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CollectionTime
            // 
            this.CollectionTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CollectionTime.DataPropertyName = "CollectionTime";
            this.CollectionTime.FillWeight = 80F;
            this.CollectionTime.HeaderText = "采集时间";
            this.CollectionTime.Name = "CollectionTime";
            this.CollectionTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PressureIn
            // 
            this.PressureIn.DataPropertyName = "PressureIn";
            this.PressureIn.FillWeight = 80F;
            this.PressureIn.HeaderText = "进水压";
            this.PressureIn.Name = "PressureIn";
            this.PressureIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PressureIn.Width = 80;
            // 
            // PressureOut
            // 
            this.PressureOut.DataPropertyName = "PressureOut";
            this.PressureOut.FillWeight = 80F;
            this.PressureOut.HeaderText = "出水压";
            this.PressureOut.Name = "PressureOut";
            this.PressureOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PressureOut.Width = 80;
            // 
            // PressureStatus
            // 
            this.PressureStatus.DataPropertyName = "PressureStatus";
            this.PressureStatus.FillWeight = 40F;
            this.PressureStatus.HeaderText = "状态";
            this.PressureStatus.Name = "PressureStatus";
            this.PressureStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PressureStatus.Width = 40;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.uiSmoothLabel1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_CurrentUser);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.led_Time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiPanel3);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel4);
            this.Controls.Add(this.uiPanel5);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.btn_UserLogin);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_TurnOff);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDC数据采集平台";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2.PerformLayout();
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataList)).EndInit();
            this.uiPanel5.ResumeLayout(false);
            this.uiPanel5.PerformLayout();
            this.uiPanel3.ResumeLayout(false);
            this.uiPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Config;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_TurnOff;
        private System.Windows.Forms.Button btn_UserLogin;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIMeter meter1;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCProcessWave wave1;
        private HZH_Controls.Controls.UCLEDTime led_Time;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.Label lbl_CurrentUser;
        private Sunny.UI.UIDigitalLabel lbl_Tem1;
        private Sunny.UI.UIDigitalLabel lbl_Hum1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UIPanel uiPanel2;
        private HZH_Controls.Controls.UCProcessWave wave2;
        private Sunny.UI.UIDigitalLabel lbl_Hum2;
        private System.Windows.Forms.Label label8;
        private Sunny.UI.UIDigitalLabel lbl_Tem2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Sunny.UI.UIMeter meter2;
        private Sunny.UI.UISymbolButton btn_Exit;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private HZH_Controls.Controls.UCMeter dp1;
        private HZH_Controls.Controls.UCMeter dp2;
        private Sunny.UI.UISwitch btn_WPump4;
        private Sunny.UI.UISwitch btn_WPump2;
        private Sunny.UI.UISwitch btn_WPump3;
        private Sunny.UI.UISwitch btn_WPump1;
        private Sunny.UI.UIPanel uiPanel4;
        private System.Windows.Forms.DataGridView dgv_DataList;
        private System.Windows.Forms.Label label11;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UILight led_PreData;
        private System.Windows.Forms.Label lbl_PreStatus;
        private Sunny.UI.UILight led_THData;
        private System.Windows.Forms.Label lbl_THStatus;
        private System.Windows.Forms.Label label17;
        private Sunny.UI.UILight led_Connect;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_ConnectStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private ControlsLib.WPump wPump4;
        private ControlsLib.WPump wPump3;
        private ControlsLib.WPump wPump2;
        private ControlsLib.WPump wPump1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollectionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressureIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressureOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressureStatus;
    }
}

