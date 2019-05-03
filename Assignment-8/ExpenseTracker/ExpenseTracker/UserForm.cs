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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            addressTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            emailAddressTextBox.Text = "";
            reEmailAddressTextBox.Text = "";
            incomeTextBox.Text = "";
            dailyBudgetTextBox.Text = "";
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";
            rePasswordTextBox.Text = "";
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                string dbConnectionInfo = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CRANE771\OneDrive\Class\Spring 2019\CITA - 280\ExpenseTracker\Database\ExpenseTrackerDB.accdb; Persist Security Info=False;";
                OleDbConnection dbConnection = new OleDbConnection();
                dbConnection.ConnectionString = dbConnectionInfo;
                dbConnection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = dbConnection;
                command.CommandText = "insert into userAccount (Username, FirstName, LastName, Address, PhoneNumber, Income, DailyBudget) values('" + userNameTextBox.Text  + "','" + firstNameTextBox.Text + "', '" + lastNameTextBox.Text + "', '" + addressTextBox.Text + "', '" + phoneNumberTextBox.Text + "', '" + incomeTextBox.Text + "', '" + dailyBudgetTextBox.Text + "')";
                command.ExecuteNonQuery();
                command.CommandText = "insert into userInfo (userName, userPassword) Values('" + userNameTextBox.Text + "', '" + passwordTextBox.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("You can now login");
            }
            catch (Exception ex)
            {
                // this is for our try catch statement the ex gives you an example of where or what the error is
                MessageBox.Show("Error " + ex.Message);
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
