using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ExpenseTracker
{
    public partial class AddCategories : Form
    {
        public AddCategories()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string dbFileName = ConnectionDB._DBConnectionInfo;
                //access the files location for our database
                string dbConnectionInfo = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CRANE771\OneDrive\Class\Spring 2019\CITA - 280\ExpenseTracker\Database\ExpenseTrackerDB.accdb; Persist Security Info=False;";
                OleDbConnection dbConnection = new OleDbConnection();
                // this connects you to the databse
                dbConnection.ConnectionString = dbConnectionInfo;
                // opens the file for our database
                dbConnection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = dbConnection;
                // this line above converts your data entry and put it into the form of the database
                command.CommandText = "insert into Categories (CategoryName,Budget) values('" + textBox1.Text + "', '" + textBox2.Text + "')";

                command.ExecuteNonQuery();
                // this messagebox will display if the data has been correctly added too our database
                MessageBox.Show("Data Saved");
                

            }
            catch (Exception ex)
            {
                // this is for our try catch statement the ex gives you an example of where or what the error is
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
