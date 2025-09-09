namespace dragon_app
{
    partial class Dragon_app
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComBox5 = new System.Windows.Forms.ComboBox();
            this.ComBox4 = new System.Windows.Forms.ComboBox();
            this.ComBox3 = new System.Windows.Forms.ComboBox();
            this.ComBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.ComBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_clear_rv = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_clear_tx = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_tx_count = new System.Windows.Forms.TextBox();
            this.textBox_rx_count = new System.Windows.Forms.TextBox();
            this.textBox_uart_state = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Button_skip3 = new System.Windows.Forms.Button();
            this.Button_clear = new System.Windows.Forms.Button();
            this.Botton_skip2 = new System.Windows.Forms.Button();
            this.Button_skip1 = new System.Windows.Forms.Button();
            this.textBox_receive = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            this.Timer_show = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.ComBox5);
            this.panel1.Controls.Add(this.ComBox4);
            this.panel1.Controls.Add(this.ComBox3);
            this.panel1.Controls.Add(this.ComBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.ComBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 477);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ComBox5
            // 
            this.ComBox5.Font = new System.Drawing.Font("宋体", 12F);
            this.ComBox5.FormattingEnabled = true;
            this.ComBox5.Location = new System.Drawing.Point(159, 288);
            this.ComBox5.Name = "ComBox5";
            this.ComBox5.Size = new System.Drawing.Size(193, 41);
            this.ComBox5.TabIndex = 11;
            this.ComBox5.Text = "1";
            this.ComBox5.SelectedIndexChanged += new System.EventHandler(this.ComBox5_SelectedIndexChanged);
            // 
            // ComBox4
            // 
            this.ComBox4.Font = new System.Drawing.Font("宋体", 12F);
            this.ComBox4.FormattingEnabled = true;
            this.ComBox4.Location = new System.Drawing.Point(159, 226);
            this.ComBox4.Name = "ComBox4";
            this.ComBox4.Size = new System.Drawing.Size(193, 41);
            this.ComBox4.TabIndex = 10;
            this.ComBox4.Text = "None";
            this.ComBox4.SelectedIndexChanged += new System.EventHandler(this.ComBox4_SelectedIndexChanged);
            // 
            // ComBox3
            // 
            this.ComBox3.Font = new System.Drawing.Font("宋体", 12F);
            this.ComBox3.FormattingEnabled = true;
            this.ComBox3.Location = new System.Drawing.Point(159, 160);
            this.ComBox3.Name = "ComBox3";
            this.ComBox3.Size = new System.Drawing.Size(193, 41);
            this.ComBox3.TabIndex = 9;
            this.ComBox3.Text = "8";
            this.ComBox3.SelectedIndexChanged += new System.EventHandler(this.ComBox3_SelectedIndexChanged);
            // 
            // ComBox2
            // 
            this.ComBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.ComBox2.FormattingEnabled = true;
            this.ComBox2.Location = new System.Drawing.Point(159, 97);
            this.ComBox2.Name = "ComBox2";
            this.ComBox2.Size = new System.Drawing.Size(193, 41);
            this.ComBox2.TabIndex = 8;
            this.ComBox2.Text = "115200";
            this.ComBox2.SelectedIndexChanged += new System.EventHandler(this.ComBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("宋体", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(17, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 80);
            this.button1.TabIndex = 6;
            this.button1.Text = "打开串口";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.Location = new System.Drawing.Point(3, 288);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(137, 40);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "停止位";
            this.Label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "校验位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据位";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.Location = new System.Drawing.Point(3, 98);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(137, 40);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "波特率";
            // 
            // ComBox1
            // 
            this.ComBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ComBox1.FormattingEnabled = true;
            this.ComBox1.Location = new System.Drawing.Point(159, 32);
            this.ComBox1.Name = "ComBox1";
            this.ComBox1.Size = new System.Drawing.Size(193, 41);
            this.ComBox1.TabIndex = 1;
            this.ComBox1.SelectedIndexChanged += new System.EventHandler(this.ComBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.button_clear_rv);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 272);
            this.panel2.TabIndex = 0;
            // 
            // button_clear_rv
            // 
            this.button_clear_rv.Font = new System.Drawing.Font("宋体", 12F);
            this.button_clear_rv.Location = new System.Drawing.Point(28, 155);
            this.button_clear_rv.Name = "button_clear_rv";
            this.button_clear_rv.Size = new System.Drawing.Size(324, 99);
            this.button_clear_rv.TabIndex = 9;
            this.button_clear_rv.Text = "清空接收";
            this.button_clear_rv.UseVisualStyleBackColor = true;
            this.button_clear_rv.Click += new System.EventHandler(this.button_clear_rv_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox1.Location = new System.Drawing.Point(17, 94);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(303, 37);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "显示接收数据时间";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("宋体", 14F);
            this.radioButton2.Location = new System.Drawing.Point(247, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 42);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "HEX";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("宋体", 14F);
            this.radioButton1.Location = new System.Drawing.Point(10, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(143, 42);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ASCII";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.button_clear_tx);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.radioButton4);
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Location = new System.Drawing.Point(12, 773);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 243);
            this.panel3.TabIndex = 0;
            // 
            // button_clear_tx
            // 
            this.button_clear_tx.Location = new System.Drawing.Point(209, 79);
            this.button_clear_tx.Name = "button_clear_tx";
            this.button_clear_tx.Size = new System.Drawing.Size(162, 65);
            this.button_clear_tx.TabIndex = 0;
            this.button_clear_tx.Text = "清空发送";
            this.button_clear_tx.UseVisualStyleBackColor = true;
            this.button_clear_tx.Click += new System.EventHandler(this.button_clear_tx_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(232, 170);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown1.TabIndex = 10;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox3.Location = new System.Drawing.Point(17, 170);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(175, 37);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "自动发送";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.checkBox2.Location = new System.Drawing.Point(17, 91);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(175, 37);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "发送新行";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Font = new System.Drawing.Font("宋体", 14F);
            this.radioButton4.Location = new System.Drawing.Point(242, 24);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(105, 42);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "HEX";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("宋体", 14F);
            this.radioButton3.Location = new System.Drawing.Point(10, 24);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(143, 42);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ASCII";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.textBox_tx_count);
            this.panel4.Controls.Add(this.textBox_rx_count);
            this.panel4.Controls.Add(this.textBox_uart_state);
            this.panel4.Location = new System.Drawing.Point(12, 1022);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1660, 109);
            this.panel4.TabIndex = 4;
            // 
            // textBox_tx_count
            // 
            this.textBox_tx_count.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_tx_count.Location = new System.Drawing.Point(533, 39);
            this.textBox_tx_count.Name = "textBox_tx_count";
            this.textBox_tx_count.Size = new System.Drawing.Size(406, 44);
            this.textBox_tx_count.TabIndex = 13;
            this.textBox_tx_count.Text = "Tx:0Bytes";
            this.textBox_tx_count.TextChanged += new System.EventHandler(this.textBox_tx_count_TextChanged);
            // 
            // textBox_rx_count
            // 
            this.textBox_rx_count.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_rx_count.Location = new System.Drawing.Point(1052, 39);
            this.textBox_rx_count.Name = "textBox_rx_count";
            this.textBox_rx_count.Size = new System.Drawing.Size(378, 44);
            this.textBox_rx_count.TabIndex = 12;
            this.textBox_rx_count.Text = "Rx:0Bytes";
            this.textBox_rx_count.TextChanged += new System.EventHandler(this.textBox_rx_count_TextChanged);
            // 
            // textBox_uart_state
            // 
            this.textBox_uart_state.ForeColor = System.Drawing.Color.Red;
            this.textBox_uart_state.Location = new System.Drawing.Point(40, 46);
            this.textBox_uart_state.Name = "textBox_uart_state";
            this.textBox_uart_state.Size = new System.Drawing.Size(307, 35);
            this.textBox_uart_state.TabIndex = 11;
            this.textBox_uart_state.Text = "串口已关闭";
            this.textBox_uart_state.TextChanged += new System.EventHandler(this.textBox_uart_state_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.Controls.Add(this.Button_skip3);
            this.panel5.Controls.Add(this.Button_clear);
            this.panel5.Controls.Add(this.Botton_skip2);
            this.panel5.Controls.Add(this.Button_skip1);
            this.panel5.Controls.Add(this.textBox_receive);
            this.panel5.Location = new System.Drawing.Point(403, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1269, 755);
            this.panel5.TabIndex = 5;
            // 
            // Button_skip3
            // 
            this.Button_skip3.BackColor = System.Drawing.Color.MistyRose;
            this.Button_skip3.Location = new System.Drawing.Point(696, 13);
            this.Button_skip3.Name = "Button_skip3";
            this.Button_skip3.Size = new System.Drawing.Size(235, 78);
            this.Button_skip3.TabIndex = 4;
            this.Button_skip3.Text = "底盘控制";
            this.Button_skip3.UseVisualStyleBackColor = false;
            // 
            // Button_clear
            // 
            this.Button_clear.BackColor = System.Drawing.Color.MistyRose;
            this.Button_clear.Location = new System.Drawing.Point(1015, 13);
            this.Button_clear.Name = "Button_clear";
            this.Button_clear.Size = new System.Drawing.Size(235, 78);
            this.Button_clear.TabIndex = 3;
            this.Button_clear.Text = "重置界面";
            this.Button_clear.UseVisualStyleBackColor = false;
            // 
            // Botton_skip2
            // 
            this.Botton_skip2.BackColor = System.Drawing.Color.MistyRose;
            this.Botton_skip2.Location = new System.Drawing.Point(366, 13);
            this.Botton_skip2.Name = "Botton_skip2";
            this.Botton_skip2.Size = new System.Drawing.Size(235, 78);
            this.Botton_skip2.TabIndex = 2;
            this.Botton_skip2.Text = "图像显示";
            this.Botton_skip2.UseVisualStyleBackColor = false;
            // 
            // Button_skip1
            // 
            this.Button_skip1.BackColor = System.Drawing.Color.MistyRose;
            this.Button_skip1.Location = new System.Drawing.Point(42, 13);
            this.Button_skip1.Name = "Button_skip1";
            this.Button_skip1.Size = new System.Drawing.Size(235, 78);
            this.Button_skip1.TabIndex = 1;
            this.Button_skip1.Text = "电机模式";
            this.Button_skip1.UseVisualStyleBackColor = false;
            this.Button_skip1.Click += new System.EventHandler(this.Button_skip1_Click);
            // 
            // textBox_receive
            // 
            this.textBox_receive.Location = new System.Drawing.Point(24, 97);
            this.textBox_receive.Multiline = true;
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.Size = new System.Drawing.Size(1226, 640);
            this.textBox_receive.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel6.Controls.Add(this.textBox_send);
            this.panel6.Location = new System.Drawing.Point(403, 773);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1005, 243);
            this.panel6.TabIndex = 6;
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(13, 12);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(971, 214);
            this.textBox_send.TabIndex = 1;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(1414, 773);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 243);
            this.button2.TabIndex = 0;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.TIM1_UP_IRQ_Handler);
            // 
            // Timer2
            // 
            this.Timer2.Tick += new System.EventHandler(this.TIM2_UP_IRQHandler);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // formsPlot1
            // 
            this.formsPlot1.DisplayScale = 0F;
            this.formsPlot1.Location = new System.Drawing.Point(1678, 1);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1467, 766);
            this.formsPlot1.TabIndex = 7;
            // 
            // Timer_show
            // 
            this.Timer_show.Tick += new System.EventHandler(this.Timer_show_IRQHandler);
            // 
            // Dragon_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(3143, 1143);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dragon_app";
            this.Text = "dragon_app";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.uart_tx_rx_closed);
            this.Load += new System.EventHandler(this.Dragon_app_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComBox1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComBox2;
        private System.Windows.Forms.ComboBox ComBox5;
        private System.Windows.Forms.ComboBox ComBox4;
        private System.Windows.Forms.ComboBox ComBox3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_receive;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Button Button_skip1;
        private System.Windows.Forms.Button Botton_skip2;
        private System.Windows.Forms.Button Button_clear;
        private System.Windows.Forms.Button Button_skip3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_clear_rv;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.TextBox textBox_rx_count;
        private System.Windows.Forms.TextBox textBox_uart_state;
        private System.Windows.Forms.TextBox textBox_tx_count;
        private System.Windows.Forms.Button button_clear_tx;
        private System.Windows.Forms.Timer Timer2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private System.Windows.Forms.Timer Timer_show;
    }



}

