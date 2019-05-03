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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
   
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //insert comment here 
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CRANE771\OneDrive\Class\Spring 2019\CITA - 280\ExpenseTracker\Database\ExpenseTrackerDB.accdb");
            OleDbDataAdapter da;
            DataTable dt = new DataTable();
            da = new OleDbDataAdapter("select * from userInfo where userName='"+usernameTextBox.Text+"' and userPassword='"+passwordTextBox.Text+"'",cn);
            da.Fill(dt);
            if (dt.Rows.Count <=0)
            {
                MessageBox.Show("User Name Or Password are Invalide Please try again");
            }
            else if (dt.Rows.Count > 0)
            {
                Home home_ = new Home();
                home_.Show();
                
            }
        }

        private void New_user_form_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            UserForm user_ = new UserForm();
            user_.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}