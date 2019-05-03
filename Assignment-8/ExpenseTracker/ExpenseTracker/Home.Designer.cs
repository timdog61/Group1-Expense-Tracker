namespace ExpenseTracker
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.expenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expenseToolStripMenuItem,
            this.categoriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // expenseToolStripMenuItem
            // 
            this.expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            this.expenseToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.expenseToolStripMenuItem.Text = "Expense";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoriesToolStripMenuItem,
            this.displayAllCategoriesToolStripMenuItem});
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // addCategoriesToolStripMenuItem
            // 
            this.addCategoriesToolStripMenuItem.Name = "addCategoriesToolStripMenuItem";
            this.addCategoriesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addCategoriesToolStripMenuItem.Text = "Add Categories";
            this.addCategoriesToolStripMenuItem.Click += new System.EventHandler(this.AddCategoriesToolStripMenuItem_Click);
            // 
            // displayAllCategoriesToolStripMenuItem
            // 
            this.displayAllCategoriesToolStripMenuItem.Name = "displayAllCategoriesToolStripMenuItem";
            this.displayAllCategoriesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.displayAllCategoriesToolStripMenuItem.Text = "Display All Categories";
            this.displayAllCategoriesToolStripMenuItem.Click += new System.EventHandler(this.DisplayAllCategoriesToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem expenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllCategoriesToolStripMenuItem;
    }
}