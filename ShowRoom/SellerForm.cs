using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShowRoom
{
    public partial class SellerForm : Form
    {
        private SqlCommandBuilder SqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataset = null;
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ShowRoom;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(connectionString);
        public SellerForm()
        {
            InitializeComponent();

        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "showRoomDataSet1.ListProducts". При необходимости она может быть перемещена или удалена.
            

            try
            {
                // Открываем подключение
                connection.Open();
                MessageBox.Show("Вы зашли под учетной записью продавца");
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void AddSale_Click(object sender, EventArgs e)
        {
            AddSale form = new AddSale();
            form.ShowDialog();
            // название процедуры
            string sqlExpression = "AddSales";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            // указываем, что команда представляет хранимую процедуру
            command.CommandType = CommandType.StoredProcedure;
            // параметр для кода продукта
            SqlParameter idProdParam = new SqlParameter
            {
                ParameterName = "@idProduct",
                Value = form.idProduct
            };
                // добавляем параметр
            command.Parameters.Add(idProdParam);
             // параметр для ввода даты
            SqlParameter DateParam = new SqlParameter
            {
                ParameterName = "@DateSale",
                Value = form.DateSale
            };
            command.Parameters.Add(DateParam);
            // параметр для ввода количества
            SqlParameter QuanParam = new SqlParameter
            {
                ParameterName = "@QuantityProd",
                Value = form.QuantityProd
            };
            command.Parameters.Add(QuanParam);
            command.ExecuteNonQuery();

            sqlExpression = "UpdateQuantityProd";
            SqlCommand command1 = new SqlCommand(sqlExpression, connection);
            command1.CommandType = CommandType.StoredProcedure;
            // параметр для кода продукта
            SqlParameter idProdParam1 = new SqlParameter
            {
                ParameterName = "@idProduct",
                Value = form.idProduct
            };
            command1.Parameters.Add(idProdParam1);
            // параметр для ввода количества
            SqlParameter QuanParam1 = new SqlParameter
            {
                ParameterName = "@QuantityProd",
                Value = form.QuantityProd
            };
            command1.Parameters.Add(QuanParam1);
            command1.ExecuteNonQuery();

            MessageBox.Show("Покупка успешно добавлена");
        }

        private void ListSale_Click(object sender, EventArgs e)
        {

            string sqlExpression = "SELECT * FROM ListSales";
            // Создание подключения
            sqlDataAdapter = new SqlDataAdapter(sqlExpression, connection);
            dataset = new DataSet();
            // Заполняем Dataset
            sqlDataAdapter.Fill(dataset, "ListSales");
            // Отображаем данные
            dataGridView1.DataSource = dataset.Tables["ListSales"];
        }
    }
}
