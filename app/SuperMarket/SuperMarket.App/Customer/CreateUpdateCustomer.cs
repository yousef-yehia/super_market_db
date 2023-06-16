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
using SuperMaker.Database.Commands;
using SuperMaker.Database.Database;
using SuperMaker.Database.Models;

namespace SuperMarket.App.Customer
{
    public partial class CreateUpdateCustomer : Form
    {
        public CreateUpdateCustomer()
        {
            InitializeComponent();
        }

        private bool isCustomer = true;

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = FirstName.Text;
                if (string.IsNullOrEmpty(firstname))
                {
                    MessageBox.Show("Phone or email is required!");
                    return;
                }
                string password = Password.Text;
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Password is required !");
                    return;
                }
                string lastname = LastName.Text;
                if (string.IsNullOrEmpty(lastname))
                {
                    MessageBox.Show("Password is required !");
                    return;
                }
                string email = Email.Text;
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Password is required !");
                    return;
                }
                string passwrd = Password.Text;
                if (string.IsNullOrEmpty(passwrd))
                {
                    MessageBox.Show("Password is required !");
                    return;
                }
                var db = new SuperMarketDB();
                db.OpenConnection();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Coludn't complete your request !");
            }
        }
    }
}
