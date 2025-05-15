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
    public partial class RecipeDetailsForm : Form
    {
        private int recipeId;

        public RecipeDetailsForm(int id)
        {
            InitializeComponent();
            recipeId = id;
            LoadRecipeDetails();
        }

        private void LoadRecipeDetails()
        {
            string connectionString = "Server=localhost;Database=recipebookdb;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT r.Name, r.Description, r.CookingTime, r.Category, r.TotalCalories, r.CookingInstructions, r.VideoUrl, r.ImageUrl, " +
                               "GROUP_CONCAT(i.Name, ' ', ri.Quantity) AS Ingredients " +
                               "FROM Recipes r " +
                               "JOIN RecipeIngredients ri ON r.Id = ri.RecipeId " +
                               "JOIN Ingredients i ON ri.IngredientId = i.Id " +
                               "WHERE r.Id = @recipeId " +
                               "GROUP BY r.Id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@recipeId", recipeId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblName.Text = "Назва рецепту: " + reader["Name"].ToString();
                            lblDescription.Text = "Опис: " + reader["Description"].ToString();
                            lblCookingTime.Text = "Час приготування: " + reader["CookingTime"].ToString() + " хв";
                            lblCategory.Text = "Категорія: " + reader["Category"].ToString();
                            lblTotalCalories.Text = "Калорії: " + reader["TotalCalories"].ToString();
                            lblInstructions.Text = "Інструкції: " + reader["CookingInstructions"].ToString();
                            lblIngredients.Text = "Інгредієнти: " + reader["Ingredients"].ToString();
                            pictureBoxRecipe.ImageLocation = reader["ImageUrl"].ToString();
                            linkLabelVideo.Tag = reader["VideoUrl"].ToString();
                        }
                    }
                }

             
            }
        }

        private void linkLabelVideo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabelVideo.Tag.ToString());
        }
    }
}
