using MySql.Data.MySqlClient;
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
    public partial class SearchRecipeForm : Form
    {
        public SearchRecipeForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=recipebookdb;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT r.Id, r.Name 
                        FROM Recipes r
                        JOIN RecipeIngredients ri ON r.Id = ri.RecipeId
                        JOIN Ingredients i ON ri.IngredientId = i.Id
                        WHERE i.Name LIKE @ingredient";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ingredient", "%" + txtSearch.Text + "%");
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            lstResults.Items.Clear();
                            while (reader.Read())
                            {
                                lstResults.Items.Add(new RecipeItem
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Name = reader["Name"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Виникла помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private class RecipeItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstResults.SelectedItem != null)
            {
                var selectedRecipe = lstResults.SelectedItem as RecipeItem;
                if (selectedRecipe != null)
                {
                    RecipeDetailsForm detailsForm = new RecipeDetailsForm(selectedRecipe.Id);
                    detailsForm.StartPosition = FormStartPosition.CenterScreen;
                    detailsForm.ShowDialog();
                }
            }
        }
    }
}
