using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            User_Account login = new User_Account(textBox1.Text, textBox2.Text);
            login.msg();
        }

        private void New_user_form_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserForm user_ = new UserForm();
            user_.Show();
        }
    }
}