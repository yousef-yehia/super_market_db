namespace SuperMarket.App.Customer
{
    partial class CreateUpdateCustomer
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.Color.PowderBlue;
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstName.Location = new System.Drawing.Point(12, 47);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(266, 27);
            this.FirstName.TabIndex = 1;
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.PowderBlue;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Location = new System.Drawing.Point(12, 287);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(266, 27);
            this.Password.TabIndex = 2;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.LightBlue;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Location = new System.Drawing.Point(12, 168);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(266, 27);
            this.Email.TabIndex = 3;
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.Color.PowderBlue;
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastName.Location = new System.Drawing.Point(522, 47);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(266, 27);
            this.LastName.TabIndex = 4;
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.PowderBlue;
            this.Phone.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Phone.FormattingEnabled = true;
            this.Phone.Location = new System.Drawing.Point(522, 168);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(266, 28);
            this.Phone.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.PowderBlue;
            this.Submit.Location = new System.Drawing.Point(620, 391);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(156, 47);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // CreateUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.FirstName);
            this.Name = "CreateUpdateCustomer";
            this.Text = "UpdateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FirstName;
        private TextBox Password;
        private TextBox Email;
        private TextBox LastName;
        private ComboBox Phone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Submit;
    }
}