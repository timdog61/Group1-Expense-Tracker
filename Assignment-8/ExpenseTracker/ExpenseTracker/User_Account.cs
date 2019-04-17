using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    class User_Account
    {
        string username;
        string password;

        public User_Account(string _username, string _password) //constructor
        {
            username = _username;
            password = _password;

        }
        public void msg()
        {
            MessageBox.Show(username);
        }
    }
}
