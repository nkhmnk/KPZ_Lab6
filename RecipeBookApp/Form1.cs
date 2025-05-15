using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace RecipeBookApp
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=recipebookdb;Uid=root;Pwd=;";
        private int loggedInUserId;
        private Button activeCategoryButton = null;

        public Form1(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Успішне з'єднання з базою даних.");
                    LoadRecipes();
                    LoadCategories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка з'єднання: {ex.Message}");
                }
            }
        }

        private void LoadCategories()
        {
            pnlCategories.Controls.Clear();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT Category FROM Recipes";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        int buttonY = 70;
                        while (reader.Read())
                        {
                            string category = reader["Category"].ToString();
                            Button btnCategory = new Button
                            {
                                Text = category,
                                BackColor = System.Drawing.Color.LightGray,
                                FlatStyle = FlatStyle.Flat,
                                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                                Location = new System.Drawing.Point(3, buttonY),
                                Size = new System.Drawing.Size(194, 50)
                            };
                            btnCategory.Click += (s, e) => {
                                LoadRecipes(category);
                                HighlightActiveButton(btnCategory);
                            };
                            pnlCategories.Controls.Add(btnCategory);
                            buttonY += 60;
                        }
                    }
                }
            }

            // всі категорії
            Button btnAllCategories = new Button
            {
                Text = "Усі категорії",
                BackColor = System.Drawing.Color.LightGray,
                FlatStyle = FlatStyle.Flat,
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(3, 10),
                Size = new System.Drawing.Size(194, 50)
            };
            btnAllCategories.Click += (s, e) => {
                LoadRecipes();
                HighlightActiveButton(btnAllCategories);
            };
            pnlCategories.Controls.Add(btnAllCategories);
        }

        private void LoadRecipes(string category = null)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Name AS 'Назва рецепту', Category AS 'Категорія', CookingTime AS 'Час приготування', TotalCalories AS 'Калорії' FROM Recipes";
                if (category != null)
                {
                    query += " WHERE Category = @category";
                }
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    if (category != null)
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@category", category);
                    }
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvRecipes.DataSource = dataTable;
                    dgvRecipes.Columns["Id"].Visible = false;
                }
            }
        }

        private void LoadRecipes()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Name AS 'Назва рецепту', Category AS 'Категорія', CookingTime AS 'Час приготування', TotalCalories AS 'Калорії'" +
                    " FROM Recipes";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvRecipes.DataSource = dataTable;
                    dgvRecipes.Columns["Id"].Visible = false;  
                }
            }
        } 


        private void HighlightActiveButton(Button activeButton)
        {
            if (activeCategoryButton != null)
            {
                activeCategoryButton.BackColor = System.Drawing.Color.LightGray;
            }

            activeCategoryButton = activeButton;
            activeCategoryButton.BackColor = System.Drawing.Color.LightBlue;
        }

    
    }
}
