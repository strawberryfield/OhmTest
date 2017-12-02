using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace OhmTest
{
    public partial class MainForm : Form
    {
        protected SerialPort Port;
        protected bool PowerOn;
        
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            PowerOn = false;
        }
    
        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbSerial.DataSource = ports;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbSerial.SelectedIndex > -1)
            {
                Connect(cmbSerial.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Scegliere la porta.");
            }

        }

        private void Connect(string portName)
        {
            Port = new SerialPort(portName);

            if (!Port.IsOpen)
            {
                Port.BaudRate = 9600;
                Port.Open();
                Port.WriteLine("");

                Port.ReadLine();
                chkConnect.Checked = true;
                Port.DiscardInBuffer();
                Port.DiscardOutBuffer();
                Port.WriteLine("B");
                Reset();
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                btnReset.Visible = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Port != null && Port.IsOpen)
            {
                Reset();
                Port.Close();
            }
        }

        protected void SendCommand(string cmd)
        {
            float volt;

            Port.DiscardInBuffer();
            Port.WriteLine(cmd);
            string result = Port.ReadLine();
            txtVolt.Text = result;
            txtAmpere.Text = result;
            try
            {
                volt = Convert.ToSingle(result.Replace(".", ","));
            }
            catch (Exception)
            {
                volt = 0;
            }
            voltmetro.Value = volt;
            amperometro.Value = volt;
            if (volt != 0)
            {
                txtOhm.Text = String.Format("{0:0}", (5 - volt)/volt*1000);
            }
            else
            {
                txtOhm.Text = "";
            }
            
        }

        protected void Reset()
        {
            mainSwitch.Image = global::OhmTest.Properties.Resources.interruttore_off;
            SendCommand("0");
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            PowerOn = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void mainSwitch_Click(object sender, EventArgs e)
        {
            if (Port != null && Port.IsOpen)
            {
                if (PowerOn)
                {
                    Reset();
                }
                else
                {
                    PowerOn = true;
                    mainSwitch.Image = global::OhmTest.Properties.Resources.interruttore_on;
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    if (!checkBox1.Checked && !checkBox2.Checked)
                    {
                        checkBox1.Checked = true;
                    }
                    if (checkBox1.Checked)
                    {
                        SendCommand("1");
                    }
                    if (checkBox2.Checked)
                    {
                        SendCommand("2");
                    }
                }
            }
            else
            {
                MessageBox.Show("Dispositivo non collegato.");
            }

        }
    }
}
