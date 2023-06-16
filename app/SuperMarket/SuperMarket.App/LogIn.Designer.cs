namespace SuperMarket.App
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Identitfier = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminLogIn = new System.Windows.Forms.LinkLabel();
            this.CustomerLogIn = new System.Windows.Forms.LinkLabel();
            this.welcomeAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Identitfier
            // 
            this.Identitfier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Identitfier.Location = new System.Drawing.Point(33, 91);
            this.Identitfier.Name = "Identitfier";
            this.Identitfier.Size = new System.Drawing.Size(276, 23);
            this.Identitfier.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.Location = new System.Drawing.Point(33, 135);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(276, 23);
            this.Password.TabIndex = 1;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phone/Email";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(99, 32);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(142, 15);
            this.WelcomeLabel.TabIndex = 4;
            this.WelcomeLabel.Text = "Welcome To SuperMarket";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(135, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "LogIn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.login_click);
            // 
            // AdminLogIn
            // 
            this.AdminLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminLogIn.AutoSize = true;
            this.AdminLogIn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminLogIn.Location = new System.Drawing.Point(247, 200);
            this.AdminLogIn.Name = "AdminLogIn";
            this.AdminLogIn.Size = new System.Drawing.Size(81, 15);
            this.AdminLogIn.TabIndex = 6;
            this.AdminLogIn.TabStop = true;
            this.AdminLogIn.Text = "Admin LogIn?";
            this.AdminLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.adminLogIn_Clicked);
            // 
            // CustomerLogIn
            // 
            this.CustomerLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerLogIn.AutoSize = true;
            this.CustomerLogIn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerLogIn.Location = new System.Drawing.Point(244, 200);
            this.CustomerLogIn.Name = "CustomerLogIn";
            this.CustomerLogIn.Size = new System.Drawing.Size(97, 15);
            this.CustomerLogIn.TabIndex = 6;
            this.CustomerLogIn.TabStop = true;
            this.CustomerLogIn.Text = "Customer LogIn?";
            this.CustomerLogIn.Visible = false;
            this.CustomerLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.customerLogIn_Clicked);
            // 
            // welcomeAdmin
            // 
            this.welcomeAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeAdmin.AutoSize = true;
            this.welcomeAdmin.Location = new System.Drawing.Point(59, 32);
            this.welcomeAdmin.Name = "welcomeAdmin";
            this.welcomeAdmin.Size = new System.Drawing.Size(221, 15);
            this.welcomeAdmin.TabIndex = 7;
            this.welcomeAdmin.Text = "Welcome To SuperMarket Adminstration";
            this.welcomeAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeAdmin.Visible = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 224);
            this.Controls.Add(this.welcomeAdmin);
            this.Controls.Add(this.CustomerLogIn);
            this.Controls.Add(this.AdminLogIn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Identitfier);
            this.Name = "LogIn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Identitfier;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Label WelcomeLabel;
        private Button button1;
        private LinkLabel AdminLogIn;
        private LinkLabel CustomerLogIn;
        private Label welcomeAdmin;
    }
}