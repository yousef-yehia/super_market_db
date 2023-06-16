using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using SuperMaker.Database.Commands;
using SuperMaker.Database.Database;
using SuperMaker.Database.Models;

namespace SuperMarket.App
{
    public partial class CreateUpdateProduct : Form
    {
        public Product _product ;
        bool x = true;
        public CreateUpdateProduct()
        {
            InitializeComponent();

        }
        public CreateUpdateProduct(int id)
        {
            InitializeComponent();
            x = false;

            GetProduct(id);
            SetProduct();
        }
        private void SetProduct()
        {
            Name.Text = _product.Name;
            Price.TabIndex = (int)_product.Price;
            Description.Text = _product.Description;
            Category.Text = _product.Category;
            Quantity.TabIndex = _product.Quantity;
        }

        private User GetProduct(int id)
        {
            var db = new SuperMarketDB();

            var cmd = db.Command(ProductsCommands.ProductByIdCommand);

            cmd.Parameters.Add(new SqlParameter(ProductsCommandsParams.Id, SqlDbType.NVarChar)
            { Value = id });

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return User.CreateFromReader(reader);
                }
            }
            db.CloseConnection();
            return null;
        }


        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Name.Text;
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("name is required!");
                    return;
                }
                string prc = Price.Text;
                int price = Price.TabIndex;
                if (string.IsNullOrEmpty(prc))
                {
                    MessageBox.Show("price is required !");
                    return;
                }
                string description = Description.Text;
                if (string.IsNullOrEmpty(description))
                {
                    MessageBox.Show("description is required !");
                    return;
                }
                string category = Category.Text;
                if (string.IsNullOrEmpty(category))
                {
                    MessageBox.Show("category is required !");
                    return;
                }
                string quant = Quantity.Text;
                int quantity = Quantity.TabIndex;
                if (string.IsNullOrEmpty(quant))
                {
                    MessageBox.Show("quantity is required !");
                    return;
                }

                if (x == true)
                {
                    CreateProduct(name, price, description, category, quantity);
                }
                else if (x == false)
                {
                    UpdateProduct(name, price, description, category, quantity);
                }
                var db = new SuperMarketDB();
                db.OpenConnection();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Coludn't complete your request !");
            }
        }

        private void CreateProduct(string name, int price, string description, string category, int quantity)
        {
            var db = new SuperMarketDB();

            var cmd = db.Command(ProductsCommands.ProductToCreate);

            cmd.Parameters.Add(new SqlParameter(ProductsCommandsParams.Name, SqlDbType.NVarChar)
            { Value = name });
            cmd.Parameters.Add(new SqlParameter(ProductsCommandsParams.Price, SqlDbType.NVarChar)
            { Value = price });
            cmd.Parameters.Add(new SqlParameter(ProductsCommandsParams.Description, SqlDbType.NVarChar)
            { Value = description });
            cmd.Parameters.Add(new SqlParameter(ProductsCommandsParams.Category_Id, SqlDbType.NVarChar)
            { Value = category });
            cmd.Parameters.Add(new SqlParameter(ProductsCommandsParams.Quantity, SqlDbType.NVarChar)
            { Value = quantity });

            db.CloseConnection();
        }

        private void UpdateProduct(string name, int price, string description, string category, int quantity)
        {

            var db = new SuperMarketDB();

            var cmd = db.Command(ProductsCommands.ProductToUpdate);

            cmd.Parameters.Add(new SqlParameter(ProductsCommandsParams.Name, SqlDbType.NVarChar)
            { Value = name });
            cmd.Parameters.Add(new SqlParameter(ProductsCommandsParams.Price, SqlDbType.NVarChar)
            { Value = price });
            cmd.Parameters.Add(new SqlParameter(ProductsCommandsParams.Description, SqlDbType.NVarChar)
            { Value = description });
            cmd.Parameters.Add(new SqlParameter(ProductsCommandsParams.Category_Id, SqlDbType.NVarChar)
            { Value = category });
            cmd.Parameters.Add(new SqlParameter(ProductsCommandsParams.Quantity, SqlDbType.NVarChar)
            { Value = quantity });

            db.CloseConnection();
        }
    }
}
