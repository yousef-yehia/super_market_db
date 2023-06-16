namespace SuperMarket.App
{
    partial class AdminHome
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
            this.Products = new System.Windows.Forms.Button();
            this.Customers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.PowderBlue;
            this.Products.Location = new System.Drawing.Point(12, 28);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(187, 36);
            this.Products.TabIndex = 0;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = false;
            // 
            // Customers
            // 
            this.Customers.BackColor = System.Drawing.Color.PowderBlue;
            this.Customers.Location = new System.Drawing.Point(12, 100);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(187, 35);
            this.Customers.TabIndex = 1;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = false;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.Products);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Products;
        private Button Customers;
    }
}