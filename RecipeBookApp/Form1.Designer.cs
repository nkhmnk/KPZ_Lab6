using System;
using System.Windows.Forms;

namespace RecipeBookApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.pnlCategories = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(20, 20);
            this.dgvRecipes.MultiSelect = false;
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.ReadOnly = true;
            this.dgvRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipes.Size = new System.Drawing.Size(1129, 600);
            this.dgvRecipes.TabIndex = 0;
            this.dgvRecipes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipes_CellContentClick);
            this.dgvRecipes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipes_CellDoubleClick);
            // 
            // pnlCategories
            // 
            this.pnlCategories.Location = new System.Drawing.Point(1155, 20);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(200, 600);
            this.pnlCategories.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.dgvRecipes);
            this.Controls.Add(this.pnlCategories);
            this.Name = "Form1";
            this.Text = "Recipe Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.Panel pnlCategories;
    }
}
