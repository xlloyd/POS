namespace POS
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbluser = new System.Windows.Forms.Label();
            this.bttnmin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bttnmax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bttnexit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.Rstrntmngmnt = new System.Windows.Forms.Label();
            this.ReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.SettingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.KitchenButton = new Guna.UI2.WinForms.Guna2Button();
            this.POSButton = new Guna.UI2.WinForms.Guna2Button();
            this.StaffButton = new Guna.UI2.WinForms.Guna2Button();
            this.TableButton = new Guna.UI2.WinForms.Guna2Button();
            this.ProdButton = new Guna.UI2.WinForms.Guna2Button();
            this.HomeButton = new Guna.UI2.WinForms.Guna2Button();
            this.CategButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ShadowPanel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.lbluser);
            this.guna2ShadowPanel2.Controls.Add(this.bttnmin);
            this.guna2ShadowPanel2.Controls.Add(this.bttnmax);
            this.guna2ShadowPanel2.Controls.Add(this.bttnexit);
            this.guna2ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(172, 0);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(1200, 53);
            this.guna2ShadowPanel2.TabIndex = 1;
            this.guna2ShadowPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel2_Paint);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(15, 22);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(58, 28);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "label1";
            this.lbluser.Click += new System.EventHandler(this.lbluser_Click);
            // 
            // bttnmin
            // 
            this.bttnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnmin.BackColor = System.Drawing.Color.Transparent;
            this.bttnmin.BorderRadius = 15;
            this.bttnmin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.bttnmin.CustomClick = true;
            this.bttnmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.bttnmin.IconColor = System.Drawing.Color.White;
            this.bttnmin.Location = new System.Drawing.Point(1037, 12);
            this.bttnmin.Name = "bttnmin";
            this.bttnmin.Size = new System.Drawing.Size(39, 29);
            this.bttnmin.TabIndex = 5;
            this.bttnmin.Click += new System.EventHandler(this.bttnmin_Click);
            // 
            // bttnmax
            // 
            this.bttnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnmax.BackColor = System.Drawing.Color.Transparent;
            this.bttnmax.BorderRadius = 15;
            this.bttnmax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.bttnmax.CustomClick = true;
            this.bttnmax.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.bttnmax.IconColor = System.Drawing.Color.White;
            this.bttnmax.Location = new System.Drawing.Point(1093, 12);
            this.bttnmax.Name = "bttnmax";
            this.bttnmax.Size = new System.Drawing.Size(39, 29);
            this.bttnmax.TabIndex = 4;
            this.bttnmax.Click += new System.EventHandler(this.bttnmax_Click);
            // 
            // bttnexit
            // 
            this.bttnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnexit.BackColor = System.Drawing.Color.Transparent;
            this.bttnexit.BorderRadius = 15;
            this.bttnexit.CustomClick = true;
            this.bttnexit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.bttnexit.IconColor = System.Drawing.Color.White;
            this.bttnexit.Location = new System.Drawing.Point(1148, 12);
            this.bttnexit.Name = "bttnexit";
            this.bttnexit.Size = new System.Drawing.Size(39, 29);
            this.bttnexit.TabIndex = 3;
            this.bttnexit.Click += new System.EventHandler(this.bttnexit_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.guna2ShadowPanel3);
            this.guna2Panel3.Controls.Add(this.guna2ShadowPanel2);
            this.guna2Panel3.Controls.Add(this.guna2ShadowPanel1);
            this.guna2Panel3.Location = new System.Drawing.Point(-3, -4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1372, 680);
            this.guna2Panel3.TabIndex = 1;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(172, 53);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(1200, 627);
            this.guna2ShadowPanel3.TabIndex = 2;
            this.guna2ShadowPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel3_Paint);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.ReportButton);
            this.guna2ShadowPanel1.Controls.Add(this.SettingsButton);
            this.guna2ShadowPanel1.Controls.Add(this.KitchenButton);
            this.guna2ShadowPanel1.Controls.Add(this.POSButton);
            this.guna2ShadowPanel1.Controls.Add(this.StaffButton);
            this.guna2ShadowPanel1.Controls.Add(this.TableButton);
            this.guna2ShadowPanel1.Controls.Add(this.ProdButton);
            this.guna2ShadowPanel1.Controls.Add(this.HomeButton);
            this.guna2ShadowPanel1.Controls.Add(this.CategButton);
            this.guna2ShadowPanel1.Controls.Add(this.Rstrntmngmnt);
            this.guna2ShadowPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(217)))), ((int)(((byte)(194)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(172, 680);
            this.guna2ShadowPanel1.TabIndex = 0;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // Rstrntmngmnt
            // 
            this.Rstrntmngmnt.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rstrntmngmnt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rstrntmngmnt.Location = new System.Drawing.Point(-2, 105);
            this.Rstrntmngmnt.Name = "Rstrntmngmnt";
            this.Rstrntmngmnt.Size = new System.Drawing.Size(166, 31);
            this.Rstrntmngmnt.TabIndex = 1;
            this.Rstrntmngmnt.Text = "Tummy Time";
            this.Rstrntmngmnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rstrntmngmnt.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.BorderRadius = 20;
            this.ReportButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ReportButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.ReportButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ReportButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.ReportButton.CustomizableEdges.BottomRight = false;
            this.ReportButton.CustomizableEdges.TopRight = false;
            this.ReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReportButton.FillColor = System.Drawing.Color.Transparent;
            this.ReportButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.ReportButton.Image = ((System.Drawing.Image)(resources.GetObject("ReportButton.Image")));
            this.ReportButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.ReportButton.ImageSize = new System.Drawing.Size(25, 25);
            this.ReportButton.Location = new System.Drawing.Point(23, 530);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(141, 47);
            this.ReportButton.TabIndex = 16;
            this.ReportButton.Text = "Reports";
            this.ReportButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportButton.TextOffset = new System.Drawing.Point(10, 2);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BorderRadius = 20;
            this.SettingsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.SettingsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.SettingsButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.SettingsButton.CustomizableEdges.BottomRight = false;
            this.SettingsButton.CustomizableEdges.TopRight = false;
            this.SettingsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SettingsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SettingsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SettingsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SettingsButton.FillColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingsButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.SettingsButton.ImageSize = new System.Drawing.Size(25, 25);
            this.SettingsButton.Location = new System.Drawing.Point(23, 583);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(141, 47);
            this.SettingsButton.TabIndex = 15;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingsButton.TextOffset = new System.Drawing.Point(10, 2);
            // 
            // KitchenButton
            // 
            this.KitchenButton.BorderRadius = 20;
            this.KitchenButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.KitchenButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.KitchenButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.KitchenButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.KitchenButton.CustomizableEdges.BottomRight = false;
            this.KitchenButton.CustomizableEdges.TopRight = false;
            this.KitchenButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.KitchenButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.KitchenButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.KitchenButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.KitchenButton.FillColor = System.Drawing.Color.Transparent;
            this.KitchenButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KitchenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.KitchenButton.Image = ((System.Drawing.Image)(resources.GetObject("KitchenButton.Image")));
            this.KitchenButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.KitchenButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.KitchenButton.ImageSize = new System.Drawing.Size(25, 25);
            this.KitchenButton.Location = new System.Drawing.Point(23, 477);
            this.KitchenButton.Name = "KitchenButton";
            this.KitchenButton.Size = new System.Drawing.Size(141, 47);
            this.KitchenButton.TabIndex = 14;
            this.KitchenButton.Text = "Kitchen";
            this.KitchenButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.KitchenButton.TextOffset = new System.Drawing.Point(10, 2);
            // 
            // POSButton
            // 
            this.POSButton.BorderRadius = 20;
            this.POSButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.POSButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.POSButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.POSButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.POSButton.CustomizableEdges.BottomRight = false;
            this.POSButton.CustomizableEdges.TopRight = false;
            this.POSButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.POSButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.POSButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.POSButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.POSButton.FillColor = System.Drawing.Color.Transparent;
            this.POSButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.POSButton.Image = ((System.Drawing.Image)(resources.GetObject("POSButton.Image")));
            this.POSButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.POSButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.POSButton.ImageSize = new System.Drawing.Size(25, 25);
            this.POSButton.Location = new System.Drawing.Point(23, 424);
            this.POSButton.Name = "POSButton";
            this.POSButton.Size = new System.Drawing.Size(141, 47);
            this.POSButton.TabIndex = 13;
            this.POSButton.Text = "POS";
            this.POSButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.POSButton.TextOffset = new System.Drawing.Point(10, 2);
            // 
            // StaffButton
            // 
            this.StaffButton.BorderRadius = 20;
            this.StaffButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.StaffButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.StaffButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.StaffButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.StaffButton.CustomizableEdges.BottomRight = false;
            this.StaffButton.CustomizableEdges.TopRight = false;
            this.StaffButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StaffButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StaffButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StaffButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StaffButton.FillColor = System.Drawing.Color.Transparent;
            this.StaffButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.StaffButton.Image = ((System.Drawing.Image)(resources.GetObject("StaffButton.Image")));
            this.StaffButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StaffButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.StaffButton.ImageSize = new System.Drawing.Size(25, 25);
            this.StaffButton.Location = new System.Drawing.Point(28, 371);
            this.StaffButton.Name = "StaffButton";
            this.StaffButton.Size = new System.Drawing.Size(136, 47);
            this.StaffButton.TabIndex = 12;
            this.StaffButton.Text = "Staff";
            this.StaffButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StaffButton.TextOffset = new System.Drawing.Point(10, 2);
            // 
            // TableButton
            // 
            this.TableButton.BorderRadius = 20;
            this.TableButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.TableButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.TableButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.TableButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.TableButton.CustomizableEdges.BottomRight = false;
            this.TableButton.CustomizableEdges.TopRight = false;
            this.TableButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TableButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TableButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TableButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TableButton.FillColor = System.Drawing.Color.Transparent;
            this.TableButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.TableButton.Image = ((System.Drawing.Image)(resources.GetObject("TableButton.Image")));
            this.TableButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TableButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.TableButton.ImageSize = new System.Drawing.Size(25, 25);
            this.TableButton.Location = new System.Drawing.Point(28, 318);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(136, 47);
            this.TableButton.TabIndex = 11;
            this.TableButton.Text = "Tables";
            this.TableButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TableButton.TextOffset = new System.Drawing.Point(10, 2);
            // 
            // ProdButton
            // 
            this.ProdButton.BorderRadius = 20;
            this.ProdButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ProdButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.ProdButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ProdButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.ProdButton.CustomizableEdges.BottomRight = false;
            this.ProdButton.CustomizableEdges.TopRight = false;
            this.ProdButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProdButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProdButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProdButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProdButton.FillColor = System.Drawing.Color.Transparent;
            this.ProdButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.ProdButton.Image = ((System.Drawing.Image)(resources.GetObject("ProdButton.Image")));
            this.ProdButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProdButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.ProdButton.ImageSize = new System.Drawing.Size(25, 25);
            this.ProdButton.Location = new System.Drawing.Point(28, 265);
            this.ProdButton.Name = "ProdButton";
            this.ProdButton.Size = new System.Drawing.Size(136, 47);
            this.ProdButton.TabIndex = 10;
            this.ProdButton.Text = "Products";
            this.ProdButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProdButton.TextOffset = new System.Drawing.Point(10, 2);
            // 
            // HomeButton
            // 
            this.HomeButton.AllowDrop = true;
            this.HomeButton.BorderRadius = 20;
            this.HomeButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HomeButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.HomeButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.HomeButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.HomeButton.CustomizableEdges.BottomRight = false;
            this.HomeButton.CustomizableEdges.TopRight = false;
            this.HomeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeButton.FillColor = System.Drawing.Color.Transparent;
            this.HomeButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.HomeButton.ImageSize = new System.Drawing.Size(25, 25);
            this.HomeButton.Location = new System.Drawing.Point(28, 159);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(136, 47);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeButton.TextOffset = new System.Drawing.Point(10, 2);
            this.HomeButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // CategButton
            // 
            this.CategButton.BorderRadius = 20;
            this.CategButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CategButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.CategButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.CategButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            this.CategButton.CustomizableEdges.BottomRight = false;
            this.CategButton.CustomizableEdges.TopRight = false;
            this.CategButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CategButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CategButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CategButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CategButton.FillColor = System.Drawing.Color.Transparent;
            this.CategButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.CategButton.Image = ((System.Drawing.Image)(resources.GetObject("CategButton.Image")));
            this.CategButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CategButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.CategButton.ImageSize = new System.Drawing.Size(25, 25);
            this.CategButton.Location = new System.Drawing.Point(28, 212);
            this.CategButton.Name = "CategButton";
            this.CategButton.Size = new System.Drawing.Size(136, 47);
            this.CategButton.TabIndex = 3;
            this.CategButton.Text = "Categories";
            this.CategButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CategButton.TextOffset = new System.Drawing.Point(10, 2);
            this.CategButton.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.ErrorImage")));
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(138, 99);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 683);
            this.Controls.Add(this.guna2Panel3);
            this.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2ControlBox bttnexit;
        private Guna.UI2.WinForms.Guna2ControlBox bttnmin;
        private Guna.UI2.WinForms.Guna2ControlBox bttnmax;
        private System.Windows.Forms.Label lbluser;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button HomeButton;
        private System.Windows.Forms.Label Rstrntmngmnt;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button ProdButton;
        private Guna.UI2.WinForms.Guna2Button CategButton;
        private Guna.UI2.WinForms.Guna2Button TableButton;
        private Guna.UI2.WinForms.Guna2Button StaffButton;
        private Guna.UI2.WinForms.Guna2Button POSButton;
        private Guna.UI2.WinForms.Guna2Button KitchenButton;
        private Guna.UI2.WinForms.Guna2Button ReportButton;
        private Guna.UI2.WinForms.Guna2Button SettingsButton;
    }
}