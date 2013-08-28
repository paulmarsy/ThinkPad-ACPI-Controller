using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using TVicPort_Cs;

namespace MemTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MemForm : System.Windows.Forms.Form
	{

		bool DriverOpened = false;
		public System.Windows.Forms.Button B_Exit;
		public System.Windows.Forms.Button Close_Driver;
		public System.Windows.Forms.Button Open_Driver;
		public System.Windows.Forms.ListBox ListAddr;
		public System.Windows.Forms.ListBox ListHex;
		public System.Windows.Forms.ListBox ListAscii;
		public System.Windows.Forms.TextBox E_Base;
		public System.Windows.Forms.Button B_ReadMemory;
		public System.Windows.Forms.Label Label12;
		public System.Windows.Forms.Label Label13;
		public System.Windows.Forms.Label Label14;
		private System.Windows.Forms.Label label6;
		internal System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label L_Days;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MemForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MemForm));
			this.B_Exit = new System.Windows.Forms.Button();
			this.Close_Driver = new System.Windows.Forms.Button();
			this.Open_Driver = new System.Windows.Forms.Button();
			this.ListAddr = new System.Windows.Forms.ListBox();
			this.ListHex = new System.Windows.Forms.ListBox();
			this.ListAscii = new System.Windows.Forms.ListBox();
			this.E_Base = new System.Windows.Forms.TextBox();
			this.B_ReadMemory = new System.Windows.Forms.Button();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.L_Days = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// B_Exit
			// 
			this.B_Exit.BackColor = System.Drawing.SystemColors.Control;
			this.B_Exit.Cursor = System.Windows.Forms.Cursors.Default;
			this.B_Exit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.B_Exit.ForeColor = System.Drawing.SystemColors.ControlText;
			this.B_Exit.Location = new System.Drawing.Point(472, 270);
			this.B_Exit.Name = "B_Exit";
			this.B_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.B_Exit.Size = new System.Drawing.Size(161, 33);
			this.B_Exit.TabIndex = 27;
			this.B_Exit.Text = "Exit";
			this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
			// 
			// Close_Driver
			// 
			this.Close_Driver.BackColor = System.Drawing.SystemColors.Control;
			this.Close_Driver.Cursor = System.Windows.Forms.Cursors.Default;
			this.Close_Driver.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Close_Driver.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Close_Driver.Location = new System.Drawing.Point(472, 200);
			this.Close_Driver.Name = "Close_Driver";
			this.Close_Driver.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Close_Driver.Size = new System.Drawing.Size(161, 33);
			this.Close_Driver.TabIndex = 26;
			this.Close_Driver.Text = "Close Driver";
			this.Close_Driver.Click += new System.EventHandler(this.Close_Driver_Click);
			// 
			// Open_Driver
			// 
			this.Open_Driver.BackColor = System.Drawing.SystemColors.Control;
			this.Open_Driver.Cursor = System.Windows.Forms.Cursors.Default;
			this.Open_Driver.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Open_Driver.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Open_Driver.Location = new System.Drawing.Point(472, 152);
			this.Open_Driver.Name = "Open_Driver";
			this.Open_Driver.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Open_Driver.Size = new System.Drawing.Size(161, 33);
			this.Open_Driver.TabIndex = 25;
			this.Open_Driver.Text = "Open Driver";
			this.Open_Driver.Click += new System.EventHandler(this.Open_Driver_Click);
			// 
			// ListAddr
			// 
			this.ListAddr.BackColor = System.Drawing.SystemColors.Window;
			this.ListAddr.Cursor = System.Windows.Forms.Cursors.Default;
			this.ListAddr.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.ListAddr.ForeColor = System.Drawing.SystemColors.WindowText;
			this.ListAddr.ItemHeight = 14;
			this.ListAddr.Location = new System.Drawing.Point(8, 32);
			this.ListAddr.Name = "ListAddr";
			this.ListAddr.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ListAddr.Size = new System.Drawing.Size(65, 228);
			this.ListAddr.TabIndex = 21;
			// 
			// ListHex
			// 
			this.ListHex.BackColor = System.Drawing.SystemColors.Window;
			this.ListHex.Cursor = System.Windows.Forms.Cursors.Default;
			this.ListHex.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.ListHex.ForeColor = System.Drawing.SystemColors.WindowText;
			this.ListHex.ItemHeight = 14;
			this.ListHex.Location = new System.Drawing.Point(76, 32);
			this.ListHex.Name = "ListHex";
			this.ListHex.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ListHex.Size = new System.Drawing.Size(233, 228);
			this.ListHex.TabIndex = 20;
			// 
			// ListAscii
			// 
			this.ListAscii.BackColor = System.Drawing.SystemColors.Window;
			this.ListAscii.Cursor = System.Windows.Forms.Cursors.Default;
			this.ListAscii.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.ListAscii.ForeColor = System.Drawing.SystemColors.WindowText;
			this.ListAscii.ItemHeight = 14;
			this.ListAscii.Location = new System.Drawing.Point(312, 32);
			this.ListAscii.Name = "ListAscii";
			this.ListAscii.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ListAscii.Size = new System.Drawing.Size(129, 228);
			this.ListAscii.TabIndex = 19;
			// 
			// E_Base
			// 
			this.E_Base.AcceptsReturn = true;
			this.E_Base.AutoSize = false;
			this.E_Base.BackColor = System.Drawing.SystemColors.Window;
			this.E_Base.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.E_Base.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.E_Base.ForeColor = System.Drawing.SystemColors.WindowText;
			this.E_Base.Location = new System.Drawing.Point(368, 272);
			this.E_Base.MaxLength = 0;
			this.E_Base.Name = "E_Base";
			this.E_Base.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.E_Base.Size = new System.Drawing.Size(73, 28);
			this.E_Base.TabIndex = 18;
			this.E_Base.Text = "000c0044";
			// 
			// B_ReadMemory
			// 
			this.B_ReadMemory.BackColor = System.Drawing.SystemColors.Control;
			this.B_ReadMemory.Cursor = System.Windows.Forms.Cursors.Default;
			this.B_ReadMemory.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.B_ReadMemory.ForeColor = System.Drawing.SystemColors.ControlText;
			this.B_ReadMemory.Location = new System.Drawing.Point(8, 272);
			this.B_ReadMemory.Name = "B_ReadMemory";
			this.B_ReadMemory.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.B_ReadMemory.Size = new System.Drawing.Size(345, 29);
			this.B_ReadMemory.TabIndex = 17;
			this.B_ReadMemory.Text = "Read 256 bytes from this physical memory adrress ==>";
			this.B_ReadMemory.Click += new System.EventHandler(this.B_ReadMemory_Click);
			// 
			// Label12
			// 
			this.Label12.BackColor = System.Drawing.SystemColors.Control;
			this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label12.Location = new System.Drawing.Point(16, 8);
			this.Label12.Name = "Label12";
			this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label12.Size = new System.Drawing.Size(73, 17);
			this.Label12.TabIndex = 24;
			this.Label12.Text = "Addr(hex)";
			// 
			// Label13
			// 
			this.Label13.BackColor = System.Drawing.SystemColors.Control;
			this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label13.Location = new System.Drawing.Point(128, 8);
			this.Label13.Name = "Label13";
			this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label13.Size = new System.Drawing.Size(129, 17);
			this.Label13.TabIndex = 23;
			this.Label13.Text = "H E X A D E C I M A L";
			// 
			// Label14
			// 
			this.Label14.BackColor = System.Drawing.SystemColors.Control;
			this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label14.Location = new System.Drawing.Point(344, 8);
			this.Label14.Name = "Label14";
			this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label14.Size = new System.Drawing.Size(89, 17);
			this.Label14.TabIndex = 22;
			this.Label14.Text = "A S C I I";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(487, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 16);
			this.label6.TabIndex = 46;
			this.label6.Text = "(c) 2005, EnTech Taiwan";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(528, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 45;
			this.label3.Text = "TVicPort";
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(487, 80);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(131, 16);
			this.linkLabel2.TabIndex = 51;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "tools@entechtaiwan.com";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(476, 56);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(152, 16);
			this.linkLabel1.TabIndex = 50;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "http://www.entechtaiwan.com";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// L_Days
			// 
			this.L_Days.Location = new System.Drawing.Point(472, 112);
			this.L_Days.Name = "L_Days";
			this.L_Days.Size = new System.Drawing.Size(160, 16);
			this.L_Days.TabIndex = 52;
			this.L_Days.Text = "Evaluation Days Left: ??";
			this.L_Days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MemForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(656, 309);
			this.Controls.Add(this.L_Days);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.B_Exit);
			this.Controls.Add(this.Close_Driver);
			this.Controls.Add(this.Open_Driver);
			this.Controls.Add(this.ListAddr);
			this.Controls.Add(this.ListHex);
			this.Controls.Add(this.ListAscii);
			this.Controls.Add(this.E_Base);
			this.Controls.Add(this.B_ReadMemory);
			this.Controls.Add(this.Label12);
			this.Controls.Add(this.Label13);
			this.Controls.Add(this.Label14);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MemForm";
			this.Text = "Physical Memory Sample Application";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.Form1_Closed);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MemForm());
		}

		private void LockControls()
		{
			Open_Driver.Enabled = !DriverOpened;
			Close_Driver.Enabled = DriverOpened;
			B_ReadMemory.Enabled = DriverOpened;
		}

		private void Open_Driver_Click(object sender, System.EventArgs e)
		{
			TVicPort.OpenTVicPort();
			DriverOpened = TVicPort.IsDriverOpened() != 0;
			if (DriverOpened)
				L_Days.Text = "Evaluation Days Left: " + TVicPort.EvaluationDaysLeft().ToString("d");
			LockControls();
		}

		private void Close_Driver_Click(object sender, System.EventArgs e)
		{
			TVicPort.CloseTVicPort();
			DriverOpened = false;
			LockControls();
		}

		private void B_Exit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void Form1_Closed(object sender, System.EventArgs e)
		{
			TVicPort.CloseTVicPort();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			DriverOpened = false;
			LockControls();
		}

		unsafe	private void B_ReadMemory_Click(object sender, System.EventArgs e)
		{
			String s;
			uint i,j;		
			UInt32 PhysAddr;
			byte * MappedAddr;

			byte[] b = new byte[16];
			ASCIIEncoding ascii = new ASCIIEncoding();
			
			// read the base physical address from Edit box
			PhysAddr = UInt32.Parse(E_Base.Text, System.Globalization.NumberStyles.HexNumber);
			
			// map this address to the linear address space
			MappedAddr = (byte*)TVicPort.MapPhysToLinear(PhysAddr, 256);

			// display memory dump

			ListAddr.Items.Clear();
			ListHex.Items.Clear();
			ListAscii.Items.Clear();

			for (i = 0; i< 16; i++) // 16 lines in box
			{			
				s = "";
				for (j = 0; j< 16; j++) // 16 bytes in line
				{
					b[j] = *(MappedAddr +16*i+j);
					s = s + b[j].ToString("X2");
					if (b[j] < 32) b[j] = 46; // replace all nonreadable symbols to "."
				}

				ListAddr.Items.Add((PhysAddr+16*i).ToString("X8")); // address
                ListHex.Items.Add(s);				                // hex
				ListAscii.Items.Add(ascii.GetString(b));            // ascii				
			}
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			TVicPort.LaunchWeb();
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			TVicPort.LaunchMail();
		}
		
		
	}
}
