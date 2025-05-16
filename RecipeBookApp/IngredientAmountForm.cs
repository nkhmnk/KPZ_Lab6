using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBookApp
{
    public partial class IngredientAmountForm : Form
    {
        public string IngredientName { get; set; }
        public string IngredientAmount { get; set; }

        public IngredientAmountForm(string ingredientName)
        {
            InitializeComponent();
            lblIngredientName.Text = $"Інгредієнт: {ingredientName}";
            IngredientName = ingredientName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IngredientAmount = txtIngredientAmount.Text;
            if (string.IsNullOrWhiteSpace(IngredientAmount))
            {
                MessageBox.Show("Будь ласка, введіть кількість грам.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
