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
    public partial class EditRecipeForm : Form
    {
        private int recipeId;
        private string connectionString = "Server=localhost;Database=recipebookdb;Uid=root;Pwd=;";

        public EditRecipeForm(int id)
        {
            InitializeComponent();
            recipeId = id;
            LoadRecipeDetails();
        }

        private void LoadRecipeDetails()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Name, Description, CookingTime, Category, TotalCalories, CookingInstructions FROM Recipes WHERE Id = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", recipeId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["Name"].ToString();
                            txtDescription.Text = reader["Description"].ToString();
                            txtCookingTime.Text = reader["CookingTime"].ToString();
                            txtCategory.Text = reader["Category"].ToString();
                            txtTotalCalories.Text = reader["TotalCalories"].ToString();
                            txtInstructions.Text = reader["CookingInstructions"].ToString();
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string description = txtDescription.Text;
                int cookingTime = int.Parse(txtCookingTime.Text);
                string category = txtCategory.Text;
                int totalCalories = int.Parse(txtTotalCalories.Text);
                string instructions = txtInstructions.Text;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        UPDATE Recipes 
                        SET Name = @name, Description = @description, CookingTime = @cookingTime, 
                            Category = @category, TotalCalories = @totalCalories, CookingInstructions = @instructions 
                        WHERE Id = @id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", recipeId);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@cookingTime", cookingTime);
                        command.Parameters.AddWithValue("@category", category);
                        command.Parameters.AddWithValue("@totalCalories", totalCalories);
                        command.Parameters.AddWithValue("@instructions", instructions);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Рецепт успішно оновлено!", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Помилка формату даних: {ex.Message}", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
