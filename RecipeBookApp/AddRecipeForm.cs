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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecipeBookApp
{
    public partial class AddRecipeForm : Form
    {
        private List<Tuple<int, string, string, int>> ingredients = new List<Tuple<int, string, string, int>>();

        public AddRecipeForm()
        {
            InitializeComponent();
            LoadExistingIngredients();
            SetupToolTips();
        }

        private void LoadExistingIngredients()
        {
            string connectionString = "Server=localhost;Database=recipebookdb;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id, Name, Calories FROM Ingredients";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("Id");
                                string name = reader.GetString("Name");
                                int calories = reader.GetInt32("Calories");
                                lstExistingIngredients.Items.Add(new Ingredient(id, name, calories));
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

        private void SetupToolTips()
        {
            toolTip.SetToolTip(txtIngredientName, "Назва інгредієнта");
            toolTip.SetToolTip(txtIngredientAmount, "Кількість у грамах");
            toolTip.SetToolTip(txtIngredientCalories, "Калорії на 100 грам");
        }


        private class Ingredient
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Calories { get; set; }

            public Ingredient(int id, string name, int calories)
            {
                Id = id;
                Name = name;
                Calories = calories;
            }

            public override string ToString()
            {
                return $"{Name} - {Calories} калорій";
            }
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            string ingredientName = txtIngredientName.Text.Trim();
            string ingredientAmount = txtIngredientAmount.Text.Trim();
            string ingredientCaloriesText = txtIngredientCalories.Text.Trim();

            if (string.IsNullOrEmpty(ingredientName))
            {
                MessageBox.Show("Будь ласка, введіть назву інгредієнта.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(ingredientAmount) || !int.TryParse(ingredientAmount, out int amount))
            {
                MessageBox.Show("Будь ласка, введіть правильну кількість грамів для інгредієнта.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(ingredientCaloriesText) || !int.TryParse(ingredientCaloriesText, out int ingredientCalories))
            {
                MessageBox.Show("Будь ласка, введіть правильну кількість калорій для інгредієнта.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ingredientId = -1;
            string ingredient = $"{ingredientName} - {ingredientAmount} грам - {ingredientCalories} калорій на 100г";
            ingredients.Add(new Tuple<int, string, string, int>(ingredientId, ingredientName, ingredientAmount, ingredientCalories));
            lstIngredients.Items.Add(ingredient);

            txtIngredientName.Clear();
            txtIngredientAmount.Clear();
            txtIngredientCalories.Clear();
        }

        private void lstExistingIngredients_DoubleClick(object sender, EventArgs e)
        {
            if (lstExistingIngredients.SelectedItem != null)
            {
                var selectedIngredient = (Ingredient)lstExistingIngredients.SelectedItem;
                int ingredientId = selectedIngredient.Id;
                string ingredientName = selectedIngredient.Name;
                int ingredientCalories = selectedIngredient.Calories;

                IngredientAmountForm amountForm = new IngredientAmountForm(ingredientName);
                if (amountForm.ShowDialog() == DialogResult.OK)
                {
                    string ingredientAmount = amountForm.IngredientAmount;
                    string ingredient = $"{ingredientName} - {ingredientAmount} грам - {ingredientCalories} калорій на 100г";
                    ingredients.Add(new Tuple<int, string, string, int>(ingredientId, ingredientName, ingredientAmount, ingredientCalories));
                    lstIngredients.Items.Add(ingredient);
                }
            }
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
                // Перевірка на заповнення обов'язкових полів
                if (string.IsNullOrEmpty(txtName.Text.Trim()) ||
                    string.IsNullOrEmpty(txtDescription.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCookingTime.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCategory.Text.Trim()) ||
                    string.IsNullOrEmpty(txtTotalCalories.Text.Trim()) ||
                    string.IsNullOrEmpty(txtInstructions.Text.Trim()))
                {
                    MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string connectionString = "Server=localhost;Database=recipebookdb;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = @"
                        INSERT INTO Recipes (Name, Description, CookingTime, Category, TotalCalories, CookingInstructions, VideoUrl, ImageUrl)
                        VALUES (@Name, @Description, @CookingTime, @Category, @TotalCalories, @CookingInstructions, @VideoUrl, @ImageUrl);
                        SELECT LAST_INSERT_ID();";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                            command.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                            command.Parameters.AddWithValue("@CookingTime", txtCookingTime.Text.Trim());
                            command.Parameters.AddWithValue("@Category", txtCategory.Text.Trim());
                            command.Parameters.AddWithValue("@TotalCalories", txtTotalCalories.Text.Trim());
                            command.Parameters.AddWithValue("@CookingInstructions", txtInstructions.Text.Trim());
                            command.Parameters.AddWithValue("@VideoUrl", txtVideoUrl.Text.Trim());
                            command.Parameters.AddWithValue("@ImageUrl", txtImageUrl.Text.Trim());

                            int recipeId = Convert.ToInt32(command.ExecuteScalar());

                            foreach (var ingredient in ingredients)
                            {
                                if (ingredient.Item1 == -1)
                                {
                                    string ingredientInsertQuery = @"
                                    INSERT INTO Ingredients (Name, Calories)
                                    VALUES (@Name, @Calories);
                                    SELECT LAST_INSERT_ID();";
                                    using (MySqlCommand ingredientInsertCommand = new MySqlCommand(ingredientInsertQuery, connection))
                                    {
                                        ingredientInsertCommand.Parameters.AddWithValue("@Name", ingredient.Item2);
                                        ingredientInsertCommand.Parameters.AddWithValue("@Calories", ingredient.Item4);
                                        int ingredientId = Convert.ToInt32(ingredientInsertCommand.ExecuteScalar());

                                        string recipeIngredientQuery = @"
                                        INSERT INTO RecipeIngredients (RecipeId, IngredientId, Quantity)
                                        VALUES (@RecipeId, @IngredientId, @Quantity)";
                                        using (MySqlCommand recipeIngredientCommand = new MySqlCommand(recipeIngredientQuery, connection))
                                        {
                                            recipeIngredientCommand.Parameters.AddWithValue("@RecipeId", recipeId);
                                            recipeIngredientCommand.Parameters.AddWithValue("@IngredientId", ingredientId);
                                            recipeIngredientCommand.Parameters.AddWithValue("@Quantity", ingredient.Item3);
                                            recipeIngredientCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                                else
                                {
                                    string recipeIngredientQuery = @"
                                    INSERT INTO RecipeIngredients (RecipeId, IngredientId, Quantity)
                                    VALUES (@RecipeId, @IngredientId, @Quantity)";
                                    using (MySqlCommand recipeIngredientCommand = new MySqlCommand(recipeIngredientQuery, connection))
                                    {
                                        recipeIngredientCommand.Parameters.AddWithValue("@RecipeId", recipeId);
                                        recipeIngredientCommand.Parameters.AddWithValue("@IngredientId", ingredient.Item1);
                                        recipeIngredientCommand.Parameters.AddWithValue("@Quantity", ingredient.Item3);
                                        recipeIngredientCommand.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        MessageBox.Show("Рецепт успішно додано!", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Виникла помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
