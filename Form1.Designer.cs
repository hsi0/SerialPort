using System;

namespace SerialPort
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
            this.connect = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.ComboBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cstopbits = new System.Windows.Forms.ComboBox();
            this.cdatabits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cparity = new System.Windows.Forms.ComboBox();
            this.cbaudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(12, 268);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 0;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(448, 226);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 2;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.FormattingEnabled = true;
            this.txtPort.Location = new System.Drawing.Point(79, 46);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(121, 21);
            this.txtPort.TabIndex = 13;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(290, 228);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(155, 20);
            this.txtSend.TabIndex = 18;
            // 
            // txtReceive
            // 
            this.txtReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceive.Location = new System.Drawing.Point(223, 43);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive.Size = new System.Drawing.Size(300, 169);
            this.txtReceive.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stopbits:";
            // 
            // cstopbits
            // 
            this.cstopbits.FormattingEnabled = true;
            this.cstopbits.Location = new System.Drawing.Point(79, 232);
            this.cstopbits.Name = "cstopbits";
            this.cstopbits.Size = new System.Drawing.Size(121, 21);
            this.cstopbits.TabIndex = 17;
            // 
            // cdatabits
            // 
            this.cdatabits.FormattingEnabled = true;
            this.cdatabits.Location = new System.Drawing.Point(79, 182);
            this.cdatabits.Name = "cdatabits";
            this.cdatabits.Size = new System.Drawing.Size(121, 21);
            this.cdatabits.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Databits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parity:";
            // 
            // cparity
            // 
            this.cparity.FormattingEnabled = true;
            this.cparity.Location = new System.Drawing.Point(79, 138);
            this.cparity.Name = "cparity";
            this.cparity.Size = new System.Drawing.Size(121, 21);
            this.cparity.TabIndex = 15;
            // 
            // cbaudrate
            // 
            this.cbaudrate.FormattingEnabled = true;
            this.cbaudrate.Location = new System.Drawing.Point(79, 90);
            this.cbaudrate.Name = "cbaudrate";
            this.cbaudrate.Size = new System.Drawing.Size(121, 21);
            this.cbaudrate.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 309);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.cstopbits);
            this.Controls.Add(this.cdatabits);
            this.Controls.Add(this.cparity);
            this.Controls.Add(this.cbaudrate);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.connect);
            this.Name = "Form1";
            this.Text = "SerialPort";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

	

		#endregion

		private System.Windows.Forms.Button connect;
		private System.Windows.Forms.Button send;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox txtPort;
		private System.Windows.Forms.TextBox txtSend;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cstopbits;
        private System.Windows.Forms.ComboBox cdatabits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cparity;
        private System.Windows.Forms.ComboBox cbaudrate;
        private System.Windows.Forms.Label label2;
    }
}

