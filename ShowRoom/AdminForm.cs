using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowRoom
{
    public partial class AdminForm : Form
    {
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataset = null;
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ShowRoom;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(connectionString);
        public AdminForm()
        {
            InitializeComponent();
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Открываем подключение
                connection.Open();
                MessageBox.Show("Вы зашли под учетной записью администратора");
            }
            catch (SqlException ex)
            {
               MessageBox.Show(ex.Message);
               Application.Exit();
            }
        }

        private void ListShelfs_Click(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT * FROM ListShelfs";
            // Создание подключения
            sqlDataAdapter = new SqlDataAdapter(sqlExpression, connection);
            dataset = new DataSet();
            // Заполняем Dataset
            sqlDataAdapter.Fill(dataset, "ListShelfs");
            // Отображаем данные
            dataGridView1.DataSource = dataset.Tables["ListShelfs"];
        }

        private void ListClients_Click(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT * FROM ListClients";
            // Создание подключения
            sqlDataAdapter = new SqlDataAdapter(sqlExpression, connection);
            dataset = new DataSet();
            // Заполняем Dataset
            sqlDataAdapter.Fill(dataset, "ListClients");
            // Отображаем данные
            dataGridView1.DataSource = dataset.Tables["ListClients"];
        }

        private void ListProducts_Click(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT * FROM ListProducts";
            // Создание подключения
            sqlDataAdapter = new SqlDataAdapter(sqlExpression, connection);
            dataset = new DataSet();
            // Заполняем Dataset
            sqlDataAdapter.Fill(dataset, "ListProducts");
            // Отображаем данные
            dataGridView1.DataSource = dataset.Tables["ListProducts"];
        }

        private void ViewSales_Click(object sender, EventArgs e)
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

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            InputIdClient form = new InputIdClient();
            form.ShowDialog();
            SqlTransaction transaction = connection.BeginTransaction();
            string sqlExpression = "DeleteClient";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.Transaction = transaction;
            // указываем, что команда представляет хранимую процедуру
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter idClientParam = new SqlParameter("@idClient", form.idClient);
            command.Parameters.Add(idClientParam);
            transaction.Commit();
            try
            {
                var result = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GainAllClients_Click(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT * FROM dbo.GainAllClients()";
            // Создание подключения
            sqlDataAdapter = new SqlDataAdapter(sqlExpression, connection);
            dataset = new DataSet();
            // Заполняем Dataset
            sqlDataAdapter.Fill(dataset, "GainAllClients");
            // Отображаем данные
            dataGridView1.DataSource = dataset.Tables["GainAllClients"];
        }

        private void GainOneClient_Click(object sender, EventArgs e)
        {
            InputIdClient form = new InputIdClient();
            form.ShowDialog();
            string sqlExpression = "SELECT dbo.QuantitySumSoldClient(@idClient)";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlParameter idClientParam = new SqlParameter("@idClient", form.idClient);
            command.Parameters.Add(idClientParam);
            var count = command.ExecuteScalar();

            label.Text = "Прибыль клиента под номером "+ form.idClient;
            ResultTextBox.Text = count.ToString();
        }

        private void QuantityAllProd_Click(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT * FROM dbo.QuantitySoldClients()";
            // Создание подключения
            sqlDataAdapter = new SqlDataAdapter(sqlExpression, connection);
            dataset = new DataSet();
            // Заполняем Dataset
            sqlDataAdapter.Fill(dataset, "QuantitySoldClients");
            // Отображаем данные
            dataGridView1.DataSource = dataset.Tables["QuantitySoldClients"];
        }

        private void AddShelf_Click(object sender, EventArgs e)
        {
            AddShelf form = new AddShelf();
            form.ShowDialog();
            string sqlExpression = "AddShelf";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            // указываем, что команда представляет хранимую процедуру
            command.CommandType = CommandType.StoredProcedure;
            // параметр для имени
            SqlParameter idClientParam = new SqlParameter("@idClient", form.idClient);
            command.Parameters.Add(idClientParam);
            SqlParameter idRateParam = new SqlParameter("@idRate", form.idRate);
            command.Parameters.Add(idRateParam);
            SqlParameter RentalPeriodParam = new SqlParameter("@RentalPeriod", form.RentalPeriod);
            command.Parameters.Add(RentalPeriodParam);
            command.ExecuteNonQuery();
            MessageBox.Show("Полка успешно создана");

        }

        private void ViewRate_Click(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT * FROM ListRate";
            // Создание подключения
            sqlDataAdapter = new SqlDataAdapter(sqlExpression, connection);
            dataset = new DataSet();
            // Заполняем Dataset
            sqlDataAdapter.Fill(dataset, "ListRate");
            // Отображаем данные
            dataGridView1.DataSource = dataset.Tables["ListRate"];
        }

        private void UpdateDate_Click(object sender, EventArgs e)
        {
            UpdateDateContract form = new UpdateDateContract();
            form.ShowDialog();
            string sqlExpression = "UpdateDateContract";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            // указываем, что команда представляет хранимую процедуру
            command.CommandType = CommandType.StoredProcedure;
            // параметр для имени
            SqlParameter idClientParam = new SqlParameter
            {
                ParameterName = "@idClient",
                Value = form.idClient
            };
            // добавляем параметр
            command.Parameters.Add(idClientParam);
            SqlParameter DateContractParam = new SqlParameter
            {
                ParameterName = "@DateContract",
                Value = form.DateContract
            };
            // добавляем параметр
            command.Parameters.Add(DateContractParam);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные успешно обновлены");

        }

        private void GainShowRoom_Click(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT * FROM dbo.GainShowRoom()";
            // Создание подключения
            sqlDataAdapter = new SqlDataAdapter(sqlExpression, connection);
            dataset = new DataSet();
            // Заполняем Dataset
            sqlDataAdapter.Fill(dataset, "GainShowRoom");
            // Отображаем данные
            dataGridView1.DataSource = dataset.Tables["GainShowRoom"];

            sqlExpression = "SELECT dbo.GainShowRoomTotal()";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            var count = command.ExecuteScalar();

            label.Text = "Общая прибыль на текущую дату";
            ResultTextBox.Text = count.ToString();
        }
    }
}
