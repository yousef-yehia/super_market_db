namespace SuperMarket.App.Category
{
    partial class CategoryList
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
            this.Showmostselling = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // Showmostselling
            // 
            this.Showmostselling.BackColor = System.Drawing.Color.PowderBlue;
            this.Showmostselling.Location = new System.Drawing.Point(12, 22);
            this.Showmostselling.Name = "Showmostselling";
            this.Showmostselling.Size = new System.Drawing.Size(173, 32);
            this.Showmostselling.TabIndex = 0;
            this.Showmostselling.Text = "Show most selling";
            this.Showmostselling.UseVisualStyleBackColor = false;
            this.Showmostselling.Click += new System.EventHandler(this.Showmostselling_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name});
            this.listView1.Location = new System.Drawing.Point(12, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 327);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 755;
            // 
            // CategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Showmostselling);
            this.Name = "CategoryList";
            this.Text = "CategoryList";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Showmostselling;
        private ListView listView1;
        private ColumnHeader Name;
    }
}