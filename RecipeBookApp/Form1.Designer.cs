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
            this.btnEditRecipe = new System.Windows.Forms.Button();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnSearchRecipe = new System.Windows.Forms.Button();
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
            // btnEditRecipe
            // 
            this.btnEditRecipe.BackColor = System.Drawing.Color.Khaki;
            this.btnEditRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRecipe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditRecipe.Location = new System.Drawing.Point(34, 639);
            this.btnEditRecipe.Name = "btnEditRecipe";
            this.btnEditRecipe.Size = new System.Drawing.Size(120, 45);
            this.btnEditRecipe.TabIndex = 8;
            this.btnEditRecipe.Text = "Редагувати";
            this.btnEditRecipe.UseVisualStyleBackColor = false;
            this.btnEditRecipe.Click += new System.EventHandler(this.btnEditRecipe_Click);
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRecipe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteRecipe.Location = new System.Drawing.Point(171, 639);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(120, 45);
            this.btnDeleteRecipe.TabIndex = 9;
            this.btnDeleteRecipe.Text = "Видалити";
            this.btnDeleteRecipe.UseVisualStyleBackColor = false;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecipe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddRecipe.Location = new System.Drawing.Point(307, 639);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(150, 45);
            this.btnAddRecipe.TabIndex = 10;
            this.btnAddRecipe.Text = "Додати рецепт";
            this.btnAddRecipe.UseVisualStyleBackColor = false;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnSearchRecipe
            // 
            this.btnSearchRecipe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearchRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRecipe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchRecipe.Location = new System.Drawing.Point(473, 639);
            this.btnSearchRecipe.Name = "btnSearchRecipe";
            this.btnSearchRecipe.Size = new System.Drawing.Size(150, 45);
            this.btnSearchRecipe.TabIndex = 11;
            this.btnSearchRecipe.Text = "Пошук рецепту";
            this.btnSearchRecipe.UseVisualStyleBackColor = false;
            this.btnSearchRecipe.Click += new System.EventHandler(this.btnSearchRecipe_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.btnSearchRecipe);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.btnEditRecipe);
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
        private Button btnEditRecipe;
        private Button btnDeleteRecipe;
        private Button btnAddRecipe;
        private Button btnSearchRecipe;
    }
}
