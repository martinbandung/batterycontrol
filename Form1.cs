using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; //library untuk serial

namespace batterycontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowPowerStatus();
            getAvailablePort();
            lblbatpct.BackColor = Color.Transparent;
            
        }
        int batpct = 0;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        void getAvailablePort()
        {
            comboBox1.Items.Clear();
            string[] portname = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(portname); //menambahkan array port tersedia
            comboBox1.Items.Add("Refresh");
            //comboBox2

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowPowerStatus();
            //MessageBox.Show("Tick");
            if (serialPort1.IsOpen)
            {
                if (radioButton1.Checked)
                {
                    if (batpct <= Int16.Parse(tbmin1.Text))
                    {
                        serialPort1.WriteLine("fungsi1:1");
                        cbcharge.Checked = true;
                    }
                    else if (batpct >= Int16.Parse(tbmax1.Text))
                    {
                        serialPort1.WriteLine("fungsi1:0");
                        cbcharge.Checked = false;
                    }
                }

                if (radioButton2.Checked)
                {
                    if (batpct <= Int16.Parse(tbmin2.Text))
                    {
                        serialPort1.WriteLine("fungsi1:1");
                        cbcharge.Checked = true;
                    }
                    else if (batpct >= Int16.Parse(tbmax2.Text))
                    {
                        serialPort1.WriteLine("fungsi1:0");
                        cbcharge.Checked = false;
                    }
                }

                if (radioButton3.Checked)
                {
                    if (batpct <= Int16.Parse(tbmin3.Text))
                    {
                        serialPort1.WriteLine("fungsi1:1");
                        cbcharge.Checked = true;
                    }
                    else if (batpct >= Int16.Parse(tbmax3.Text))
                    {
                        serialPort1.WriteLine("fungsi1:0");
                        cbcharge.Checked = false;
                    }
                }
            }
            

        }
        
        private void ShowPowerStatus()
        {
            PowerStatus status = SystemInformation.PowerStatus;
            /*
             * txtChargeStatus.Text = status.BatteryChargeStatus.ToString();
            if (status.BatteryFullLifetime == -1)
                txtFullLifetime.Text = "Unknown";
            else
                txtFullLifetime.Text =
                    status.BatteryFullLifetime.ToString();
            */
            lblbatpct.Text = status.BatteryLifePercent.ToString("P0");
            progressBar1.Value = (int.Parse((lblbatpct.Text).TrimEnd(new char[] { '%', ' ' })));
            batpct = progressBar1.Value;
            notifyIcon1.Text= "Battery: "+lblbatpct.Text;
            /*
            if (status.BatteryLifeRemaining == -1)
                txtLifeRemaining.Text = "Unknown";
            else
                txtLifeRemaining.Text =
                    status.BatteryLifeRemaining.ToString();
            txtLineStatus.Text = status.PowerLineStatus.ToString();
            */
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbopen.Checked)
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.ReadTimeout = 1000;
                serialPort1.WriteTimeout = 1000;
                //serialPort1.DataReceived += SerialPort1_DataReceived;
                serialPort1.Open();
                timer1.Enabled = true;
                cbcharge.Enabled = true;
            }
            else
            {
                serialPort1.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblbatpct.BackColor = System.Drawing.Color.Transparent;
        }

        private void cbcharge_CheckedChanged(object sender, EventArgs e)
        {
            if(cbcharge.Checked)
            {
                serialPort1.WriteLine("fungsi1:1");
            }
            else
            {
                serialPort1.WriteLine("fungsi1:0");
            }
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Refresh")
            {
                getAvailablePort();
            }
            
        }

        private void chargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbopen.Checked)
            {
                cbcharge.Checked = true;
            }
            
        }

        private void stopChargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbopen.Checked)
            {
                cbcharge.Checked = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbopen.Checked)
            {
                cbcharge.Checked = false;
            }
            this.Close();
        }
    }
}
