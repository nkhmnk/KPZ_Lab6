namespace RecipeBookApp
{
    partial class EditRecipeForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtTotalCalories = new System.Windows.Forms.TextBox();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCookingTime = new System.Windows.Forms.TextBox();
            this.lblCookingTime = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(255, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(533, 98);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtInstructions
            // 
            this.txtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstructions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInstructions.Location = new System.Drawing.Point(255, 256);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(533, 25);
            this.txtInstructions.TabIndex = 24;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInstructions.Location = new System.Drawing.Point(12, 256);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(77, 19);
            this.lblInstructions.TabIndex = 23;
            this.lblInstructions.Text = "Інструкції";
            // 
            // txtTotalCalories
            // 
            this.txtTotalCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCalories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotalCalories.Location = new System.Drawing.Point(255, 216);
            this.txtTotalCalories.Name = "txtTotalCalories";
            this.txtTotalCalories.Size = new System.Drawing.Size(533, 25);
            this.txtTotalCalories.TabIndex = 22;
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalCalories.Location = new System.Drawing.Point(12, 216);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(60, 19);
            this.lblTotalCalories.TabIndex = 21;
            this.lblTotalCalories.Text = "Калорії";
            // 
            // txtCategory
            // 
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCategory.Location = new System.Drawing.Point(255, 176);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(533, 25);
            this.txtCategory.TabIndex = 20;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(12, 176);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(76, 19);
            this.lblCategory.TabIndex = 19;
            this.lblCategory.Text = "Категорія";
            // 
            // txtCookingTime
            // 
            this.txtCookingTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCookingTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCookingTime.Location = new System.Drawing.Point(255, 136);
            this.txtCookingTime.Name = "txtCookingTime";
            this.txtCookingTime.Size = new System.Drawing.Size(533, 25);
            this.txtCookingTime.TabIndex = 18;
            // 
            // lblCookingTime
            // 
            this.lblCookingTime.AutoSize = true;
            this.lblCookingTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCookingTime.Location = new System.Drawing.Point(12, 136);
            this.lblCookingTime.Name = "lblCookingTime";
            this.lblCookingTime.Size = new System.Drawing.Size(136, 19);
            this.lblCookingTime.TabIndex = 17;
            this.lblCookingTime.Text = "Час приготування";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(255, 96);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(533, 25);
            this.txtDescription.TabIndex = 16;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(12, 96);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(45, 19);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Опис";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(255, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(533, 25);
            this.txtName.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(12, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 19);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Назва рецепту";
            // 
            // EditRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 421);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtTotalCalories);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCookingTime);
            this.Controls.Add(this.lblCookingTime);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "EditRecipeForm";
            this.Text = "EditRecipeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtTotalCalories;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCookingTime;
        private System.Windows.Forms.Label lblCookingTime;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}