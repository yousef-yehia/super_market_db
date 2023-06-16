namespace SuperMarket.App
{
    partial class CustomerList
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
            this.MostFrequent = new System.Windows.Forms.Button();
            this.Hastpurchasedinayear = new System.Windows.Forms.Button();
            this.WithHighestPurchasethismonth = new System.Windows.Forms.Button();
            this.customersList = new System.Windows.Forms.ListView();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.LastName = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.Phone = new System.Windows.Forms.ColumnHeader();
            this.edit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MostFrequent
            // 
            this.MostFrequent.BackColor = System.Drawing.Color.PowderBlue;
            this.MostFrequent.Location = new System.Drawing.Point(12, 21);
            this.MostFrequent.Name = "MostFrequent";
            this.MostFrequent.Size = new System.Drawing.Size(243, 42);
            this.MostFrequent.TabIndex = 0;
            this.MostFrequent.Text = "Most Frequent";
            this.MostFrequent.UseVisualStyleBackColor = false;
            // 
            // Hastpurchasedinayear
            // 
            this.Hastpurchasedinayear.BackColor = System.Drawing.Color.PowderBlue;
            this.Hastpurchasedinayear.Location = new System.Drawing.Point(281, 21);
            this.Hastpurchasedinayear.Name = "Hastpurchasedinayear";
            this.Hastpurchasedinayear.Size = new System.Drawing.Size(243, 42);
            this.Hastpurchasedinayear.TabIndex = 1;
            this.Hastpurchasedinayear.Text = "Has\'t purchased in a year";
            this.Hastpurchasedinayear.UseVisualStyleBackColor = false;
            // 
            // WithHighestPurchasethismonth
            // 
            this.WithHighestPurchasethismonth.BackColor = System.Drawing.Color.PowderBlue;
            this.WithHighestPurchasethismonth.Location = new System.Drawing.Point(545, 21);
            this.WithHighestPurchasethismonth.Name = "WithHighestPurchasethismonth";
            this.WithHighestPurchasethismonth.Size = new System.Drawing.Size(243, 42);
            this.WithHighestPurchasethismonth.TabIndex = 2;
            this.WithHighestPurchasethismonth.Text = "With Highest Purchase this month";
            this.WithHighestPurchasethismonth.UseVisualStyleBackColor = false;
            // 
            // customersList
            // 
            this.customersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.Email,
            this.Phone});
            this.customersList.Location = new System.Drawing.Point(12, 91);
            this.customersList.Name = "customersList";
            this.customersList.Size = new System.Drawing.Size(776, 257);
            this.customersList.TabIndex = 3;
            this.customersList.UseCompatibleStateImageBehavior = false;
            this.customersList.View = System.Windows.Forms.View.Details;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 194;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 194;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 194;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 194;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.PowderBlue;
            this.edit.Location = new System.Drawing.Point(508, 371);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(123, 42);
            this.edit.TabIndex = 4;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.PowderBlue;
            this.delete.Location = new System.Drawing.Point(665, 371);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(123, 42);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete ";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.customersList);
            this.Controls.Add(this.WithHighestPurchasethismonth);
            this.Controls.Add(this.Hastpurchasedinayear);
            this.Controls.Add(this.MostFrequent);
            this.Name = "CustomerList";
            this.Text = "CustomersList";
            this.ResumeLayout(false);

        }

        #endregion

        private Button MostFrequent;
        private Button Hastpurchasedinayear;
        private Button WithHighestPurchasethismonth;
        private ListView customersList;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Email;
        private ColumnHeader Phone;
        private Button edit;
        private Button button3;
        private Button delete;
    }
}