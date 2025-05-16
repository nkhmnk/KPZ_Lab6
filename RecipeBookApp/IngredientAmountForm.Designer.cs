namespace RecipeBookApp
{
    partial class IngredientAmountForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtIngredientAmount = new System.Windows.Forms.TextBox();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.LightGreen;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOk.Location = new System.Drawing.Point(425, 32);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 30);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtIngredientAmount
            // 
            this.txtIngredientAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIngredientAmount.Location = new System.Drawing.Point(29, 36);
            this.txtIngredientAmount.Name = "txtIngredientAmount";
            this.txtIngredientAmount.Size = new System.Drawing.Size(371, 25);
            this.txtIngredientAmount.TabIndex = 4;
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.AutoSize = true;
            this.lblIngredientName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblIngredientName.Location = new System.Drawing.Point(25, 12);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(146, 21);
            this.lblIngredientName.TabIndex = 3;
            this.lblIngredientName.Text = "Інгредієнт: Назва";
            // 
            // IngredientAmountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 93);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtIngredientAmount);
            this.Controls.Add(this.lblIngredientName);
            this.Name = "IngredientAmountForm";
            this.Text = "IngredientAmountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtIngredientAmount;
        private System.Windows.Forms.Label lblIngredientName;
    }
}