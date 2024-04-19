namespace POS
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow3 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.bttnexit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.Loginimage = new System.Windows.Forms.PictureBox();
            this.passwordTextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.userTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loginimage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.Loginimage);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.guna2Panel2.Location = new System.Drawing.Point(14, 16);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(357, 586);
            this.guna2Panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(41, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "LOG IN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.loginButton);
            this.guna2ShadowPanel1.Controls.Add(this.passwordTextBox3);
            this.guna2ShadowPanel1.Controls.Add(this.userTextBox1);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(455, 66);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 15;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(352, 491);
            this.guna2ShadowPanel1.TabIndex = 1;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // loginButton
            // 
            this.loginButton.BorderRadius = 10;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.loginButton.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(79, 317);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(169, 43);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "LOG IN";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 30);
            this.label4.TabIndex = 4;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bttnexit
            // 
            this.bttnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnexit.BackColor = System.Drawing.Color.Transparent;
            this.bttnexit.BorderRadius = 15;
            this.bttnexit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.bttnexit.IconColor = System.Drawing.Color.White;
            this.bttnexit.Location = new System.Drawing.Point(816, 16);
            this.bttnexit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttnexit.Name = "bttnexit";
            this.bttnexit.Size = new System.Drawing.Size(45, 39);
            this.bttnexit.TabIndex = 2;
            this.bttnexit.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "POS";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // Loginimage
            // 
            this.Loginimage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Loginimage.BackColor = System.Drawing.Color.Transparent;
            this.Loginimage.Image = ((System.Drawing.Image)(resources.GetObject("Loginimage.Image")));
            this.Loginimage.Location = new System.Drawing.Point(24, 62);
            this.Loginimage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Loginimage.Name = "Loginimage";
            this.Loginimage.Size = new System.Drawing.Size(298, 449);
            this.Loginimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Loginimage.TabIndex = 8;
            this.Loginimage.TabStop = false;
            this.Loginimage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // passwordTextBox3
            // 
            this.passwordTextBox3.BorderColor = System.Drawing.Color.Gray;
            this.passwordTextBox3.BorderRadius = 10;
            this.passwordTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox3.DefaultText = "";
            this.passwordTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox3.IconLeft = ((System.Drawing.Image)(resources.GetObject("passwordTextBox3.IconLeft")));
            this.passwordTextBox3.Location = new System.Drawing.Point(38, 223);
            this.passwordTextBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.passwordTextBox3.Name = "passwordTextBox3";
            this.passwordTextBox3.PasswordChar = '●';
            this.passwordTextBox3.PlaceholderText = "Password";
            this.passwordTextBox3.SelectedText = "";
            this.passwordTextBox3.Size = new System.Drawing.Size(250, 50);
            this.passwordTextBox3.TabIndex = 1;
            this.passwordTextBox3.UseSystemPasswordChar = true;
            this.passwordTextBox3.TextChanged += new System.EventHandler(this.passwordTextBox3_TextChanged);
            // 
            // userTextBox1
            // 
            this.userTextBox1.BorderColor = System.Drawing.Color.Gray;
            this.userTextBox1.BorderRadius = 10;
            this.userTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userTextBox1.DefaultText = "";
            this.userTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userTextBox1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userTextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("userTextBox1.IconLeft")));
            this.userTextBox1.Location = new System.Drawing.Point(38, 162);
            this.userTextBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.userTextBox1.Name = "userTextBox1";
            this.userTextBox1.PasswordChar = '\0';
            this.userTextBox1.PlaceholderText = "User";
            this.userTextBox1.SelectedText = "";
            this.userTextBox1.Size = new System.Drawing.Size(250, 50);
            this.userTextBox1.TabIndex = 0;
            this.userTextBox1.TextChanged += new System.EventHandler(this.userTextBox1_TextChanged);
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 618);
            this.Controls.Add(this.bttnexit);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Formlogin_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loginimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Loginimage;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox userTextBox1;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox3;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2ControlBox bttnexit;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}

