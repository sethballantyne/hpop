using System;
using System.Windows.Forms;

namespace MailMonitor
{
	public class frmMailBox : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtServerAddress;
		private System.Windows.Forms.Label lblServerAddress;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.Button cmdCancel;
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.GroupBox gbxHeader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picIcon;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button cmdApply;
		private bool _loaded;
		private bool _dirty;
		private System.Windows.Forms.CheckBox chkUse;
		private CheckBox useSsl;
//		private bool _auto;
//		private bool _driven;



		#region Entry
		public frmMailBox()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private void frmMailBox_Load(object sender, EventArgs e)
		{
			if(!MailBox.Equals(null))
			{
				txtName.Text=MailBox.Name;
				txtServerAddress.Text=MailBox.ServerAddress;
				txtPort.Text=MailBox.Port.ToString();
				txtUserName.Text=MailBox.UserName;
				txtPassword.Text=MailBox.Password;
				txtDescription.Text=MailBox.Desccription;
				chkUse.Checked=MailBox.Use;
				useSsl.Checked=MailBox.UseSsl;
			}
			else
			{
				MailBox=new MailBox();
			}
			_loaded=true;
			//_auto=false;
		}
		#endregion

		#region Windows
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMailBox));
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtServerAddress = new System.Windows.Forms.TextBox();
			this.lblServerAddress = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.lblPort = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.cmdSave = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.gbxHeader = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.picIcon = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.cmdApply = new System.Windows.Forms.Button();
			this.chkUse = new System.Windows.Forms.CheckBox();
			this.useSsl = new System.Windows.Forms.CheckBox();
			this.gbxHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(7, 45);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "&Name:";
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Location = new System.Drawing.Point(67, 45);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(120, 20);
			this.txtName.TabIndex = 1;
			this.txtName.TextChanged += new System.EventHandler(this.ContentChanged);
			// 
			// txtServerAddress
			// 
			this.txtServerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtServerAddress.Location = new System.Drawing.Point(67, 74);
			this.txtServerAddress.Name = "txtServerAddress";
			this.txtServerAddress.Size = new System.Drawing.Size(120, 20);
			this.txtServerAddress.TabIndex = 5;
			this.txtServerAddress.TextChanged += new System.EventHandler(this.ContentChanged);
			// 
			// lblServerAddress
			// 
			this.lblServerAddress.AutoSize = true;
			this.lblServerAddress.Location = new System.Drawing.Point(7, 74);
			this.lblServerAddress.Name = "lblServerAddress";
			this.lblServerAddress.Size = new System.Drawing.Size(41, 13);
			this.lblServerAddress.TabIndex = 4;
			this.lblServerAddress.Text = "&Server:";
			// 
			// txtPort
			// 
			this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPort.Location = new System.Drawing.Point(253, 74);
			this.txtPort.MaxLength = 5;
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(40, 20);
			this.txtPort.TabIndex = 7;
			this.txtPort.Text = "110";
			this.txtPort.TextChanged += new System.EventHandler(this.ContentChanged);
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(193, 74);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(29, 13);
			this.lblPort.TabIndex = 6;
			this.lblPort.Text = "Por&t:";
			// 
			// txtUserName
			// 
			this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUserName.Location = new System.Drawing.Point(67, 104);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(120, 20);
			this.txtUserName.TabIndex = 9;
			this.txtUserName.TextChanged += new System.EventHandler(this.ContentChanged);
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(7, 104);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(63, 13);
			this.lblUserName.TabIndex = 8;
			this.lblUserName.Text = "&User Name:";
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.Location = new System.Drawing.Point(253, 104);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(120, 20);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.TextChanged += new System.EventHandler(this.ContentChanged);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(193, 104);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 13);
			this.lblPassword.TabIndex = 10;
			this.lblPassword.Text = "&Password:";
			// 
			// cmdSave
			// 
			this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdSave.Location = new System.Drawing.Point(240, 134);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(62, 21);
			this.cmdSave.TabIndex = 14;
			this.cmdSave.Text = "Sa&ve";
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// cmdCancel
			// 
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdCancel.Location = new System.Drawing.Point(307, 134);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(62, 21);
			this.cmdCancel.TabIndex = 15;
			this.cmdCancel.Text = "&Cancel";
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// txtDescription
			// 
			this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescription.Location = new System.Drawing.Point(253, 45);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(120, 20);
			this.txtDescription.TabIndex = 3;
			this.txtDescription.TextChanged += new System.EventHandler(this.ContentChanged);
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(193, 45);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(63, 13);
			this.lblDescription.TabIndex = 2;
			this.lblDescription.Text = "&Description:";
			// 
			// gbxHeader
			// 
			this.gbxHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gbxHeader.BackColor = System.Drawing.Color.White;
			this.gbxHeader.Controls.Add(this.label1);
			this.gbxHeader.Controls.Add(this.picIcon);
			this.gbxHeader.Controls.Add(this.lblTitle);
			this.gbxHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbxHeader.Location = new System.Drawing.Point(0, -7);
			this.gbxHeader.Name = "gbxHeader";
			this.gbxHeader.Size = new System.Drawing.Size(489, 44);
			this.gbxHeader.TabIndex = 14;
			this.gbxHeader.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(100, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Define your mailbox";
			// 
			// picIcon
			// 
			this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
			this.picIcon.Location = new System.Drawing.Point(7, 11);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new System.Drawing.Size(26, 30);
			this.picIcon.TabIndex = 5;
			this.picIcon.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(37, 7);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(80, 23);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "MailBox";
			// 
			// cmdApply
			// 
			this.cmdApply.Enabled = false;
			this.cmdApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdApply.Location = new System.Drawing.Point(173, 134);
			this.cmdApply.Name = "cmdApply";
			this.cmdApply.Size = new System.Drawing.Size(63, 21);
			this.cmdApply.TabIndex = 13;
			this.cmdApply.Text = "&Apply";
			this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
			// 
			// chkUse
			// 
			this.chkUse.Checked = true;
			this.chkUse.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkUse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.chkUse.Location = new System.Drawing.Point(7, 134);
			this.chkUse.Name = "chkUse";
			this.chkUse.Size = new System.Drawing.Size(66, 15);
			this.chkUse.TabIndex = 12;
			this.chkUse.Text = "Us&e";
			// 
			// useSsl
			// 
			this.useSsl.AutoSize = true;
			this.useSsl.Checked = true;
			this.useSsl.CheckState = System.Windows.Forms.CheckState.Checked;
			this.useSsl.Location = new System.Drawing.Point(307, 76);
			this.useSsl.Name = "useSsl";
			this.useSsl.Size = new System.Drawing.Size(68, 17);
			this.useSsl.TabIndex = 16;
			this.useSsl.Text = "Use SSL";
			this.useSsl.UseVisualStyleBackColor = true;
			// 
			// frmMailBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(458, 175);
			this.Controls.Add(this.useSsl);
			this.Controls.Add(this.chkUse);
			this.Controls.Add(this.cmdApply);
			this.Controls.Add(this.gbxHeader);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdSave);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.lblPort);
			this.Controls.Add(this.txtServerAddress);
			this.Controls.Add(this.lblServerAddress);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMailBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Mail Monitor - Mail Box";
			this.Load += new System.EventHandler(this.frmMailBox_Load);
			this.Closed += new System.EventHandler(this.frmMailBox_Closed);
			this.gbxHeader.ResumeLayout(false);
			this.gbxHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		#region Functions
		public MailBox MailBox { get; set; }

		private bool ApplySettings()
		{
			int intPort=Convert.ToInt32(txtPort.Text);
			if(intPort>0 && intPort<65535)
			{
				MailBox.Name=txtName.Text;
				MailBox.ServerAddress=txtServerAddress.Text;
				MailBox.Port=Convert.ToInt32(txtPort.Text);
				MailBox.UserName=txtUserName.Text;
				MailBox.Password=txtPassword.Text;
				MailBox.Desccription=txtDescription.Text;
				MailBox.Use=chkUse.Checked;
				MailBox.UseSsl=useSsl.Checked;
				_dirty=false;
				//_new=false;
				cmdApply.Enabled=false;
				return true;
			}
			
			return false;
		}

		private void CloseMe()
		{
			if(_dirty)
			{
				if(MessageBox.Show(this,"Something has been changed. Do you want save it before exit?","Save",MessageBoxButtons.YesNo)==DialogResult.Yes)
					ApplySettings();
			}
			Close();
		}

		#endregion

		#region Controls

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			if(ApplySettings())
				this.Close();
			else
				MessageBox.Show(this,"Please input a valid port number!");
		}

		private void ContentChanged(object sender, EventArgs e)
		{
			if(_loaded)
			{
				_dirty=true;
				cmdApply.Enabled=true;

//				if(_new)
//				{
//					switch (((TextBox)sender).Name)
//					{
//						case "txtName":
//							_auto=true;
//							_driven=true;
//							if(_auto&&txtDescription.Text!=txtName.Text)
//								txtDescription.Text=txtName.Text;
//							break;
//						case "txtDescription":
//						case "txtServerAddress":
//						case "txtUserName":
//							if(!_driven)
//								_auto=false;
//							break;
//					}					
//				}
			}
		}

		private void cmdApply_Click(object sender, EventArgs e)
		{
			ApplySettings();
		}

		private void frmMailBox_Closed(object sender, EventArgs e)
		{
			CloseMe();
		}
		#endregion
	}
}