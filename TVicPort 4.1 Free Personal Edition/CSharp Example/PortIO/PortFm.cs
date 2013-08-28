using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using System.Data;
using TVicPort_Cs;


namespace PortIo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	/// 
	
	public class PortForm : System.Windows.Forms.Form
	{

		bool DriverOpened = false;

		public System.Windows.Forms.GroupBox Frame4;
		public System.Windows.Forms.TextBox EPortAddr;
		public System.Windows.Forms.Button B_Test;
		public System.Windows.Forms.Label L_Test4;
		public System.Windows.Forms.Label L_Test1;
		public System.Windows.Forms.Label Label13;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label12;
		public System.Windows.Forms.Button Open_Driver;
		public System.Windows.Forms.Button Close_Driver;
		public System.Windows.Forms.Button B_Exit;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label6;
		internal System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.TextBox PortR1;
		public System.Windows.Forms.TextBox PortW1;
		public System.Windows.Forms.TextBox ValW1;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Button Read_Port;
		public System.Windows.Forms.Label ValR1;
		public System.Windows.Forms.Button Write_Port;
		private System.Windows.Forms.ComboBox C_ReadSize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox C_WriteSize;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox E_Cycles;
		private System.Windows.Forms.Label L_Days;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PortForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PortForm));
			this.Frame4 = new System.Windows.Forms.GroupBox();
			this.E_Cycles = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.EPortAddr = new System.Windows.Forms.TextBox();
			this.B_Test = new System.Windows.Forms.Button();
			this.L_Test4 = new System.Windows.Forms.Label();
			this.L_Test1 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Open_Driver = new System.Windows.Forms.Button();
			this.Close_Driver = new System.Windows.Forms.Button();
			this.B_Exit = new System.Windows.Forms.Button();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.C_WriteSize = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.C_ReadSize = new System.Windows.Forms.ComboBox();
			this.PortR1 = new System.Windows.Forms.TextBox();
			this.PortW1 = new System.Windows.Forms.TextBox();
			this.ValW1 = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Read_Port = new System.Windows.Forms.Button();
			this.ValR1 = new System.Windows.Forms.Label();
			this.Write_Port = new System.Windows.Forms.Button();
			this.L_Days = new System.Windows.Forms.Label();
			this.Frame4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Frame4
			// 
			this.Frame4.BackColor = System.Drawing.SystemColors.Control;
			this.Frame4.Controls.Add(this.E_Cycles);
			this.Frame4.Controls.Add(this.label4);
			this.Frame4.Controls.Add(this.EPortAddr);
			this.Frame4.Controls.Add(this.B_Test);
			this.Frame4.Controls.Add(this.L_Test4);
			this.Frame4.Controls.Add(this.L_Test1);
			this.Frame4.Controls.Add(this.Label13);
			this.Frame4.Controls.Add(this.Label2);
			this.Frame4.Controls.Add(this.Label12);
			this.Frame4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Frame4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame4.Location = new System.Drawing.Point(8, 152);
			this.Frame4.Name = "Frame4";
			this.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame4.Size = new System.Drawing.Size(340, 160);
			this.Frame4.TabIndex = 62;
			this.Frame4.TabStop = false;
			this.Frame4.Text = "Port I/O performance test";
			// 
			// E_Cycles
			// 
			this.E_Cycles.AutoSize = false;
			this.E_Cycles.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.E_Cycles.Location = new System.Drawing.Point(148, 61);
			this.E_Cycles.Name = "E_Cycles";
			this.E_Cycles.Size = new System.Drawing.Size(60, 24);
			this.E_Cycles.TabIndex = 52;
			this.E_Cycles.Text = "20000";
			this.E_Cycles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 16);
			this.label4.TabIndex = 51;
			this.label4.Text = "Number Of I/O Cycles:";
			// 
			// EPortAddr
			// 
			this.EPortAddr.AcceptsReturn = true;
			this.EPortAddr.AutoSize = false;
			this.EPortAddr.BackColor = System.Drawing.SystemColors.Window;
			this.EPortAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.EPortAddr.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EPortAddr.ForeColor = System.Drawing.SystemColors.WindowText;
			this.EPortAddr.Location = new System.Drawing.Point(148, 28);
			this.EPortAddr.MaxLength = 4;
			this.EPortAddr.Name = "EPortAddr";
			this.EPortAddr.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.EPortAddr.Size = new System.Drawing.Size(40, 24);
			this.EPortAddr.TabIndex = 44;
			this.EPortAddr.Text = "0378";
			this.EPortAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.EPortAddr.TextChanged += new System.EventHandler(this.EPortAddr_TextChanged);
			// 
			// B_Test
			// 
			this.B_Test.BackColor = System.Drawing.SystemColors.Control;
			this.B_Test.Cursor = System.Windows.Forms.Cursors.Default;
			this.B_Test.Enabled = false;
			this.B_Test.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.B_Test.ForeColor = System.Drawing.SystemColors.ControlText;
			this.B_Test.Location = new System.Drawing.Point(224, 26);
			this.B_Test.Name = "B_Test";
			this.B_Test.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.B_Test.Size = new System.Drawing.Size(96, 28);
			this.B_Test.TabIndex = 41;
			this.B_Test.Text = "Run test";
			this.B_Test.Click += new System.EventHandler(this.B_Test_Click);
			// 
			// L_Test4
			// 
			this.L_Test4.AutoSize = true;
			this.L_Test4.BackColor = System.Drawing.SystemColors.Control;
			this.L_Test4.Cursor = System.Windows.Forms.Cursors.Default;
			this.L_Test4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.L_Test4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.L_Test4.Location = new System.Drawing.Point(148, 131);
			this.L_Test4.Name = "L_Test4";
			this.L_Test4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.L_Test4.Size = new System.Drawing.Size(57, 16);
			this.L_Test4.TabIndex = 50;
			this.L_Test4.Text = "0 microsec";
			// 
			// L_Test1
			// 
			this.L_Test1.AutoSize = true;
			this.L_Test1.BackColor = System.Drawing.SystemColors.Control;
			this.L_Test1.Cursor = System.Windows.Forms.Cursors.Default;
			this.L_Test1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.L_Test1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.L_Test1.Location = new System.Drawing.Point(148, 98);
			this.L_Test1.Name = "L_Test1";
			this.L_Test1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.L_Test1.Size = new System.Drawing.Size(57, 16);
			this.L_Test1.TabIndex = 49;
			this.L_Test1.Text = "0 microsec";
			// 
			// Label13
			// 
			this.Label13.AutoSize = true;
			this.Label13.BackColor = System.Drawing.SystemColors.Control;
			this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label13.Location = new System.Drawing.Point(24, 131);
			this.Label13.Name = "Label13";
			this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label13.Size = new System.Drawing.Size(111, 16);
			this.Label13.TabIndex = 48;
			this.Label13.Text = "With ReadPortFIFO():";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(11, 98);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(124, 16);
			this.Label2.TabIndex = 47;
			this.Label2.Text = "Separate I/O operations:";
			// 
			// Label12
			// 
			this.Label12.AutoSize = true;
			this.Label12.BackColor = System.Drawing.SystemColors.Control;
			this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label12.Location = new System.Drawing.Point(69, 32);
			this.Label12.Name = "Label12";
			this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label12.Size = new System.Drawing.Size(66, 16);
			this.Label12.TabIndex = 45;
			this.Label12.Text = "Port address";
			this.Label12.Click += new System.EventHandler(this.Label12_Click);
			// 
			// Open_Driver
			// 
			this.Open_Driver.BackColor = System.Drawing.SystemColors.Control;
			this.Open_Driver.Cursor = System.Windows.Forms.Cursors.Default;
			this.Open_Driver.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Open_Driver.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Open_Driver.Location = new System.Drawing.Point(384, 160);
			this.Open_Driver.Name = "Open_Driver";
			this.Open_Driver.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Open_Driver.Size = new System.Drawing.Size(104, 32);
			this.Open_Driver.TabIndex = 61;
			this.Open_Driver.Text = "Open Driver";
			this.Open_Driver.Click += new System.EventHandler(this.Open_Driver_Click);
			// 
			// Close_Driver
			// 
			this.Close_Driver.BackColor = System.Drawing.SystemColors.Control;
			this.Close_Driver.Cursor = System.Windows.Forms.Cursors.Default;
			this.Close_Driver.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Close_Driver.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Close_Driver.Location = new System.Drawing.Point(384, 208);
			this.Close_Driver.Name = "Close_Driver";
			this.Close_Driver.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Close_Driver.Size = new System.Drawing.Size(104, 32);
			this.Close_Driver.TabIndex = 60;
			this.Close_Driver.Text = "Close Driver";
			this.Close_Driver.Click += new System.EventHandler(this.Close_Driver_Click);
			// 
			// B_Exit
			// 
			this.B_Exit.BackColor = System.Drawing.SystemColors.Control;
			this.B_Exit.Cursor = System.Windows.Forms.Cursors.Default;
			this.B_Exit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.B_Exit.ForeColor = System.Drawing.SystemColors.ControlText;
			this.B_Exit.Location = new System.Drawing.Point(384, 280);
			this.B_Exit.Name = "B_Exit";
			this.B_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.B_Exit.Size = new System.Drawing.Size(104, 32);
			this.B_Exit.TabIndex = 59;
			this.B_Exit.Text = "Exit";
			this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(371, 92);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(131, 16);
			this.linkLabel2.TabIndex = 80;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "tools@entechtaiwan.com";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(364, 68);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(145, 16);
			this.linkLabel1.TabIndex = 79;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "http://www.RapidDriver.com";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(371, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 16);
			this.label6.TabIndex = 78;
			this.label6.Text = "(c) 2005, EnTech Taiwan";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(404, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 77;
			this.label3.Text = "TVicPort";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.C_WriteSize);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.C_ReadSize);
			this.groupBox1.Controls.Add(this.PortR1);
			this.groupBox1.Controls.Add(this.PortW1);
			this.groupBox1.Controls.Add(this.ValW1);
			this.groupBox1.Controls.Add(this.Label7);
			this.groupBox1.Controls.Add(this.Label9);
			this.groupBox1.Controls.Add(this.Read_Port);
			this.groupBox1.Controls.Add(this.ValR1);
			this.groupBox1.Controls.Add(this.Write_Port);
			this.groupBox1.Location = new System.Drawing.Point(8, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(340, 128);
			this.groupBox1.TabIndex = 81;
			this.groupBox1.TabStop = false;
			// 
			// C_WriteSize
			// 
			this.C_WriteSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.C_WriteSize.Items.AddRange(new object[] {
															 "Byte",
															 "Word",
															 "Long"});
			this.C_WriteSize.Location = new System.Drawing.Point(72, 86);
			this.C_WriteSize.Name = "C_WriteSize";
			this.C_WriteSize.Size = new System.Drawing.Size(56, 21);
			this.C_WriteSize.TabIndex = 87;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(80, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 16);
			this.label1.TabIndex = 86;
			this.label1.Text = "Size:";
			// 
			// C_ReadSize
			// 
			this.C_ReadSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.C_ReadSize.Items.AddRange(new object[] {
															"Byte",
															"Word",
															"Long"});
			this.C_ReadSize.Location = new System.Drawing.Point(72, 46);
			this.C_ReadSize.Name = "C_ReadSize";
			this.C_ReadSize.Size = new System.Drawing.Size(56, 21);
			this.C_ReadSize.TabIndex = 85;
			// 
			// PortR1
			// 
			this.PortR1.AcceptsReturn = true;
			this.PortR1.AutoSize = false;
			this.PortR1.BackColor = System.Drawing.SystemColors.Window;
			this.PortR1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PortR1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.PortR1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.PortR1.Location = new System.Drawing.Point(16, 44);
			this.PortR1.MaxLength = 4;
			this.PortR1.Name = "PortR1";
			this.PortR1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.PortR1.Size = new System.Drawing.Size(44, 24);
			this.PortR1.TabIndex = 83;
			this.PortR1.Text = "0378";
			this.PortR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// PortW1
			// 
			this.PortW1.AcceptsReturn = true;
			this.PortW1.AutoSize = false;
			this.PortW1.BackColor = System.Drawing.SystemColors.Window;
			this.PortW1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PortW1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.PortW1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.PortW1.Location = new System.Drawing.Point(16, 84);
			this.PortW1.MaxLength = 0;
			this.PortW1.Name = "PortW1";
			this.PortW1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.PortW1.Size = new System.Drawing.Size(44, 24);
			this.PortW1.TabIndex = 79;
			this.PortW1.Text = "0378";
			this.PortW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// ValW1
			// 
			this.ValW1.AcceptsReturn = true;
			this.ValW1.AutoSize = false;
			this.ValW1.BackColor = System.Drawing.SystemColors.Window;
			this.ValW1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ValW1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ValW1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.ValW1.Location = new System.Drawing.Point(140, 84);
			this.ValW1.MaxLength = 8;
			this.ValW1.Name = "ValW1";
			this.ValW1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ValW1.Size = new System.Drawing.Size(72, 24);
			this.ValW1.TabIndex = 77;
			this.ValW1.Text = "00000036";
			this.ValW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Label7
			// 
			this.Label7.AutoSize = true;
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.Location = new System.Drawing.Point(12, 20);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(55, 16);
			this.Label7.TabIndex = 81;
			this.Label7.Text = "Addr (hex)";
			// 
			// Label9
			// 
			this.Label9.AutoSize = true;
			this.Label9.BackColor = System.Drawing.SystemColors.Control;
			this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label9.Location = new System.Drawing.Point(148, 20);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label9.Size = new System.Drawing.Size(57, 16);
			this.Label9.TabIndex = 80;
			this.Label9.Text = "Value(hex)";
			// 
			// Read_Port
			// 
			this.Read_Port.BackColor = System.Drawing.SystemColors.Control;
			this.Read_Port.Cursor = System.Windows.Forms.Cursors.Default;
			this.Read_Port.Enabled = false;
			this.Read_Port.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Read_Port.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Read_Port.Location = new System.Drawing.Point(228, 42);
			this.Read_Port.Name = "Read_Port";
			this.Read_Port.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Read_Port.Size = new System.Drawing.Size(96, 28);
			this.Read_Port.TabIndex = 82;
			this.Read_Port.Text = "Read port";
			this.Read_Port.Click += new System.EventHandler(this.Read_Port_Click);
			// 
			// ValR1
			// 
			this.ValR1.BackColor = System.Drawing.SystemColors.Control;
			this.ValR1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ValR1.Cursor = System.Windows.Forms.Cursors.Default;
			this.ValR1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ValR1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ValR1.Location = new System.Drawing.Point(140, 44);
			this.ValR1.Name = "ValR1";
			this.ValR1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ValR1.Size = new System.Drawing.Size(72, 24);
			this.ValR1.TabIndex = 84;
			this.ValR1.Text = "00000000";
			this.ValR1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Write_Port
			// 
			this.Write_Port.BackColor = System.Drawing.SystemColors.Control;
			this.Write_Port.Cursor = System.Windows.Forms.Cursors.Default;
			this.Write_Port.Enabled = false;
			this.Write_Port.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Write_Port.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Write_Port.Location = new System.Drawing.Point(228, 82);
			this.Write_Port.Name = "Write_Port";
			this.Write_Port.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Write_Port.Size = new System.Drawing.Size(96, 28);
			this.Write_Port.TabIndex = 78;
			this.Write_Port.Text = "Write port";
			this.Write_Port.Click += new System.EventHandler(this.Write_Port_Click);
			// 
			// L_Days
			// 
			this.L_Days.Location = new System.Drawing.Point(360, 120);
			this.L_Days.Name = "L_Days";
			this.L_Days.Size = new System.Drawing.Size(148, 16);
			this.L_Days.TabIndex = 82;
			this.L_Days.Text = "Evaluation Days Left: ??";
			this.L_Days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PortForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 325);
			this.Controls.Add(this.L_Days);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Frame4);
			this.Controls.Add(this.Open_Driver);
			this.Controls.Add(this.Close_Driver);
			this.Controls.Add(this.B_Exit);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PortForm";
			this.Text = "Port I/O Sample Application";
			this.Load += new System.EventHandler(this.PortForm_Load);
			this.Closed += new System.EventHandler(this.PortForm_Closed);
			this.Frame4.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new PortForm());
		}	

		private void LockControls()
		{
			Open_Driver.Enabled = !DriverOpened;
			Close_Driver.Enabled = DriverOpened;
			Read_Port.Enabled = DriverOpened;
			Write_Port.Enabled = DriverOpened;
			B_Test.Enabled = DriverOpened;
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

		private void PortForm_Closed(object sender, System.EventArgs e)
		{
			TVicPort.CloseTVicPort();
		}

		
		private void Read_Port_Click(object sender, System.EventArgs e)
		{

			ushort PortAddr;
			PortAddr = ushort.Parse(PortR1.Text,NumberStyles.HexNumber);
			PortR1.Text = PortAddr.ToString("X4");
			switch (C_ReadSize.SelectedIndex)
			{
				case 0:	ValR1.Text =  (TVicPort.ReadPort(PortAddr)).ToString("X2"); break;
				case 1:	ValR1.Text =  (TVicPort.ReadPortW(PortAddr)).ToString("X4"); break;
				case 2:	ValR1.Text =  (TVicPort.ReadPortL(PortAddr)).ToString("X8"); break;
			}
		}

		private void Write_Port_Click(object sender, System.EventArgs e)
		{
			ushort PortAddr;
			uint lVal;
			byte   bVal;
			ushort wVal;
			PortAddr = ushort.Parse(PortW1.Text,NumberStyles.HexNumber);
			PortW1.Text = PortAddr.ToString("X4");
			switch (C_WriteSize.SelectedIndex)
			{
				case 0:	
					bVal = byte.Parse(ValW1.Text,NumberStyles.HexNumber);
					TVicPort.WritePort(PortAddr,bVal); 
					break;
				case 1:	
					wVal = ushort.Parse(ValW1.Text,NumberStyles.HexNumber);
					TVicPort.WritePortW(PortAddr, wVal); 
					break;
				case 2:	
					lVal = uint.Parse(ValW1.Text,NumberStyles.HexNumber);
					TVicPort.WritePortL(PortAddr,lVal); break;
			}
		}

		private void B_Test_Click(object sender, System.EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			ushort Cycle, NumPortCycles;
			ushort PortAddr;
			
			byte   DataByte;
			double a,b,r;
						
			PortAddr = ushort.Parse(EPortAddr.Text,NumberStyles.HexNumber);
			NumPortCycles = ushort.Parse(E_Cycles.Text,NumberStyles.Integer);
			byte[] buffer = new byte[NumPortCycles];
	
			// Separate I/O operations

			a = DateTime.Now.Ticks;
			for (Cycle = 1; Cycle<=NumPortCycles; Cycle++) 
				DataByte = TVicPort.ReadPort(PortAddr);
			b = DateTime.Now.Ticks;

            r = System.Math.Abs(b-a)/(10*NumPortCycles);
			L_Test1.Text = String.Concat(r.ToString("F4")," microsec");		
			
			// with ReadPortBuffer() 
            
            a = DateTime.Now.Ticks;

			// Declare an unsafe block
			unsafe
			{
				// Fix the byte array.
				fixed (byte *array = buffer)
				{
					// Make the call here, passing in the array.
					TVicPort.ReadPortFIFO(PortAddr,NumPortCycles,array);
				}
			}
            b = DateTime.Now.Ticks;			
			r = System.Math.Abs(b-a)/(10*NumPortCycles);
			L_Test4.Text = String.Concat(r.ToString("F4")," microsec");

			Cursor = Cursors.Default;
			
		}

		private void PortForm_Load(object sender, System.EventArgs e)
		{
			DriverOpened = false;
			C_ReadSize.SelectedIndex = 0;
			C_WriteSize.SelectedIndex = 0;
			LockControls();
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("mailto:RapidDriver%20Support%20<"+linkLabel2.Text+">?subject=RapidDriver");
		}

		private void EPortAddr_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void Label12_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label3_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label6_Click(object sender, System.EventArgs e)
		{
		
		}

		private void linkLabel1_LinkClicked_1(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
		
		}


	}
}
