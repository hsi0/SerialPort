using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialPort
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			
			foreach (String s in System.IO.Ports.SerialPort.GetPortNames())
			{
				txtPort.Items.Add(s);
               
			}


		}
		public System.IO.Ports.SerialPort sport;


		public void Serialport_connect(string port, int baudrate, Parity parity, int databits, StopBits stopbits)
		{
			DateTime dt = DateTime.Now;
			String dtn = dt.ToShortTimeString();
            sport = new System.IO.Ports.SerialPort(port, baudrate, parity, databits, stopbits);
			try
			{
				sport.Open();
				
				connect.Enabled = false;
				txtReceive.AppendText("[" + dtn + "]" + "Connected\n");
                sport.DataReceived += new SerialDataReceivedEventHandler(sport_DataReceived);
			}
			catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
		}
      
      private void sport_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			DateTime dt = DateTime.Now;
			String dtn = dt.ToShortTimeString();
			txtReceive.AppendText("[" + dtn + "]" + "Received: " + sport.ReadExisting() + "\n");

		}
        private void connect_Click(object sender, EventArgs e)
        {
            String port = txtPort.Text;
            int baudrate = Convert.ToInt32(cbaudrate.Text);
            Parity parity = (Parity)Enum.Parse(typeof(Parity), cparity.Text);
            int databits = Convert.ToInt32(cdatabits.Text);
            StopBits stopbits = (StopBits)Enum.Parse(typeof(StopBits), cstopbits.Text);

            Serialport_connect(port, baudrate, parity, databits, stopbits);
        }

        private void send_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();
            String data = txtSend.Text;
            sport.Write(data);
            txtReceive.AppendText("[" + dtn + "]" + "Sent: " + data + "\n");
        }



       

		}

       
    }

