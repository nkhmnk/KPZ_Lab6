namespace RecipeBookApp
{
    partial class RecipeDetailsForm
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
            this.linkLabelVideo = new System.Windows.Forms.LinkLabel();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCookingTime = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBoxRecipe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelVideo
            // 
            this.linkLabelVideo.AutoSize = true;
            this.linkLabelVideo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabelVideo.Location = new System.Drawing.Point(12, 236);
            this.linkLabelVideo.Name = "linkLabelVideo";
            this.linkLabelVideo.Size = new System.Drawing.Size(225, 21);
            this.linkLabelVideo.TabIndex = 18;
            this.linkLabelVideo.TabStop = true;
            this.linkLabelVideo.Text = "Дивитись відео на YouTube";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblIngredients.Location = new System.Drawing.Point(12, 189);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(105, 21);
            this.lblIngredients.TabIndex = 17;
            this.lblIngredients.Text = "Інгредієнти:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInstructions.Location = new System.Drawing.Point(12, 159);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(92, 21);
            this.lblInstructions.TabIndex = 16;
            this.lblInstructions.Text = "Інструкції:";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCalories.Location = new System.Drawing.Point(12, 129);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(73, 21);
            this.lblTotalCalories.TabIndex = 15;
            this.lblTotalCalories.Text = "Калорії:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(12, 99);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 21);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Категорія:";
            // 
            // lblCookingTime
            // 
            this.lblCookingTime.AutoSize = true;
            this.lblCookingTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCookingTime.Location = new System.Drawing.Point(12, 69);
            this.lblCookingTime.Name = "lblCookingTime";
            this.lblCookingTime.Size = new System.Drawing.Size(157, 21);
            this.lblCookingTime.TabIndex = 13;
            this.lblCookingTime.Text = "Час приготування:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(12, 39);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(54, 21);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Опис:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 21);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Назва рецепту:";
            // 
            // pictureBoxRecipe
            // 
            this.pictureBoxRecipe.Location = new System.Drawing.Point(487, 12);
            this.pictureBoxRecipe.Name = "pictureBoxRecipe";
            this.pictureBoxRecipe.Size = new System.Drawing.Size(457, 403);
            this.pictureBoxRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRecipe.TabIndex = 21;
            this.pictureBoxRecipe.TabStop = false;
            // 
            // RecipeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 496);
            this.Controls.Add(this.pictureBoxRecipe);
            this.Controls.Add(this.linkLabelVideo);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblCookingTime);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Name = "RecipeDetailsForm";
            this.Text = "RecipeDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabelVideo;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCookingTime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBoxRecipe;
    }
}