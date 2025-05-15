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
    //
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка з'єднання: {ex.Message}");
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

    
    }
}
