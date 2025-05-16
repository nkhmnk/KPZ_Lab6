namespace RecipeBookApp
{
    partial class AddRecipeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCookingTime;
        private System.Windows.Forms.TextBox txtCookingTime;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.TextBox txtTotalCalories;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label lblImageUrl;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.Label lblVideoUrl;
        private System.Windows.Forms.TextBox txtVideoUrl;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.ListBox lstExistingIngredients;
        private System.Windows.Forms.TextBox txtIngredientName;
        private System.Windows.Forms.TextBox txtIngredientAmount;
        private System.Windows.Forms.TextBox txtIngredientCalories;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.ToolTip toolTip;

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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCookingTime = new System.Windows.Forms.Label();
            this.txtCookingTime = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.txtTotalCalories = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.lblImageUrl = new System.Windows.Forms.Label();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.lblVideoUrl = new System.Windows.Forms.Label();
            this.txtVideoUrl = new System.Windows.Forms.TextBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.lstExistingIngredients = new System.Windows.Forms.ListBox();
            this.txtIngredientName = new System.Windows.Forms.TextBox();
            this.txtIngredientAmount = new System.Windows.Forms.TextBox();
            this.txtIngredientCalories = new System.Windows.Forms.TextBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Назва рецепту:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(404, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(737, 25);
            this.txtName.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(20, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(54, 21);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Опис:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(404, 61);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(737, 25);
            this.txtDescription.TabIndex = 3;
            // 
            // lblCookingTime
            // 
            this.lblCookingTime.AutoSize = true;
            this.lblCookingTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCookingTime.Location = new System.Drawing.Point(20, 100);
            this.lblCookingTime.Name = "lblCookingTime";
            this.lblCookingTime.Size = new System.Drawing.Size(157, 21);
            this.lblCookingTime.TabIndex = 4;
            this.lblCookingTime.Text = "Час приготування:";
            // 
            // txtCookingTime
            // 
            this.txtCookingTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCookingTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCookingTime.Location = new System.Drawing.Point(404, 101);
            this.txtCookingTime.Name = "txtCookingTime";
            this.txtCookingTime.Size = new System.Drawing.Size(737, 25);
            this.txtCookingTime.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(20, 140);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 21);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Категорія:";
            // 
            // txtCategory
            // 
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCategory.Location = new System.Drawing.Point(404, 141);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(737, 25);
            this.txtCategory.TabIndex = 7;
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCalories.Location = new System.Drawing.Point(20, 180);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(73, 21);
            this.lblTotalCalories.TabIndex = 8;
            this.lblTotalCalories.Text = "Калорії:";
            // 
            // txtTotalCalories
            // 
            this.txtTotalCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCalories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotalCalories.Location = new System.Drawing.Point(404, 181);
            this.txtTotalCalories.Name = "txtTotalCalories";
            this.txtTotalCalories.Size = new System.Drawing.Size(737, 25);
            this.txtTotalCalories.TabIndex = 9;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInstructions.Location = new System.Drawing.Point(20, 220);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(92, 21);
            this.lblInstructions.TabIndex = 10;
            this.lblInstructions.Text = "Інструкції:";
            // 
            // txtInstructions
            // 
            this.txtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstructions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInstructions.Location = new System.Drawing.Point(404, 221);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(737, 25);
            this.txtInstructions.TabIndex = 11;
            // 
            // lblImageUrl
            // 
            this.lblImageUrl.AutoSize = true;
            this.lblImageUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblImageUrl.Location = new System.Drawing.Point(20, 260);
            this.lblImageUrl.Name = "lblImageUrl";
            this.lblImageUrl.Size = new System.Drawing.Size(147, 21);
            this.lblImageUrl.TabIndex = 12;
            this.lblImageUrl.Text = "URL зображення:";
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImageUrl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtImageUrl.Location = new System.Drawing.Point(404, 261);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(737, 25);
            this.txtImageUrl.TabIndex = 13;
            // 
            // lblVideoUrl
            // 
            this.lblVideoUrl.AutoSize = true;
            this.lblVideoUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblVideoUrl.Location = new System.Drawing.Point(20, 300);
            this.lblVideoUrl.Name = "lblVideoUrl";
            this.lblVideoUrl.Size = new System.Drawing.Size(91, 21);
            this.lblVideoUrl.TabIndex = 14;
            this.lblVideoUrl.Text = "URL відео:";
            // 
            // txtVideoUrl
            // 
            this.txtVideoUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVideoUrl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVideoUrl.Location = new System.Drawing.Point(404, 301);
            this.txtVideoUrl.Name = "txtVideoUrl";
            this.txtVideoUrl.Size = new System.Drawing.Size(737, 25);
            this.txtVideoUrl.TabIndex = 15;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecipe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddRecipe.Location = new System.Drawing.Point(404, 532);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(737, 73);
            this.btnAddRecipe.TabIndex = 21;
            this.btnAddRecipe.Text = "Додати рецепт";
            this.btnAddRecipe.UseVisualStyleBackColor = false;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblIngredients.Location = new System.Drawing.Point(20, 340);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(105, 21);
            this.lblIngredients.TabIndex = 16;
            this.lblIngredients.Text = "Інгредієнти:";
            // 
            // lstIngredients
            // 
            this.lstIngredients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstIngredients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 17;
            this.lstIngredients.Location = new System.Drawing.Point(404, 341);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(737, 87);
            this.lstIngredients.TabIndex = 17;
            this.lstIngredients.SelectedIndexChanged += new System.EventHandler(this.lstIngredients_SelectedIndexChanged);
            // 
            // lstExistingIngredients
            // 
            this.lstExistingIngredients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstExistingIngredients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstExistingIngredients.FormattingEnabled = true;
            this.lstExistingIngredients.ItemHeight = 17;
            this.lstExistingIngredients.Location = new System.Drawing.Point(24, 365);
            this.lstExistingIngredients.Name = "lstExistingIngredients";
            this.lstExistingIngredients.Size = new System.Drawing.Size(350, 240);
            this.lstExistingIngredients.TabIndex = 22;
            this.lstExistingIngredients.DoubleClick += new System.EventHandler(this.lstExistingIngredients_DoubleClick);
            // 
            // txtIngredientName
            // 
            this.txtIngredientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngredientName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIngredientName.Location = new System.Drawing.Point(404, 441);
            this.txtIngredientName.Name = "txtIngredientName";
            this.txtIngredientName.Size = new System.Drawing.Size(405, 25);
            this.txtIngredientName.TabIndex = 18;
            // 
            // txtIngredientAmount
            // 
            this.txtIngredientAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngredientAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIngredientAmount.Location = new System.Drawing.Point(815, 441);
            this.txtIngredientAmount.Name = "txtIngredientAmount";
            this.txtIngredientAmount.Size = new System.Drawing.Size(160, 25);
            this.txtIngredientAmount.TabIndex = 19;
            // 
            // txtIngredientCalories
            // 
            this.txtIngredientCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngredientCalories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIngredientCalories.Location = new System.Drawing.Point(981, 441);
            this.txtIngredientCalories.Name = "txtIngredientCalories";
            this.txtIngredientCalories.Size = new System.Drawing.Size(160, 25);
            this.txtIngredientCalories.TabIndex = 23;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIngredient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddIngredient.Location = new System.Drawing.Point(404, 471);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(737, 30);
            this.btnAddIngredient.TabIndex = 20;
            this.btnAddIngredient.Text = "Додати інгредієнт";
            this.btnAddIngredient.UseVisualStyleBackColor = false;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // AddRecipeForm
            // 
            this.ClientSize = new System.Drawing.Size(1153, 626);
            this.Controls.Add(this.txtIngredientCalories);
            this.Controls.Add(this.lstExistingIngredients);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.txtIngredientAmount);
            this.Controls.Add(this.txtIngredientName);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.txtVideoUrl);
            this.Controls.Add(this.lblVideoUrl);
            this.Controls.Add(this.txtImageUrl);
            this.Controls.Add(this.lblImageUrl);
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
            this.Name = "AddRecipeForm";
            this.Text = "Додати рецепт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
