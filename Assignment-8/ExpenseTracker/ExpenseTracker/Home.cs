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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AddCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategories addCategories = new AddCategories();
            addCategories.Show();
        }

        private void DisplayAllCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAllCategories displayAllCategories = new DisplayAllCategories();
            displayAllCategories.Show();
        }
    }
}
