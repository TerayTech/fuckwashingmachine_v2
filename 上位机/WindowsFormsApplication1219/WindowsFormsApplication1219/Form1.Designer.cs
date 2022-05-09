namespace WindowsFormsApplication1219
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.cbxBaud = new System.Windows.Forms.ComboBox();
            this.cbxPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_check_com = new System.Windows.Forms.Button();
            this.bt_open_com = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_send = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtReceviedHex = new System.Windows.Forms.RadioButton();
            this.rbtReceviedAscii = new System.Windows.Forms.RadioButton();
            this.tbxReceivedData = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtSendHex = new System.Windows.Forms.RadioButton();
            this.rbtSendAscii = new System.Windows.Forms.RadioButton();
            this.tbxSendData = new System.Windows.Forms.TextBox();
            this.statusLabel1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDataBits);
            this.groupBox1.Controls.Add(this.cbxStopBits);
            this.groupBox1.Controls.Add(this.cbxParity);
            this.groupBox1.Controls.Add(this.cbxBaud);
            this.groupBox1.Controls.Add(this.cbxPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Location = new System.Drawing.Point(67, 154);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(81, 20);
            this.cbxDataBits.TabIndex = 9;
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Location = new System.Drawing.Point(67, 122);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(81, 20);
            this.cbxStopBits.TabIndex = 8;
            // 
            // cbxParity
            // 
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Location = new System.Drawing.Point(67, 90);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(81, 20);
            this.cbxParity.TabIndex = 7;
            // 
            // cbxBaud
            // 
            this.cbxBaud.FormattingEnabled = true;
            this.cbxBaud.Location = new System.Drawing.Point(67, 58);
            this.cbxBaud.Name = "cbxBaud";
            this.cbxBaud.Size = new System.Drawing.Size(81, 20);
            this.cbxBaud.TabIndex = 6;
            this.cbxBaud.SelectedIndexChanged += new System.EventHandler(this.cbxBaud_SelectedIndexChanged);
            // 
            // cbxPort
            // 
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Location = new System.Drawing.Point(67, 26);
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(81, 20);
            this.cbxPort.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "数据位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "停止位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "校验位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号：";
            // 
            // bt_check_com
            // 
            this.bt_check_com.Location = new System.Drawing.Point(4, 45);
            this.bt_check_com.Name = "bt_check_com";
            this.bt_check_com.Size = new System.Drawing.Size(75, 23);
            this.bt_check_com.TabIndex = 1;
            this.bt_check_com.Text = "检测串口";
            this.bt_check_com.UseVisualStyleBackColor = true;
            this.bt_check_com.Click += new System.EventHandler(this.bt_check_com_Click);
            // 
            // bt_open_com
            // 
            this.bt_open_com.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_open_com.Location = new System.Drawing.Point(90, 45);
            this.bt_open_com.Name = "bt_open_com";
            this.bt_open_com.Size = new System.Drawing.Size(75, 23);
            this.bt_open_com.TabIndex = 2;
            this.bt_open_com.Text = "打开串口";
            this.bt_open_com.UseVisualStyleBackColor = true;
            this.bt_open_com.Click += new System.EventHandler(this.bt_open_com_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(4, 114);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 3;
            this.bt_clear.Text = "清除";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_send
            // 
            this.bt_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_send.Location = new System.Drawing.Point(90, 114);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(75, 23);
            this.bt_send.TabIndex = 4;
            this.bt_send.Text = "发送";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_check_com);
            this.groupBox2.Controls.Add(this.bt_send);
            this.groupBox2.Controls.Add(this.bt_open_com);
            this.groupBox2.Controls.Add(this.bt_clear);
            this.groupBox2.Location = new System.Drawing.Point(9, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 168);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "按钮区";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtReceviedHex);
            this.groupBox3.Controls.Add(this.rbtReceviedAscii);
            this.groupBox3.Controls.Add(this.tbxReceivedData);
            this.groupBox3.Location = new System.Drawing.Point(204, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 238);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收字符串";
            // 
            // rbtReceviedHex
            // 
            this.rbtReceviedHex.AutoSize = true;
            this.rbtReceviedHex.Location = new System.Drawing.Point(118, 215);
            this.rbtReceviedHex.Name = "rbtReceviedHex";
            this.rbtReceviedHex.Size = new System.Drawing.Size(65, 16);
            this.rbtReceviedHex.TabIndex = 2;
            this.rbtReceviedHex.TabStop = true;
            this.rbtReceviedHex.Text = "Hex显示";
            this.rbtReceviedHex.UseVisualStyleBackColor = true;
            // 
            // rbtReceviedAscii
            // 
            this.rbtReceviedAscii.AutoSize = true;
            this.rbtReceviedAscii.Location = new System.Drawing.Point(16, 216);
            this.rbtReceviedAscii.Name = "rbtReceviedAscii";
            this.rbtReceviedAscii.Size = new System.Drawing.Size(71, 16);
            this.rbtReceviedAscii.TabIndex = 1;
            this.rbtReceviedAscii.TabStop = true;
            this.rbtReceviedAscii.Text = "字符显示";
            this.rbtReceviedAscii.UseVisualStyleBackColor = true;
            // 
            // tbxReceivedData
            // 
            this.tbxReceivedData.Location = new System.Drawing.Point(16, 29);
            this.tbxReceivedData.Multiline = true;
            this.tbxReceivedData.Name = "tbxReceivedData";
            this.tbxReceivedData.ReadOnly = true;
            this.tbxReceivedData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxReceivedData.Size = new System.Drawing.Size(341, 180);
            this.tbxReceivedData.TabIndex = 0;
            this.tbxReceivedData.TextChanged += new System.EventHandler(this.tbxReceivedData_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtSendHex);
            this.groupBox4.Controls.Add(this.rbtSendAscii);
            this.groupBox4.Controls.Add(this.tbxSendData);
            this.groupBox4.Location = new System.Drawing.Point(204, 258);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 113);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "发送字符串";
            // 
            // rbtSendHex
            // 
            this.rbtSendHex.AutoSize = true;
            this.rbtSendHex.Location = new System.Drawing.Point(118, 91);
            this.rbtSendHex.Name = "rbtSendHex";
            this.rbtSendHex.Size = new System.Drawing.Size(65, 16);
            this.rbtSendHex.TabIndex = 2;
            this.rbtSendHex.TabStop = true;
            this.rbtSendHex.Text = "Hex显示";
            this.rbtSendHex.UseVisualStyleBackColor = true;
            this.rbtSendHex.CheckedChanged += new System.EventHandler(this.rbtSendHex_CheckedChanged);
            // 
            // rbtSendAscii
            // 
            this.rbtSendAscii.AutoSize = true;
            this.rbtSendAscii.Location = new System.Drawing.Point(16, 91);
            this.rbtSendAscii.Name = "rbtSendAscii";
            this.rbtSendAscii.Size = new System.Drawing.Size(71, 16);
            this.rbtSendAscii.TabIndex = 1;
            this.rbtSendAscii.TabStop = true;
            this.rbtSendAscii.Text = "字符显示";
            this.rbtSendAscii.UseVisualStyleBackColor = true;
            this.rbtSendAscii.CheckedChanged += new System.EventHandler(this.rbtSendAscii_CheckedChanged);
            // 
            // tbxSendData
            // 
            this.tbxSendData.Location = new System.Drawing.Point(16, 21);
            this.tbxSendData.Multiline = true;
            this.tbxSendData.Name = "tbxSendData";
            this.tbxSendData.Size = new System.Drawing.Size(341, 61);
            this.tbxSendData.TabIndex = 0;
            // 
            // statusLabel1
            // 
            this.statusLabel1.AutoSize = true;
            this.statusLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusLabel1.Location = new System.Drawing.Point(154, 375);
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(55, 21);
            this.statusLabel1.TabIndex = 8;
            this.statusLabel1.Text = "status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "命令执行状态";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(619, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 401);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "功能设置";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(34, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 55);
            this.button5.TabIndex = 20;
            this.button5.Text = "大件物品";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(34, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 55);
            this.button4.TabIndex = 19;
            this.button4.Text = "标准洗衣";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(34, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 55);
            this.button3.TabIndex = 18;
            this.button3.Text = "快速洗衣";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(34, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 55);
            this.button2.TabIndex = 17;
            this.button2.Text = "强制停止";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(34, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "测试脱水";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 479);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusLabel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "洗衣机控制台";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.ComboBox cbxBaud;
        private System.Windows.Forms.ComboBox cbxPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_check_com;
        private System.Windows.Forms.Button bt_open_com;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtReceviedHex;
        private System.Windows.Forms.RadioButton rbtReceviedAscii;
        private System.Windows.Forms.TextBox tbxReceivedData;
        private System.Windows.Forms.RadioButton rbtSendHex;
        private System.Windows.Forms.RadioButton rbtSendAscii;
        private System.Windows.Forms.TextBox tbxSendData;
        private System.Windows.Forms.Label statusLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

