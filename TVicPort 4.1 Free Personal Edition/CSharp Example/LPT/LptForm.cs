using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using TVicPort_Cs;

namespace LptApp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class LptForm : System.Windows.Forms.Form
	{
		bool DriverOpened = false;
	
		public System.Windows.Forms.GroupBox Frame6;
		public System.Windows.Forms.CheckBox C_ERROR;
		public System.Windows.Forms.CheckBox C_SLCT;
		public System.Windows.Forms.CheckBox C_PE;
		public System.Windows.Forms.CheckBox C_BUSY;
		public System.Windows.Forms.CheckBox C_ACKWL;
		public System.Windows.Forms.GroupBox Frame4;
		public System.Windows.Forms.CheckBox RCheck1;
		public System.Windows.Forms.CheckBox RCheck2;
		public System.Windows.Forms.CheckBox RCheck3;
		public System.Windows.Forms.CheckBox RCheck4;
		public System.Windows.Forms.CheckBox RCheck5;
		public System.Windows.Forms.CheckBox RCheck6;
		public System.Windows.Forms.CheckBox RCheck7;
		public System.Windows.Forms.CheckBox RCheck14;
		public System.Windows.Forms.CheckBox RCheck15;
		public System.Windows.Forms.CheckBox RCheck25;
		public System.Windows.Forms.CheckBox RCheck24;
		public System.Windows.Forms.CheckBox RCheck23;
		public System.Windows.Forms.CheckBox RCheck22;
		public System.Windows.Forms.CheckBox RCheck21;
		public System.Windows.Forms.CheckBox RCheck20;
		public System.Windows.Forms.CheckBox RCheck19;
		public System.Windows.Forms.CheckBox RCheck18;
		public System.Windows.Forms.CheckBox RCheck17;
		public System.Windows.Forms.CheckBox RCheck16;
		public System.Windows.Forms.CheckBox RCheck13;
		public System.Windows.Forms.CheckBox RCheck12;
		public System.Windows.Forms.CheckBox RCheck11;
		public System.Windows.Forms.CheckBox RCheck10;
		public System.Windows.Forms.CheckBox RCheck9;
		public System.Windows.Forms.CheckBox RCheck8;
		public System.Windows.Forms.Label _Label2_0;
		public System.Windows.Forms.Label _Label1_0;
		public System.Windows.Forms.GroupBox Frame5;
		public System.Windows.Forms.CheckBox WCheck25;
		public System.Windows.Forms.CheckBox WCheck24;
		public System.Windows.Forms.CheckBox WCheck23;
		public System.Windows.Forms.CheckBox WCheck22;
		public System.Windows.Forms.CheckBox WCheck21;
		public System.Windows.Forms.CheckBox WCheck20;
		public System.Windows.Forms.CheckBox WCheck19;
		public System.Windows.Forms.CheckBox WCheck18;
		public System.Windows.Forms.CheckBox WCheck17;
		public System.Windows.Forms.CheckBox WCheck16;
		public System.Windows.Forms.CheckBox WCheck15;
		public System.Windows.Forms.CheckBox WCheck14;
		public System.Windows.Forms.CheckBox WCheck13;
		public System.Windows.Forms.CheckBox WCheck12;
		public System.Windows.Forms.CheckBox WCheck11;
		public System.Windows.Forms.CheckBox WCheck10;
		public System.Windows.Forms.CheckBox WCheck9;
		public System.Windows.Forms.CheckBox WCheck8;
		public System.Windows.Forms.CheckBox WCheck7;
		public System.Windows.Forms.CheckBox WCheck6;
		public System.Windows.Forms.CheckBox WCheck5;
		public System.Windows.Forms.CheckBox WCheck4;
		public System.Windows.Forms.CheckBox WCheck3;
		public System.Windows.Forms.CheckBox WCheck2;
		public System.Windows.Forms.CheckBox WCheck1;
		public System.Windows.Forms.Label _Label4_1;
		public System.Windows.Forms.Label _Label3_1;
		public System.Windows.Forms.Button Close_Driver;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.Label _Label3_0;
		public System.Windows.Forms.Label _Label4_0;
		public System.Windows.Forms.Label Label5;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button Open_Driver;
		private System.Windows.Forms.NumericUpDown N_Lpt;
		public System.Windows.Forms.Label Label12;
		public System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label L_Days;
		private System.ComponentModel.IContainer components;

		public LptForm()
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
			this.components = new System.ComponentModel.Container();
			this.Frame6 = new System.Windows.Forms.GroupBox();
			this.C_ERROR = new System.Windows.Forms.CheckBox();
			this.C_SLCT = new System.Windows.Forms.CheckBox();
			this.C_PE = new System.Windows.Forms.CheckBox();
			this.C_BUSY = new System.Windows.Forms.CheckBox();
			this.C_ACKWL = new System.Windows.Forms.CheckBox();
			this.Frame4 = new System.Windows.Forms.GroupBox();
			this.RCheck1 = new System.Windows.Forms.CheckBox();
			this.RCheck2 = new System.Windows.Forms.CheckBox();
			this.RCheck3 = new System.Windows.Forms.CheckBox();
			this.RCheck4 = new System.Windows.Forms.CheckBox();
			this.RCheck5 = new System.Windows.Forms.CheckBox();
			this.RCheck6 = new System.Windows.Forms.CheckBox();
			this.RCheck7 = new System.Windows.Forms.CheckBox();
			this.RCheck14 = new System.Windows.Forms.CheckBox();
			this.RCheck15 = new System.Windows.Forms.CheckBox();
			this.RCheck25 = new System.Windows.Forms.CheckBox();
			this.RCheck24 = new System.Windows.Forms.CheckBox();
			this.RCheck23 = new System.Windows.Forms.CheckBox();
			this.RCheck22 = new System.Windows.Forms.CheckBox();
			this.RCheck21 = new System.Windows.Forms.CheckBox();
			this.RCheck20 = new System.Windows.Forms.CheckBox();
			this.RCheck19 = new System.Windows.Forms.CheckBox();
			this.RCheck18 = new System.Windows.Forms.CheckBox();
			this.RCheck17 = new System.Windows.Forms.CheckBox();
			this.RCheck16 = new System.Windows.Forms.CheckBox();
			this.RCheck13 = new System.Windows.Forms.CheckBox();
			this.RCheck12 = new System.Windows.Forms.CheckBox();
			this.RCheck11 = new System.Windows.Forms.CheckBox();
			this.RCheck10 = new System.Windows.Forms.CheckBox();
			this.RCheck9 = new System.Windows.Forms.CheckBox();
			this.RCheck8 = new System.Windows.Forms.CheckBox();
			this._Label2_0 = new System.Windows.Forms.Label();
			this._Label1_0 = new System.Windows.Forms.Label();
			this.Frame5 = new System.Windows.Forms.GroupBox();
			this.WCheck25 = new System.Windows.Forms.CheckBox();
			this.WCheck24 = new System.Windows.Forms.CheckBox();
			this.WCheck23 = new System.Windows.Forms.CheckBox();
			this.WCheck22 = new System.Windows.Forms.CheckBox();
			this.WCheck21 = new System.Windows.Forms.CheckBox();
			this.WCheck20 = new System.Windows.Forms.CheckBox();
			this.WCheck19 = new System.Windows.Forms.CheckBox();
			this.WCheck18 = new System.Windows.Forms.CheckBox();
			this.WCheck17 = new System.Windows.Forms.CheckBox();
			this.WCheck16 = new System.Windows.Forms.CheckBox();
			this.WCheck15 = new System.Windows.Forms.CheckBox();
			this.WCheck14 = new System.Windows.Forms.CheckBox();
			this.WCheck13 = new System.Windows.Forms.CheckBox();
			this.WCheck12 = new System.Windows.Forms.CheckBox();
			this.WCheck11 = new System.Windows.Forms.CheckBox();
			this.WCheck10 = new System.Windows.Forms.CheckBox();
			this.WCheck9 = new System.Windows.Forms.CheckBox();
			this.WCheck8 = new System.Windows.Forms.CheckBox();
			this.WCheck7 = new System.Windows.Forms.CheckBox();
			this.WCheck6 = new System.Windows.Forms.CheckBox();
			this.WCheck5 = new System.Windows.Forms.CheckBox();
			this.WCheck4 = new System.Windows.Forms.CheckBox();
			this.WCheck3 = new System.Windows.Forms.CheckBox();
			this.WCheck2 = new System.Windows.Forms.CheckBox();
			this.WCheck1 = new System.Windows.Forms.CheckBox();
			this._Label4_1 = new System.Windows.Forms.Label();
			this._Label3_1 = new System.Windows.Forms.Label();
			this.Close_Driver = new System.Windows.Forms.Button();
			this.Command1 = new System.Windows.Forms.Button();
			this._Label3_0 = new System.Windows.Forms.Label();
			this._Label4_0 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.Open_Driver = new System.Windows.Forms.Button();
			this.N_Lpt = new System.Windows.Forms.NumericUpDown();
			this.Label12 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.L_Days = new System.Windows.Forms.Label();
			this.Frame6.SuspendLayout();
			this.Frame4.SuspendLayout();
			this.Frame5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.N_Lpt)).BeginInit();
			this.SuspendLayout();
			// 
			// Frame6
			// 
			this.Frame6.BackColor = System.Drawing.SystemColors.Control;
			this.Frame6.Controls.Add(this.C_ERROR);
			this.Frame6.Controls.Add(this.C_SLCT);
			this.Frame6.Controls.Add(this.C_PE);
			this.Frame6.Controls.Add(this.C_BUSY);
			this.Frame6.Controls.Add(this.C_ACKWL);
			this.Frame6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Frame6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame6.Location = new System.Drawing.Point(8, 8);
			this.Frame6.Name = "Frame6";
			this.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame6.Size = new System.Drawing.Size(109, 121);
			this.Frame6.TabIndex = 79;
			this.Frame6.TabStop = false;
			this.Frame6.Text = " LPT status ";
			// 
			// C_ERROR
			// 
			this.C_ERROR.BackColor = System.Drawing.SystemColors.Control;
			this.C_ERROR.Cursor = System.Windows.Forms.Cursors.Default;
			this.C_ERROR.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.C_ERROR.ForeColor = System.Drawing.SystemColors.ControlText;
			this.C_ERROR.Location = new System.Drawing.Point(12, 96);
			this.C_ERROR.Name = "C_ERROR";
			this.C_ERROR.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.C_ERROR.Size = new System.Drawing.Size(69, 21);
			this.C_ERROR.TabIndex = 61;
			this.C_ERROR.Text = "_ERROR";
			// 
			// C_SLCT
			// 
			this.C_SLCT.BackColor = System.Drawing.SystemColors.Control;
			this.C_SLCT.Cursor = System.Windows.Forms.Cursors.Default;
			this.C_SLCT.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.C_SLCT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.C_SLCT.Location = new System.Drawing.Point(12, 76);
			this.C_SLCT.Name = "C_SLCT";
			this.C_SLCT.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.C_SLCT.Size = new System.Drawing.Size(61, 21);
			this.C_SLCT.TabIndex = 60;
			this.C_SLCT.Text = "SLCT";
			// 
			// C_PE
			// 
			this.C_PE.BackColor = System.Drawing.SystemColors.Control;
			this.C_PE.Cursor = System.Windows.Forms.Cursors.Default;
			this.C_PE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.C_PE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.C_PE.Location = new System.Drawing.Point(12, 56);
			this.C_PE.Name = "C_PE";
			this.C_PE.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.C_PE.Size = new System.Drawing.Size(61, 17);
			this.C_PE.TabIndex = 59;
			this.C_PE.Text = "PE";
			// 
			// C_BUSY
			// 
			this.C_BUSY.BackColor = System.Drawing.SystemColors.Control;
			this.C_BUSY.Cursor = System.Windows.Forms.Cursors.Default;
			this.C_BUSY.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.C_BUSY.ForeColor = System.Drawing.SystemColors.ControlText;
			this.C_BUSY.Location = new System.Drawing.Point(12, 36);
			this.C_BUSY.Name = "C_BUSY";
			this.C_BUSY.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.C_BUSY.Size = new System.Drawing.Size(65, 17);
			this.C_BUSY.TabIndex = 58;
			this.C_BUSY.Text = "BUSY";
			// 
			// C_ACKWL
			// 
			this.C_ACKWL.BackColor = System.Drawing.SystemColors.Control;
			this.C_ACKWL.Cursor = System.Windows.Forms.Cursors.Default;
			this.C_ACKWL.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.C_ACKWL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.C_ACKWL.Location = new System.Drawing.Point(12, 16);
			this.C_ACKWL.Name = "C_ACKWL";
			this.C_ACKWL.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.C_ACKWL.Size = new System.Drawing.Size(65, 17);
			this.C_ACKWL.TabIndex = 57;
			this.C_ACKWL.Text = "_ACKWL";
			// 
			// Frame4
			// 
			this.Frame4.BackColor = System.Drawing.SystemColors.Control;
			this.Frame4.Controls.Add(this.RCheck1);
			this.Frame4.Controls.Add(this.RCheck2);
			this.Frame4.Controls.Add(this.RCheck3);
			this.Frame4.Controls.Add(this.RCheck4);
			this.Frame4.Controls.Add(this.RCheck5);
			this.Frame4.Controls.Add(this.RCheck6);
			this.Frame4.Controls.Add(this.RCheck7);
			this.Frame4.Controls.Add(this.RCheck14);
			this.Frame4.Controls.Add(this.RCheck15);
			this.Frame4.Controls.Add(this.RCheck25);
			this.Frame4.Controls.Add(this.RCheck24);
			this.Frame4.Controls.Add(this.RCheck23);
			this.Frame4.Controls.Add(this.RCheck22);
			this.Frame4.Controls.Add(this.RCheck21);
			this.Frame4.Controls.Add(this.RCheck20);
			this.Frame4.Controls.Add(this.RCheck19);
			this.Frame4.Controls.Add(this.RCheck18);
			this.Frame4.Controls.Add(this.RCheck17);
			this.Frame4.Controls.Add(this.RCheck16);
			this.Frame4.Controls.Add(this.RCheck13);
			this.Frame4.Controls.Add(this.RCheck12);
			this.Frame4.Controls.Add(this.RCheck11);
			this.Frame4.Controls.Add(this.RCheck10);
			this.Frame4.Controls.Add(this.RCheck9);
			this.Frame4.Controls.Add(this.RCheck8);
			this.Frame4.Controls.Add(this._Label2_0);
			this.Frame4.Controls.Add(this._Label1_0);
			this.Frame4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Frame4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame4.Location = new System.Drawing.Point(8, 136);
			this.Frame4.Name = "Frame4";
			this.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame4.Size = new System.Drawing.Size(317, 101);
			this.Frame4.TabIndex = 78;
			this.Frame4.TabStop = false;
			this.Frame4.Text = " Read pins by timer";
			// 
			// RCheck1
			// 
			this.RCheck1.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck1.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck1.Location = new System.Drawing.Point(12, 32);
			this.RCheck1.Name = "RCheck1";
			this.RCheck1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck1.Size = new System.Drawing.Size(13, 13);
			this.RCheck1.TabIndex = 53;
			this.RCheck1.Tag = "1";
			this.RCheck1.Text = "Check1";
			// 
			// RCheck2
			// 
			this.RCheck2.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck2.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck2.Location = new System.Drawing.Point(34, 32);
			this.RCheck2.Name = "RCheck2";
			this.RCheck2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck2.Size = new System.Drawing.Size(13, 13);
			this.RCheck2.TabIndex = 52;
			this.RCheck2.Tag = "2";
			this.RCheck2.Text = "Check2";
			// 
			// RCheck3
			// 
			this.RCheck3.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck3.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck3.Location = new System.Drawing.Point(55, 32);
			this.RCheck3.Name = "RCheck3";
			this.RCheck3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck3.Size = new System.Drawing.Size(13, 13);
			this.RCheck3.TabIndex = 51;
			this.RCheck3.Tag = "3";
			this.RCheck3.Text = "Check3";
			// 
			// RCheck4
			// 
			this.RCheck4.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck4.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck4.Location = new System.Drawing.Point(77, 32);
			this.RCheck4.Name = "RCheck4";
			this.RCheck4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck4.Size = new System.Drawing.Size(13, 13);
			this.RCheck4.TabIndex = 50;
			this.RCheck4.Tag = "4";
			this.RCheck4.Text = "Check4";
			// 
			// RCheck5
			// 
			this.RCheck5.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck5.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck5.Location = new System.Drawing.Point(99, 32);
			this.RCheck5.Name = "RCheck5";
			this.RCheck5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck5.Size = new System.Drawing.Size(13, 13);
			this.RCheck5.TabIndex = 49;
			this.RCheck5.Tag = "5";
			this.RCheck5.Text = "Check5";
			// 
			// RCheck6
			// 
			this.RCheck6.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck6.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck6.Location = new System.Drawing.Point(120, 32);
			this.RCheck6.Name = "RCheck6";
			this.RCheck6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck6.Size = new System.Drawing.Size(13, 13);
			this.RCheck6.TabIndex = 48;
			this.RCheck6.Tag = "6";
			this.RCheck6.Text = "Check6";
			// 
			// RCheck7
			// 
			this.RCheck7.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck7.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck7.Location = new System.Drawing.Point(142, 32);
			this.RCheck7.Name = "RCheck7";
			this.RCheck7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck7.Size = new System.Drawing.Size(13, 13);
			this.RCheck7.TabIndex = 47;
			this.RCheck7.Tag = "7";
			this.RCheck7.Text = "Check7";
			// 
			// RCheck14
			// 
			this.RCheck14.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck14.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck14.Location = new System.Drawing.Point(24, 56);
			this.RCheck14.Name = "RCheck14";
			this.RCheck14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck14.Size = new System.Drawing.Size(17, 13);
			this.RCheck14.TabIndex = 46;
			this.RCheck14.Tag = "14";
			this.RCheck14.Text = "Check14";
			// 
			// RCheck15
			// 
			this.RCheck15.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck15.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck15.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck15.Location = new System.Drawing.Point(46, 56);
			this.RCheck15.Name = "RCheck15";
			this.RCheck15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck15.Size = new System.Drawing.Size(17, 13);
			this.RCheck15.TabIndex = 45;
			this.RCheck15.Tag = "15";
			this.RCheck15.Text = "Check15";
			// 
			// RCheck25
			// 
			this.RCheck25.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck25.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck25.Enabled = false;
			this.RCheck25.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck25.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck25.Location = new System.Drawing.Point(260, 56);
			this.RCheck25.Name = "RCheck25";
			this.RCheck25.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck25.Size = new System.Drawing.Size(17, 13);
			this.RCheck25.TabIndex = 44;
			this.RCheck25.Tag = "25";
			// 
			// RCheck24
			// 
			this.RCheck24.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck24.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck24.Enabled = false;
			this.RCheck24.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck24.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck24.Location = new System.Drawing.Point(239, 56);
			this.RCheck24.Name = "RCheck24";
			this.RCheck24.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck24.Size = new System.Drawing.Size(17, 13);
			this.RCheck24.TabIndex = 43;
			this.RCheck24.Tag = "24";
			// 
			// RCheck23
			// 
			this.RCheck23.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck23.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck23.Enabled = false;
			this.RCheck23.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck23.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck23.Location = new System.Drawing.Point(218, 56);
			this.RCheck23.Name = "RCheck23";
			this.RCheck23.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck23.Size = new System.Drawing.Size(17, 13);
			this.RCheck23.TabIndex = 42;
			this.RCheck23.Tag = "23";
			// 
			// RCheck22
			// 
			this.RCheck22.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck22.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck22.Enabled = false;
			this.RCheck22.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck22.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck22.Location = new System.Drawing.Point(196, 56);
			this.RCheck22.Name = "RCheck22";
			this.RCheck22.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck22.Size = new System.Drawing.Size(17, 13);
			this.RCheck22.TabIndex = 41;
			this.RCheck22.Tag = "22";
			// 
			// RCheck21
			// 
			this.RCheck21.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck21.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck21.Enabled = false;
			this.RCheck21.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck21.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck21.Location = new System.Drawing.Point(176, 56);
			this.RCheck21.Name = "RCheck21";
			this.RCheck21.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck21.Size = new System.Drawing.Size(17, 13);
			this.RCheck21.TabIndex = 40;
			this.RCheck21.Tag = "21";
			this.RCheck21.Text = "Check21";
			// 
			// RCheck20
			// 
			this.RCheck20.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck20.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck20.Enabled = false;
			this.RCheck20.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck20.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck20.Location = new System.Drawing.Point(153, 56);
			this.RCheck20.Name = "RCheck20";
			this.RCheck20.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck20.Size = new System.Drawing.Size(17, 13);
			this.RCheck20.TabIndex = 39;
			this.RCheck20.Tag = "20";
			this.RCheck20.Text = "Check20";
			// 
			// RCheck19
			// 
			this.RCheck19.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck19.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck19.Enabled = false;
			this.RCheck19.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck19.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck19.Location = new System.Drawing.Point(132, 56);
			this.RCheck19.Name = "RCheck19";
			this.RCheck19.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck19.Size = new System.Drawing.Size(17, 13);
			this.RCheck19.TabIndex = 38;
			this.RCheck19.Tag = "19";
			this.RCheck19.Text = "Check19";
			// 
			// RCheck18
			// 
			this.RCheck18.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck18.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck18.Enabled = false;
			this.RCheck18.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck18.Location = new System.Drawing.Point(112, 56);
			this.RCheck18.Name = "RCheck18";
			this.RCheck18.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck18.Size = new System.Drawing.Size(17, 13);
			this.RCheck18.TabIndex = 37;
			this.RCheck18.Tag = "18";
			this.RCheck18.Text = "Check18";
			// 
			// RCheck17
			// 
			this.RCheck17.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck17.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck17.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck17.Location = new System.Drawing.Point(89, 56);
			this.RCheck17.Name = "RCheck17";
			this.RCheck17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck17.Size = new System.Drawing.Size(17, 13);
			this.RCheck17.TabIndex = 36;
			this.RCheck17.Tag = "17";
			this.RCheck17.Text = "Check17";
			// 
			// RCheck16
			// 
			this.RCheck16.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck16.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck16.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck16.Location = new System.Drawing.Point(67, 56);
			this.RCheck16.Name = "RCheck16";
			this.RCheck16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck16.Size = new System.Drawing.Size(17, 13);
			this.RCheck16.TabIndex = 35;
			this.RCheck16.Tag = "16";
			this.RCheck16.Text = "Check16";
			// 
			// RCheck13
			// 
			this.RCheck13.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck13.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck13.Location = new System.Drawing.Point(272, 32);
			this.RCheck13.Name = "RCheck13";
			this.RCheck13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck13.Size = new System.Drawing.Size(13, 13);
			this.RCheck13.TabIndex = 34;
			this.RCheck13.Tag = "13";
			this.RCheck13.Text = "Check13";
			// 
			// RCheck12
			// 
			this.RCheck12.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck12.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck12.Location = new System.Drawing.Point(250, 32);
			this.RCheck12.Name = "RCheck12";
			this.RCheck12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck12.Size = new System.Drawing.Size(13, 13);
			this.RCheck12.TabIndex = 33;
			this.RCheck12.Tag = "12";
			this.RCheck12.Text = "Check12";
			// 
			// RCheck11
			// 
			this.RCheck11.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck11.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck11.Location = new System.Drawing.Point(229, 32);
			this.RCheck11.Name = "RCheck11";
			this.RCheck11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck11.Size = new System.Drawing.Size(13, 13);
			this.RCheck11.TabIndex = 32;
			this.RCheck11.Tag = "11";
			this.RCheck11.Text = "Check11";
			// 
			// RCheck10
			// 
			this.RCheck10.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck10.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck10.Location = new System.Drawing.Point(207, 32);
			this.RCheck10.Name = "RCheck10";
			this.RCheck10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck10.Size = new System.Drawing.Size(13, 13);
			this.RCheck10.TabIndex = 31;
			this.RCheck10.Tag = "10";
			this.RCheck10.Text = "Check10";
			// 
			// RCheck9
			// 
			this.RCheck9.BackColor = System.Drawing.SystemColors.Control;
			this.RCheck9.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck9.Location = new System.Drawing.Point(185, 32);
			this.RCheck9.Name = "RCheck9";
			this.RCheck9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck9.Size = new System.Drawing.Size(13, 13);
			this.RCheck9.TabIndex = 30;
			this.RCheck9.Tag = "9";
			this.RCheck9.Text = "Check9";
			// 
			// RCheck8
			// 
			this.RCheck8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.RCheck8.Cursor = System.Windows.Forms.Cursors.Default;
			this.RCheck8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RCheck8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RCheck8.Location = new System.Drawing.Point(164, 32);
			this.RCheck8.Name = "RCheck8";
			this.RCheck8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RCheck8.Size = new System.Drawing.Size(13, 13);
			this.RCheck8.TabIndex = 29;
			this.RCheck8.Tag = "8";
			this.RCheck8.Text = "Check8";
			// 
			// _Label2_0
			// 
			this._Label2_0.BackColor = System.Drawing.SystemColors.Control;
			this._Label2_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label2_0.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label2_0.Location = new System.Drawing.Point(24, 76);
			this._Label2_0.Name = "_Label2_0";
			this._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label2_0.Size = new System.Drawing.Size(269, 17);
			this._Label2_0.TabIndex = 55;
			this._Label2_0.Text = "14   15   16    17   18   19   20    21   22   23   24   25";
			// 
			// _Label1_0
			// 
			this._Label1_0.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_0.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_0.Location = new System.Drawing.Point(16, 16);
			this._Label1_0.Name = "_Label1_0";
			this._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_0.Size = new System.Drawing.Size(277, 13);
			this._Label1_0.TabIndex = 54;
			this._Label1_0.Text = "1     2     3     4      5     6     7     8     9     10   11   12   13 ";
			// 
			// Frame5
			// 
			this.Frame5.BackColor = System.Drawing.SystemColors.Control;
			this.Frame5.Controls.Add(this.WCheck25);
			this.Frame5.Controls.Add(this.WCheck24);
			this.Frame5.Controls.Add(this.WCheck23);
			this.Frame5.Controls.Add(this.WCheck22);
			this.Frame5.Controls.Add(this.WCheck21);
			this.Frame5.Controls.Add(this.WCheck20);
			this.Frame5.Controls.Add(this.WCheck19);
			this.Frame5.Controls.Add(this.WCheck18);
			this.Frame5.Controls.Add(this.WCheck17);
			this.Frame5.Controls.Add(this.WCheck16);
			this.Frame5.Controls.Add(this.WCheck15);
			this.Frame5.Controls.Add(this.WCheck14);
			this.Frame5.Controls.Add(this.WCheck13);
			this.Frame5.Controls.Add(this.WCheck12);
			this.Frame5.Controls.Add(this.WCheck11);
			this.Frame5.Controls.Add(this.WCheck10);
			this.Frame5.Controls.Add(this.WCheck9);
			this.Frame5.Controls.Add(this.WCheck8);
			this.Frame5.Controls.Add(this.WCheck7);
			this.Frame5.Controls.Add(this.WCheck6);
			this.Frame5.Controls.Add(this.WCheck5);
			this.Frame5.Controls.Add(this.WCheck4);
			this.Frame5.Controls.Add(this.WCheck3);
			this.Frame5.Controls.Add(this.WCheck2);
			this.Frame5.Controls.Add(this.WCheck1);
			this.Frame5.Controls.Add(this._Label4_1);
			this.Frame5.Controls.Add(this._Label3_1);
			this.Frame5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Frame5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame5.Location = new System.Drawing.Point(8, 240);
			this.Frame5.Name = "Frame5";
			this.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame5.Size = new System.Drawing.Size(317, 101);
			this.Frame5.TabIndex = 77;
			this.Frame5.TabStop = false;
			this.Frame5.Text = "Write pins manually";
			// 
			// WCheck25
			// 
			this.WCheck25.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck25.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck25.Enabled = false;
			this.WCheck25.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck25.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck25.Location = new System.Drawing.Point(264, 56);
			this.WCheck25.Name = "WCheck25";
			this.WCheck25.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck25.Size = new System.Drawing.Size(17, 13);
			this.WCheck25.TabIndex = 25;
			this.WCheck25.Tag = "25";
			this.WCheck25.Text = "Check50";
			this.WCheck25.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck24
			// 
			this.WCheck24.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck24.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck24.Enabled = false;
			this.WCheck24.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck24.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck24.Location = new System.Drawing.Point(244, 56);
			this.WCheck24.Name = "WCheck24";
			this.WCheck24.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck24.Size = new System.Drawing.Size(17, 13);
			this.WCheck24.TabIndex = 24;
			this.WCheck24.Tag = "24";
			this.WCheck24.Text = "Check49";
			this.WCheck24.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck23
			// 
			this.WCheck23.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck23.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck23.Enabled = false;
			this.WCheck23.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck23.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck23.Location = new System.Drawing.Point(221, 56);
			this.WCheck23.Name = "WCheck23";
			this.WCheck23.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck23.Size = new System.Drawing.Size(17, 13);
			this.WCheck23.TabIndex = 23;
			this.WCheck23.Tag = "23";
			this.WCheck23.Text = "Check48";
			this.WCheck23.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck22
			// 
			this.WCheck22.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck22.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck22.Enabled = false;
			this.WCheck22.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck22.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck22.Location = new System.Drawing.Point(200, 56);
			this.WCheck22.Name = "WCheck22";
			this.WCheck22.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck22.Size = new System.Drawing.Size(17, 13);
			this.WCheck22.TabIndex = 22;
			this.WCheck22.Tag = "22";
			this.WCheck22.Text = "Check47";
			this.WCheck22.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck21
			// 
			this.WCheck21.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck21.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck21.Enabled = false;
			this.WCheck21.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck21.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck21.Location = new System.Drawing.Point(178, 56);
			this.WCheck21.Name = "WCheck21";
			this.WCheck21.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck21.Size = new System.Drawing.Size(17, 13);
			this.WCheck21.TabIndex = 21;
			this.WCheck21.Tag = "21";
			this.WCheck21.Text = "Check46";
			this.WCheck21.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck20
			// 
			this.WCheck20.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck20.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck20.Enabled = false;
			this.WCheck20.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck20.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck20.Location = new System.Drawing.Point(156, 56);
			this.WCheck20.Name = "WCheck20";
			this.WCheck20.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck20.Size = new System.Drawing.Size(17, 13);
			this.WCheck20.TabIndex = 20;
			this.WCheck20.Tag = "20";
			this.WCheck20.Text = "Check45";
			this.WCheck20.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck19
			// 
			this.WCheck19.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck19.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck19.Enabled = false;
			this.WCheck19.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck19.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck19.Location = new System.Drawing.Point(135, 56);
			this.WCheck19.Name = "WCheck19";
			this.WCheck19.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck19.Size = new System.Drawing.Size(17, 13);
			this.WCheck19.TabIndex = 19;
			this.WCheck19.Tag = "19";
			this.WCheck19.Text = "Check44";
			this.WCheck19.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck18
			// 
			this.WCheck18.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck18.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck18.Enabled = false;
			this.WCheck18.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck18.Location = new System.Drawing.Point(114, 56);
			this.WCheck18.Name = "WCheck18";
			this.WCheck18.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck18.Size = new System.Drawing.Size(17, 13);
			this.WCheck18.TabIndex = 18;
			this.WCheck18.Tag = "18";
			this.WCheck18.Text = "Check43";
			this.WCheck18.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck17
			// 
			this.WCheck17.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck17.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck17.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck17.Location = new System.Drawing.Point(92, 56);
			this.WCheck17.Name = "WCheck17";
			this.WCheck17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck17.Size = new System.Drawing.Size(17, 13);
			this.WCheck17.TabIndex = 17;
			this.WCheck17.Tag = "17";
			this.WCheck17.Text = "Check42";
			this.WCheck17.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck16
			// 
			this.WCheck16.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck16.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck16.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck16.Location = new System.Drawing.Point(71, 56);
			this.WCheck16.Name = "WCheck16";
			this.WCheck16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck16.Size = new System.Drawing.Size(17, 13);
			this.WCheck16.TabIndex = 16;
			this.WCheck16.Tag = "16";
			this.WCheck16.Text = "Check41";
			this.WCheck16.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck15
			// 
			this.WCheck15.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck15.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck15.Enabled = false;
			this.WCheck15.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck15.Location = new System.Drawing.Point(49, 56);
			this.WCheck15.Name = "WCheck15";
			this.WCheck15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck15.Size = new System.Drawing.Size(17, 13);
			this.WCheck15.TabIndex = 15;
			this.WCheck15.Tag = "15";
			this.WCheck15.Text = "Check40";
			this.WCheck15.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			this.WCheck15.Enter += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck14
			// 
			this.WCheck14.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck14.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck14.Location = new System.Drawing.Point(28, 56);
			this.WCheck14.Name = "WCheck14";
			this.WCheck14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck14.Size = new System.Drawing.Size(17, 13);
			this.WCheck14.TabIndex = 14;
			this.WCheck14.Tag = "14";
			this.WCheck14.Text = "Check39";
			this.WCheck14.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck13
			// 
			this.WCheck13.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck13.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck13.Enabled = false;
			this.WCheck13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck13.Location = new System.Drawing.Point(276, 32);
			this.WCheck13.Name = "WCheck13";
			this.WCheck13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck13.Size = new System.Drawing.Size(17, 17);
			this.WCheck13.TabIndex = 13;
			this.WCheck13.Tag = "13";
			this.WCheck13.Text = "Check38";
			this.WCheck13.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			this.WCheck13.CheckedChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck12
			// 
			this.WCheck12.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck12.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck12.Enabled = false;
			this.WCheck12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck12.Location = new System.Drawing.Point(256, 32);
			this.WCheck12.Name = "WCheck12";
			this.WCheck12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck12.Size = new System.Drawing.Size(17, 17);
			this.WCheck12.TabIndex = 12;
			this.WCheck12.Tag = "12";
			this.WCheck12.Text = "Check37";
			this.WCheck12.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			this.WCheck12.CheckedChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck11
			// 
			this.WCheck11.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck11.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck11.Enabled = false;
			this.WCheck11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck11.Location = new System.Drawing.Point(233, 32);
			this.WCheck11.Name = "WCheck11";
			this.WCheck11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck11.Size = new System.Drawing.Size(17, 17);
			this.WCheck11.TabIndex = 11;
			this.WCheck11.Tag = "11";
			this.WCheck11.Text = "Check36";
			this.WCheck11.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			this.WCheck11.CheckedChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck10
			// 
			this.WCheck10.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck10.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck10.Enabled = false;
			this.WCheck10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck10.Location = new System.Drawing.Point(211, 32);
			this.WCheck10.Name = "WCheck10";
			this.WCheck10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck10.Size = new System.Drawing.Size(17, 17);
			this.WCheck10.TabIndex = 10;
			this.WCheck10.Tag = "10";
			this.WCheck10.Text = "Check35";
			this.WCheck10.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			this.WCheck10.CheckedChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck9
			// 
			this.WCheck9.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck9.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck9.Location = new System.Drawing.Point(188, 32);
			this.WCheck9.Name = "WCheck9";
			this.WCheck9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck9.Size = new System.Drawing.Size(17, 17);
			this.WCheck9.TabIndex = 9;
			this.WCheck9.Tag = "9";
			this.WCheck9.Text = "Check34";
			this.WCheck9.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			this.WCheck9.CheckedChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck8
			// 
			this.WCheck8.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck8.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck8.Location = new System.Drawing.Point(168, 32);
			this.WCheck8.Name = "WCheck8";
			this.WCheck8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck8.Size = new System.Drawing.Size(17, 17);
			this.WCheck8.TabIndex = 8;
			this.WCheck8.Tag = "8";
			this.WCheck8.Text = "Check33";
			this.WCheck8.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			this.WCheck8.CheckedChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck7
			// 
			this.WCheck7.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck7.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck7.Location = new System.Drawing.Point(146, 32);
			this.WCheck7.Name = "WCheck7";
			this.WCheck7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck7.Size = new System.Drawing.Size(17, 17);
			this.WCheck7.TabIndex = 7;
			this.WCheck7.Tag = "7";
			this.WCheck7.Text = "Check32";
			this.WCheck7.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			this.WCheck7.CheckedChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck6
			// 
			this.WCheck6.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck6.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck6.Location = new System.Drawing.Point(124, 32);
			this.WCheck6.Name = "WCheck6";
			this.WCheck6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck6.Size = new System.Drawing.Size(17, 17);
			this.WCheck6.TabIndex = 6;
			this.WCheck6.Tag = "6";
			this.WCheck6.Text = "Check31";
			this.WCheck6.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			this.WCheck6.CheckedChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck5
			// 
			this.WCheck5.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck5.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck5.Location = new System.Drawing.Point(103, 32);
			this.WCheck5.Name = "WCheck5";
			this.WCheck5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck5.Size = new System.Drawing.Size(17, 17);
			this.WCheck5.TabIndex = 5;
			this.WCheck5.Tag = "5";
			this.WCheck5.Text = "Check30";
			this.WCheck5.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			this.WCheck5.CheckedChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck4
			// 
			this.WCheck4.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck4.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck4.Location = new System.Drawing.Point(80, 32);
			this.WCheck4.Name = "WCheck4";
			this.WCheck4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck4.Size = new System.Drawing.Size(17, 17);
			this.WCheck4.TabIndex = 4;
			this.WCheck4.Tag = "4";
			this.WCheck4.Text = "Check29";
			this.WCheck4.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			this.WCheck4.CheckedChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck3
			// 
			this.WCheck3.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck3.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck3.Location = new System.Drawing.Point(60, 32);
			this.WCheck3.Name = "WCheck3";
			this.WCheck3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck3.Size = new System.Drawing.Size(17, 17);
			this.WCheck3.TabIndex = 3;
			this.WCheck3.Tag = "3";
			this.WCheck3.Text = "Check28";
			this.WCheck3.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck2
			// 
			this.WCheck2.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck2.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck2.Location = new System.Drawing.Point(40, 32);
			this.WCheck2.Name = "WCheck2";
			this.WCheck2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck2.Size = new System.Drawing.Size(17, 17);
			this.WCheck2.TabIndex = 2;
			this.WCheck2.Tag = "2";
			this.WCheck2.Text = "Check27";
			this.WCheck2.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// WCheck1
			// 
			this.WCheck1.BackColor = System.Drawing.SystemColors.Control;
			this.WCheck1.Cursor = System.Windows.Forms.Cursors.Default;
			this.WCheck1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.WCheck1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WCheck1.Location = new System.Drawing.Point(16, 32);
			this.WCheck1.Name = "WCheck1";
			this.WCheck1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WCheck1.Size = new System.Drawing.Size(17, 17);
			this.WCheck1.TabIndex = 1;
			this.WCheck1.Tag = "1";
			this.WCheck1.Text = "Check26";
			this.WCheck1.CheckStateChanged += new System.EventHandler(this.WCheck1_CheckedChanged);
			// 
			// _Label4_1
			// 
			this._Label4_1.BackColor = System.Drawing.SystemColors.Control;
			this._Label4_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label4_1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._Label4_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label4_1.Location = new System.Drawing.Point(28, 76);
			this._Label4_1.Name = "_Label4_1";
			this._Label4_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label4_1.Size = new System.Drawing.Size(269, 17);
			this._Label4_1.TabIndex = 27;
			this._Label4_1.Text = "14   15   16    17   18   19   20    21   22   23   24   25";
			// 
			// _Label3_1
			// 
			this._Label3_1.BackColor = System.Drawing.SystemColors.Control;
			this._Label3_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label3_1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._Label3_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label3_1.Location = new System.Drawing.Point(20, 16);
			this._Label3_1.Name = "_Label3_1";
			this._Label3_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label3_1.Size = new System.Drawing.Size(277, 13);
			this._Label3_1.TabIndex = 26;
			this._Label3_1.Text = "1     2     3     4      5     6     7     8     9     10   11   12   13 ";
			// 
			// Close_Driver
			// 
			this.Close_Driver.BackColor = System.Drawing.SystemColors.Control;
			this.Close_Driver.Cursor = System.Windows.Forms.Cursors.Default;
			this.Close_Driver.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Close_Driver.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Close_Driver.Location = new System.Drawing.Point(360, 200);
			this.Close_Driver.Name = "Close_Driver";
			this.Close_Driver.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Close_Driver.Size = new System.Drawing.Size(149, 33);
			this.Close_Driver.TabIndex = 91;
			this.Close_Driver.Text = "Close TVicPort";
			this.Close_Driver.Click += new System.EventHandler(this.Close_Driver_Click);
			// 
			// Command1
			// 
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(360, 280);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(149, 33);
			this.Command1.TabIndex = 90;
			this.Command1.Text = "Exit";
			this.Command1.Click += new System.EventHandler(this.Command1_Click);
			// 
			// _Label3_0
			// 
			this._Label3_0.AutoSize = true;
			this._Label3_0.BackColor = System.Drawing.SystemColors.Control;
			this._Label3_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label3_0.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this._Label3_0.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this._Label3_0.Location = new System.Drawing.Point(400, 16);
			this._Label3_0.Name = "_Label3_0";
			this._Label3_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label3_0.Size = new System.Drawing.Size(60, 18);
			this._Label3_0.TabIndex = 95;
			this._Label3_0.Text = "TVicPort";
			// 
			// _Label4_0
			// 
			this._Label4_0.AutoSize = true;
			this._Label4_0.BackColor = System.Drawing.SystemColors.Control;
			this._Label4_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label4_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this._Label4_0.ForeColor = System.Drawing.Color.Blue;
			this._Label4_0.Location = new System.Drawing.Point(340, 40);
			this._Label4_0.Name = "_Label4_0";
			this._Label4_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label4_0.Size = new System.Drawing.Size(201, 16);
			this._Label4_0.TabIndex = 94;
			this._Label4_0.Text = "http://www.entechtaiwan.com/tools.htm";
			this._Label4_0.Click += new System.EventHandler(this._Label4_0_Click);
			// 
			// Label5
			// 
			this.Label5.AutoSize = true;
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.Label5.ForeColor = System.Drawing.Color.Blue;
			this.Label5.Location = new System.Drawing.Point(364, 64);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(164, 16);
			this.Label5.TabIndex = 93;
			this.Label5.Text = "mailto:tools@entechtaiwan.com";
			this.Label5.Click += new System.EventHandler(this.Label5_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(136, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 16);
			this.label1.TabIndex = 100;
			this.label1.Text = "LPT:";
			// 
			// Open_Driver
			// 
			this.Open_Driver.BackColor = System.Drawing.SystemColors.Control;
			this.Open_Driver.Cursor = System.Windows.Forms.Cursors.Default;
			this.Open_Driver.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Open_Driver.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Open_Driver.Location = new System.Drawing.Point(360, 144);
			this.Open_Driver.Name = "Open_Driver";
			this.Open_Driver.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Open_Driver.Size = new System.Drawing.Size(149, 33);
			this.Open_Driver.TabIndex = 101;
			this.Open_Driver.Text = "Open TVicPort";
			this.Open_Driver.Click += new System.EventHandler(this.Open_Driver_Click);
			// 
			// N_Lpt
			// 
			this.N_Lpt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.N_Lpt.Location = new System.Drawing.Point(172, 56);
			this.N_Lpt.Name = "N_Lpt";
			this.N_Lpt.Size = new System.Drawing.Size(36, 22);
			this.N_Lpt.TabIndex = 99;
			// 
			// Label12
			// 
			this.Label12.BackColor = System.Drawing.SystemColors.Control;
			this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label12.Location = new System.Drawing.Point(136, 24);
			this.Label12.Name = "Label12";
			this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label12.Size = new System.Drawing.Size(109, 17);
			this.Label12.TabIndex = 97;
			this.Label12.Text = "LPTs founded : ?";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.Control;
			this.label8.Cursor = System.Windows.Forms.Cursors.Default;
			this.label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(216, 60);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label8.Size = new System.Drawing.Size(44, 16);
			this.label8.TabIndex = 96;
			this.label8.Text = "????h";
			// 
			// L_Days
			// 
			this.L_Days.Location = new System.Drawing.Point(360, 92);
			this.L_Days.Name = "L_Days";
			this.L_Days.Size = new System.Drawing.Size(160, 16);
			this.L_Days.TabIndex = 102;
			this.L_Days.Text = "Evaluation Days Left: ??";
			this.L_Days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LptForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(548, 353);
			this.Controls.Add(this.L_Days);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Open_Driver);
			this.Controls.Add(this.N_Lpt);
			this.Controls.Add(this.Label12);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Close_Driver);
			this.Controls.Add(this.Command1);
			this.Controls.Add(this._Label3_0);
			this.Controls.Add(this._Label4_0);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Frame6);
			this.Controls.Add(this.Frame4);
			this.Controls.Add(this.Frame5);
			this.Name = "LptForm";
			this.Text = "TVicPort LPT Test Application";
			this.Load += new System.EventHandler(this.LptForm_Load);
			this.Closed += new System.EventHandler(this.LptForm_Closed);
			this.Frame6.ResumeLayout(false);
			this.Frame4.ResumeLayout(false);
			this.Frame5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.N_Lpt)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new LptForm());
		}


		private void LockControls()
		{
			Open_Driver.Enabled = !DriverOpened;
			Close_Driver.Enabled = DriverOpened;
			N_Lpt.Enabled        = DriverOpened;
			N_Lpt.Minimum        = 1;
			if (DriverOpened) 
			{
				N_Lpt.Maximum  = TVicPort.GetLPTNumPorts();
				label8.Text = TVicPort.GetLPTBasePort().ToString("X4")+"h";
				Label12.Text = "LPTs founded :" + TVicPort.GetLPTNumPorts().ToString();
			}
			else
                N_Lpt.Maximum        = 1;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (DriverOpened) 
			{
				RCheck1.Checked  = 0 != TVicPort.GetPin(1);
				RCheck2.Checked  = 0 != TVicPort.GetPin(2);
				RCheck3.Checked  = 0 != TVicPort.GetPin(3);
				RCheck4.Checked  = 0 != TVicPort.GetPin(4);
				RCheck5.Checked  = 0 != TVicPort.GetPin(5);
				RCheck6.Checked  = 0 != TVicPort.GetPin(6);
				RCheck7.Checked  = 0 != TVicPort.GetPin(7);
				RCheck8.Checked  = 0 != TVicPort.GetPin(8);
				RCheck9.Checked  = 0 != TVicPort.GetPin(9);
				RCheck10.Checked = 0 != TVicPort.GetPin(10);
				RCheck11.Checked = 0 != TVicPort.GetPin(11);
				RCheck12.Checked = 0 != TVicPort.GetPin(12);
				RCheck13.Checked = 0 != TVicPort.GetPin(13);
				RCheck14.Checked = 0 != TVicPort.GetPin(14);
				RCheck15.Checked = 0 != TVicPort.GetPin(15);
				RCheck16.Checked = 0 != TVicPort.GetPin(16);
				RCheck17.Checked = 0 != TVicPort.GetPin(17);
				
				C_ACKWL.Checked = 0 != TVicPort.GetLPTAckwl();
				C_BUSY.Checked  = 0 != TVicPort.GetLPTBusy();
				C_ERROR.Checked = 0 != TVicPort.GetLPTError();
				C_PE.Checked    = 0 != TVicPort.GetLPTPaperEnd();
				C_SLCT.Checked  = 0 != TVicPort.GetLPTSlct();
			}																																																			
			
		}

		private void Open_Driver_Click(object sender, System.EventArgs e)
		{
			TVicPort.OpenTVicPort();
			DriverOpened = TVicPort.IsDriverOpened() != 0;
			LockControls();
			if (DriverOpened)
			{
				TVicPort.SetLPTNumber(1);
				N_Lpt.Value = 1;
				L_Days.Text = "Evaluation Days Left: " + TVicPort.EvaluationDaysLeft().ToString("d");
				LockControls();
			}
			
		}

		private void Close_Driver_Click(object sender, System.EventArgs e)
		{
			TVicPort.CloseTVicPort();
			DriverOpened = false;
			LockControls();
		}

		private void LptForm_Load(object sender, System.EventArgs e)
		{
			DriverOpened = false;
			LockControls();
		}

		private void LptForm_Closed(object sender, System.EventArgs e)
		{
			TVicPort.CloseTVicPort();
		}

		private void Command1_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void WCheck1_CheckedChanged(object sender, System.EventArgs e)
		{
			byte Index;
			String s = ((CheckBox)sender).Name;
			Index = (byte) byte.Parse(s.Substring(6,s.Length-6));
			if (DriverOpened) 
			{
				TVicPort.SetPin( Index, (uint)(((CheckBox)sender).Checked?1:0));
			}
			else
                TVicPort.SetPin( Index, 0);           
		}

		private void N_Lpt_ValueChanged(object sender, System.EventArgs e)
		{
			TVicPort.SetLPTNumber((byte)N_Lpt.Value);
			LockControls();
		}

		private void _Label4_0_Click(object sender, System.EventArgs e)
		{
			TVicPort.LaunchWeb();
		}

		private void Label5_Click(object sender, System.EventArgs e)
		{
			TVicPort.LaunchMail();
		}

		

	}
}
