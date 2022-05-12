namespace serialControlPWM
{
    partial class Form1
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
            this.btn_100 = new System.Windows.Forms.Button();
            this.btn_255 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_0 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_200 = new System.Windows.Forms.Button();
            this.btn_50 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.but_apply = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_srl_close = new System.Windows.Forms.Button();
            this.btn_srl_open = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbox_baud_rate = new System.Windows.Forms.ComboBox();
            this.cbox_ports = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_100
            // 
            this.btn_100.Location = new System.Drawing.Point(6, 85);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(75, 23);
            this.btn_100.TabIndex = 0;
            this.btn_100.Text = "100";
            this.btn_100.UseVisualStyleBackColor = true;
            this.btn_100.Click += new System.EventHandler(this.btn_100_clk);
            // 
            // btn_255
            // 
            this.btn_255.Location = new System.Drawing.Point(6, 151);
            this.btn_255.Name = "btn_255";
            this.btn_255.Size = new System.Drawing.Size(75, 23);
            this.btn_255.TabIndex = 1;
            this.btn_255.Text = "255";
            this.btn_255.UseVisualStyleBackColor = true;
            this.btn_255.Click += new System.EventHandler(this.btn_255_clk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arduino2PWM";
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(6, 22);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 23);
            this.btn_0.TabIndex = 3;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 74);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(275, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(279, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_200);
            this.groupBox1.Controls.Add(this.btn_50);
            this.groupBox1.Controls.Add(this.btn_0);
            this.groupBox1.Controls.Add(this.btn_100);
            this.groupBox1.Controls.Add(this.btn_255);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试常用数值";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_200
            // 
            this.btn_200.Location = new System.Drawing.Point(6, 117);
            this.btn_200.Name = "btn_200";
            this.btn_200.Size = new System.Drawing.Size(75, 23);
            this.btn_200.TabIndex = 5;
            this.btn_200.Text = "200";
            this.btn_200.UseVisualStyleBackColor = true;
            this.btn_200.Click += new System.EventHandler(this.btn_200_Click);
            // 
            // btn_50
            // 
            this.btn_50.Location = new System.Drawing.Point(6, 51);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(75, 23);
            this.btn_50.TabIndex = 4;
            this.btn_50.Text = "50";
            this.btn_50.UseVisualStyleBackColor = true;
            this.btn_50.Click += new System.EventHandler(this.btn_50_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(239, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "数值";
            // 
            // but_apply
            // 
            this.but_apply.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_apply.Location = new System.Drawing.Point(298, 81);
            this.but_apply.Name = "but_apply";
            this.but_apply.Size = new System.Drawing.Size(101, 38);
            this.but_apply.TabIndex = 9;
            this.but_apply.Text = "应用";
            this.but_apply.UseVisualStyleBackColor = true;
            this.but_apply.Click += new System.EventHandler(this.but_apply_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_apply);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(147, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 121);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数值选择";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "By TerayTech";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "2018.8.16";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "v1.0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_srl_close);
            this.groupBox3.Controls.Add(this.btn_srl_open);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbox_baud_rate);
            this.groupBox3.Controls.Add(this.cbox_ports);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(147, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 63);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口连接";
            // 
            // btn_srl_close
            // 
            this.btn_srl_close.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_srl_close.Location = new System.Drawing.Point(298, 14);
            this.btn_srl_close.Name = "btn_srl_close";
            this.btn_srl_close.Size = new System.Drawing.Size(101, 41);
            this.btn_srl_close.TabIndex = 5;
            this.btn_srl_close.Text = "关闭串口";
            this.btn_srl_close.UseVisualStyleBackColor = true;
            this.btn_srl_close.Click += new System.EventHandler(this.btn_srl_close_Click);
            // 
            // btn_srl_open
            // 
            this.btn_srl_open.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_srl_open.Location = new System.Drawing.Point(181, 14);
            this.btn_srl_open.Name = "btn_srl_open";
            this.btn_srl_open.Size = new System.Drawing.Size(100, 41);
            this.btn_srl_open.TabIndex = 4;
            this.btn_srl_open.Text = "打开串口";
            this.btn_srl_open.UseVisualStyleBackColor = true;
            this.btn_srl_open.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "波特率";
            // 
            // cbox_baud_rate
            // 
            this.cbox_baud_rate.AutoCompleteCustomSource.AddRange(new string[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "57600",
            "115200"});
            this.cbox_baud_rate.FormattingEnabled = true;
            this.cbox_baud_rate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "57600",
            "115200"});
            this.cbox_baud_rate.Location = new System.Drawing.Point(62, 40);
            this.cbox_baud_rate.Name = "cbox_baud_rate";
            this.cbox_baud_rate.Size = new System.Drawing.Size(79, 20);
            this.cbox_baud_rate.TabIndex = 2;
            this.cbox_baud_rate.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbox_ports
            // 
            this.cbox_ports.AutoCompleteCustomSource.AddRange(new string[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cbox_ports.FormattingEnabled = true;
            this.cbox_ports.Location = new System.Drawing.Point(62, 14);
            this.cbox_ports.Name = "cbox_ports";
            this.cbox_ports.Size = new System.Drawing.Size(79, 20);
            this.cbox_ports.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "串口号";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 245);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.Button btn_255;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_apply;
        private System.Windows.Forms.Button btn_200;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbox_baud_rate;
        private System.Windows.Forms.ComboBox cbox_ports;
        private System.Windows.Forms.Label label7;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_srl_close;
        private System.Windows.Forms.Button btn_srl_open;
    }
}

