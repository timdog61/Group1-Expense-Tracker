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
    public partial class DisplayAllCategories : Form
    {
        public DisplayAllCategories()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try 
            {
                string mySql = "SELECT* FROM Categories ORDER BY ID ASC";

                OleDbConnection db = new OleDbConnection();
                
                db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CRANE771\OneDrive\Class\Spring 2019\CITA - 280\ExpenseTracker\Database\ExpenseTrackerDB.accdb; Persist Security Info=False;";
                // this opens the database
                db.Open();

                OleDbCommand cmd = new OleDbCommand(mySql, db);



                OleDbDataAdapter adapter = new OleDbDataAdapter(mySql, db);
                DataSet ds = new DataSet(); //

                adapter.Fill(ds);


                DataTable dt = ds.Tables["TABLE"];

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                dataGridView1.DataSource = bindingSource;
                adapter.Update(ds);

                
                db.Close();
            }
            catch
            {
                
                MessageBox.Show("You need to go help and test the connection to the database!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //sets the data to null
            dataGridView1.DataSource = null;
            //clears the database rows
            dataGridView1.Rows.Clear();


        }
    }
}
