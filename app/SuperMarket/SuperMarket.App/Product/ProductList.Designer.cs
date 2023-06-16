namespace SuperMarket.App
{
    partial class ProductList
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
            this.delete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.Category = new System.Windows.Forms.ColumnHeader();
            this.WithHighestPurchasethismonth = new System.Windows.Forms.Button();
            this.Hastpurchasedinayear = new System.Windows.Forms.Button();
            this.MostFrequent = new System.Windows.Forms.Button();
            this.Numberofcustomers = new System.Windows.Forms.ColumnHeader();
            this.NotBoughtMonth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.PowderBlue;
            this.delete.Location = new System.Drawing.Point(616, 393);
            this.delete.Location = new System.Drawing.Point(665, 396);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(74, 43);
            this.delete.Size = new System.Drawing.Size(123, 42);
            this.delete.TabIndex = 13;
            this.delete.Text = "Delete ";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 413);
            this.button3.Location = new System.Drawing.Point(697, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.PowderBlue;
            this.edit.Location = new System.Drawing.Point(486, 393);
            this.edit.Location = new System.Drawing.Point(503, 396);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(123, 43);
            this.edit.Size = new System.Drawing.Size(123, 42);
            this.edit.TabIndex = 11;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            // 
            // List
            // 
            this.List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Price,
            this.Description,
            this.Category,
            this.Numberofcustomers,
            this.Quantity});
            this.List.Location = new System.Drawing.Point(11, 139);
            this.Numberofcustomers});
            this.List.Location = new System.Drawing.Point(12, 138);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(777, 233);
            this.List.Size = new System.Drawing.Size(776, 234);
            this.List.TabIndex = 10;
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 155;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 155;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 155;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 155;
            // 
            // WithHighestPurchasethismonth
            // 
            this.WithHighestPurchasethismonth.BackColor = System.Drawing.Color.PowderBlue;
            this.WithHighestPurchasethismonth.Location = new System.Drawing.Point(545, 28);
            this.WithHighestPurchasethismonth.Name = "WithHighestPurchasethismonth";
            this.WithHighestPurchasethismonth.Size = new System.Drawing.Size(243, 42);
            this.WithHighestPurchasethismonth.TabIndex = 9;
            this.WithHighestPurchasethismonth.Text = "With Highest Purchase this month";
            this.WithHighestPurchasethismonth.UseVisualStyleBackColor = false;
            // 
            // Hastpurchasedinayear
            // 
            this.Hastpurchasedinayear.BackColor = System.Drawing.Color.PowderBlue;
            this.Hastpurchasedinayear.Location = new System.Drawing.Point(281, 28);
            this.Hastpurchasedinayear.Name = "Hastpurchasedinayear";
            this.Hastpurchasedinayear.Size = new System.Drawing.Size(243, 42);
            this.Hastpurchasedinayear.TabIndex = 8;
            this.Hastpurchasedinayear.Text = "Has\'t purchased in a year";
            this.Hastpurchasedinayear.UseVisualStyleBackColor = false;
            // 
            // MostFrequent
            // 
            this.HasNoCustomers.BackColor = System.Drawing.Color.PowderBlue;
            this.HasNoCustomers.Location = new System.Drawing.Point(438, 28);
            this.HasNoCustomers.Name = "HasNoCustomers";
            this.HasNoCustomers.Size = new System.Drawing.Size(338, 47);
            this.HasNoCustomers.TabIndex = 9;
            this.HasNoCustomers.Text = "Has No Customers For Month";
            this.HasNoCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HasNoCustomers.UseVisualStyleBackColor = false;
            this.HasNoCustomers.Click += new System.EventHandler(this.WithHighestPurchasethismonth_Click);
            this.MostFrequent.BackColor = System.Drawing.Color.PowderBlue;
            this.MostFrequent.Location = new System.Drawing.Point(12, 28);
            this.MostFrequent.Name = "MostFrequent";
            this.MostFrequent.Size = new System.Drawing.Size(243, 42);
            this.MostFrequent.TabIndex = 7;
            this.MostFrequent.Text = "Most Frequent";
            this.MostFrequent.UseVisualStyleBackColor = false;
            // 
            // Numberofcustomers
            // 
            this.MostBought.BackColor = System.Drawing.Color.PowderBlue;
            this.MostBought.Location = new System.Drawing.Point(152, 28);
            this.MostBought.Name = "MostBought";
            this.MostBought.Size = new System.Drawing.Size(130, 43);
            this.MostBought.TabIndex = 8;
            this.MostBought.Text = "Most Bought";
            this.MostBought.UseVisualStyleBackColor = false;
            this.MostBought.Click += new System.EventHandler(this.MostBought_Click);
            this.Numberofcustomers.Text = "Number of customers\n";
            this.Numberofcustomers.Width = 155;
            // 
            // NotBoughtMonth
            // 
            this.ToRestock.BackColor = System.Drawing.Color.PowderBlue;
            this.ToRestock.Location = new System.Drawing.Point(11, 28);
            this.ToRestock.Name = "ToRestock";
            this.ToRestock.Size = new System.Drawing.Size(134, 43);
            this.ToRestock.TabIndex = 7;
            this.ToRestock.Text = "To Restock";
            this.ToRestock.UseVisualStyleBackColor = false;
            this.ToRestock.Click += new System.EventHandler(this.ToRestock_Click);
            // 
            // month
            // 
            this.month.FormattingEnabled = true;
            this.month.Location = new System.Drawing.Point(642, 36);
            this.month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(119, 28);
            this.month.TabIndex = 14;
            this.month.SelectedIndexChanged += new System.EventHandler(this.month_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.PowderBlue;
            this.Back.Location = new System.Drawing.Point(714, 393);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(74, 43);
            this.Back.TabIndex = 15;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.PowderBlue;
            this.Add.Location = new System.Drawing.Point(413, 393);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(66, 43);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            this.NotBoughtMonth.Location = new System.Drawing.Point(281, 90);
            this.NotBoughtMonth.Name = "NotBoughtMonth";
            this.NotBoughtMonth.Size = new System.Drawing.Size(243, 27);
            this.NotBoughtMonth.TabIndex = 14;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.month);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NotBoughtMonth);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.List);
            this.Controls.Add(this.HasNoCustomers);
            this.Controls.Add(this.MostBought);
            this.Controls.Add(this.ToRestock);
            this.Name = "ProductList";
            this.Controls.Add(this.WithHighestPurchasethismonth);
            this.Controls.Add(this.Hastpurchasedinayear);
            this.Controls.Add(this.MostFrequent);
            this.Name = "ProductList";
            this.Text = "ProductList";
            this.ResumeLayout(false);

        }

        #endregion

        private Button delete;
        private Button button3;
        private Button edit;
        private ListView List;
        private ColumnHeader Name;
        private ColumnHeader Price;
        private ColumnHeader Description;
        private ColumnHeader Category;
        private ColumnHeader Numberofcustomers;
        private Button WithHighestPurchasethismonth;
        private Button Hastpurchasedinayear;
        private Button MostFrequent;
        private DateTimePicker NotBoughtMonth;
    }
}