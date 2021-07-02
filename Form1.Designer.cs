
namespace batterycontrol
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbmax3 = new System.Windows.Forms.TextBox();
            this.tbmin3 = new System.Windows.Forms.TextBox();
            this.tbmax2 = new System.Windows.Forms.TextBox();
            this.tbmin2 = new System.Windows.Forms.TextBox();
            this.tbmax1 = new System.Windows.Forms.TextBox();
            this.tbmin1 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblbatpct = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cbopen = new System.Windows.Forms.CheckBox();
            this.cbcharge = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopChargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Choose";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 208);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(281, 35);
            this.progressBar1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbmax3);
            this.groupBox1.Controls.Add(this.tbmin3);
            this.groupBox1.Controls.Add(this.tbmax2);
            this.groupBox1.Controls.Add(this.tbmin2);
            this.groupBox1.Controls.Add(this.tbmax1);
            this.groupBox1.Controls.Add(this.tbmin1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(25, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charge Mode";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stop (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Start (%)";
            // 
            // tbmax3
            // 
            this.tbmax3.Location = new System.Drawing.Point(185, 88);
            this.tbmax3.Name = "tbmax3";
            this.tbmax3.Size = new System.Drawing.Size(65, 20);
            this.tbmax3.TabIndex = 9;
            this.tbmax3.Text = "60";
            // 
            // tbmin3
            // 
            this.tbmin3.Location = new System.Drawing.Point(114, 88);
            this.tbmin3.Name = "tbmin3";
            this.tbmin3.Size = new System.Drawing.Size(65, 20);
            this.tbmin3.TabIndex = 8;
            this.tbmin3.Text = "55";
            // 
            // tbmax2
            // 
            this.tbmax2.Location = new System.Drawing.Point(185, 63);
            this.tbmax2.Name = "tbmax2";
            this.tbmax2.Size = new System.Drawing.Size(65, 20);
            this.tbmax2.TabIndex = 7;
            this.tbmax2.Text = "80";
            // 
            // tbmin2
            // 
            this.tbmin2.Location = new System.Drawing.Point(114, 62);
            this.tbmin2.Name = "tbmin2";
            this.tbmin2.Size = new System.Drawing.Size(65, 20);
            this.tbmin2.TabIndex = 6;
            this.tbmin2.Text = "75";
            // 
            // tbmax1
            // 
            this.tbmax1.Location = new System.Drawing.Point(185, 37);
            this.tbmax1.Name = "tbmax1";
            this.tbmax1.Size = new System.Drawing.Size(65, 20);
            this.tbmax1.TabIndex = 5;
            this.tbmax1.Text = "90";
            // 
            // tbmin1
            // 
            this.tbmin1.Location = new System.Drawing.Point(114, 36);
            this.tbmin1.Name = "tbmin1";
            this.tbmin1.Size = new System.Drawing.Size(65, 20);
            this.tbmin1.TabIndex = 4;
            this.tbmin1.Text = "80";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 89);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Lifespan";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Balanced";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Full";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Battery charge";
            // 
            // lblbatpct
            // 
            this.lblbatpct.AutoSize = true;
            this.lblbatpct.BackColor = System.Drawing.Color.Lime;
            this.lblbatpct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbatpct.Location = new System.Drawing.Point(143, 177);
            this.lblbatpct.Name = "lblbatpct";
            this.lblbatpct.Size = new System.Drawing.Size(61, 29);
            this.lblbatpct.TabIndex = 5;
            this.lblbatpct.Text = "80%";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            // 
            // cbopen
            // 
            this.cbopen.AutoSize = true;
            this.cbopen.Location = new System.Drawing.Point(188, 20);
            this.cbopen.Name = "cbopen";
            this.cbopen.Size = new System.Drawing.Size(52, 17);
            this.cbopen.TabIndex = 6;
            this.cbopen.Text = "Open";
            this.cbopen.UseVisualStyleBackColor = true;
            this.cbopen.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbcharge
            // 
            this.cbcharge.AutoSize = true;
            this.cbcharge.Enabled = false;
            this.cbcharge.Location = new System.Drawing.Point(246, 20);
            this.cbcharge.Name = "cbcharge";
            this.cbcharge.Size = new System.Drawing.Size(60, 17);
            this.cbcharge.TabIndex = 7;
            this.cbcharge.Text = "Charge";
            this.cbcharge.UseVisualStyleBackColor = true;
            this.cbcharge.CheckedChanged += new System.EventHandler(this.cbcharge_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipTitle = "Battery Control";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargeToolStripMenuItem,
            this.stopChargeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 70);
            // 
            // chargeToolStripMenuItem
            // 
            this.chargeToolStripMenuItem.Name = "chargeToolStripMenuItem";
            this.chargeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.chargeToolStripMenuItem.Text = "Charge";
            this.chargeToolStripMenuItem.Click += new System.EventHandler(this.chargeToolStripMenuItem_Click);
            // 
            // stopChargeToolStripMenuItem
            // 
            this.stopChargeToolStripMenuItem.Name = "stopChargeToolStripMenuItem";
            this.stopChargeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.stopChargeToolStripMenuItem.Text = "Stop charge";
            this.stopChargeToolStripMenuItem.Click += new System.EventHandler(this.stopChargeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 255);
            this.Controls.Add(this.cbcharge);
            this.Controls.Add(this.cbopen);
            this.Controls.Add(this.lblbatpct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battery Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbmax3;
        private System.Windows.Forms.TextBox tbmin3;
        private System.Windows.Forms.TextBox tbmax2;
        private System.Windows.Forms.TextBox tbmin2;
        private System.Windows.Forms.TextBox tbmax1;
        private System.Windows.Forms.TextBox tbmin1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblbatpct;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox cbopen;
        private System.Windows.Forms.CheckBox cbcharge;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopChargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

