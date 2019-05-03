using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace ExpenseTracker
{
    class ConnectionDB
    {
        public static string _DBFile;
        public static string _DBConnectionInfo;
        public static void DataBaseConnection(string DatabaseFilename)
        { 

            _DBFile = DatabaseFilename;
            _DBConnectionInfo = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\CRANE771\OneDrive\Class\Spring 2019\CITA - 280\ExpenseTracker\Database\ExpenseTrackerDB.accdb; Persist Security Info=False"; 

        }
    }
}
