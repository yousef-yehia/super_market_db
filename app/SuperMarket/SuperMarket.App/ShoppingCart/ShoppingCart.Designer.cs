namespace SuperMarket.App.ShoppingCart
{
    partial class ShoppingCart
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
            this.Clear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.PowderBlue;
            this.Clear.Location = new System.Drawing.Point(665, 388);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(123, 42);
            this.Clear.TabIndex = 21;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 20;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.PowderBlue;
            this.Remove.Location = new System.Drawing.Point(503, 388);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(123, 42);
            this.Remove.TabIndex = 19;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            // 
            // Products
            // 
            this.Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Price});
            this.Products.Location = new System.Drawing.Point(12, 117);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(776, 234);
            this.Products.TabIndex = 18;
            this.Products.UseCompatibleStateImageBehavior = false;
            this.Products.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 388;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 388;
            // 
            // CreateOrder
            // 
            this.CreateOrder.BackColor = System.Drawing.Color.PowderBlue;
            this.CreateOrder.Location = new System.Drawing.Point(12, 36);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(123, 42);
            this.CreateOrder.TabIndex = 22;
            this.CreateOrder.Text = "Create Order";
            this.CreateOrder.UseVisualStyleBackColor = false;
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateOrder);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Products);
            this.Name = "ShoppingCart";
            this.Text = "ShoppingCart";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Clear;
        private Button button3;
        private Button Remove;
        private ListView Products;
        private ColumnHeader Name;
        private ColumnHeader Price;
        private Button CreateOrder;
    }
}