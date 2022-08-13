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
    public partial class ManagerForm : Form
    {
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataset = null;
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ShowRoom;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(connectionString);
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        { 
            // Создание подключения
            try
            {
                // Открываем подключение
                connection.Open();
                MessageBox.Show("Вы зашли под учетной записью менеджера");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
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

        private void AddClient_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.ShowDialog();
            // название процедуры
            string sqlExpression = "AddClient";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            // указываем, что команда представляет хранимую процедуру
            command.CommandType = CommandType.StoredProcedure;
            // параметр для имени
            SqlParameter FirstNameParam = new SqlParameter
            {
                ParameterName = "@FirstName",
                Value = form.FirstName
            };
            // добавляем параметр
            command.Parameters.Add(FirstNameParam);
            // параметр для отчества
            SqlParameter MiddleNameParam = new SqlParameter
            {
                ParameterName = "@MiddleName",
                Value = form.MiddleName
            };
            command.Parameters.Add(MiddleNameParam);
            // параметр для фамилии
            SqlParameter LastNameParam = new SqlParameter
            {
                ParameterName = "@LastName",
                Value = form.LastName
            };
            command.Parameters.Add(LastNameParam);
            SqlParameter PhoneParam = new SqlParameter
            {
                ParameterName = "@Phone",
                Value = form.Phone
            };
            command.Parameters.Add(PhoneParam);
            SqlParameter EmailParam = new SqlParameter
            {
                ParameterName = "@Email",
                Value = form.Email
            };
            command.Parameters.Add(EmailParam);
            SqlParameter DateContractParam = new SqlParameter
            {
                ParameterName = "@DateContract",
                Value = form.DateContract
            };
            command.Parameters.Add(DateContractParam);
            var result = command.ExecuteNonQuery();
            if (result == 1)
                MessageBox.Show("Клиент успешно добавлен");
            else
                MessageBox.Show("Произошла ошибка попробуйте снова");
        }

        private void ViewClients_Click(object sender, EventArgs e)
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

        private void AddProducts_Click(object sender, EventArgs e)
        {
            AddProducts form = new AddProducts();
            form.ShowDialog();
            // название процедуры
            string sqlExpression = "AddProduct";
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
            // параметр для отчества
            SqlParameter idShelfParam = new SqlParameter
            {
                ParameterName = "@idShelf",
                Value = form.idShelf
            };
            command.Parameters.Add(idShelfParam);
            // параметр для фамилии
            SqlParameter NameProductParam = new SqlParameter
            {
                ParameterName = "@NameProduct",
                Value = form.NameProduct
            };
            command.Parameters.Add(NameProductParam);
            SqlParameter UnitPriceParam = new SqlParameter
            {
                ParameterName = "@UnitPrice",
                Value = form.UnitPrice
            };
            command.Parameters.Add(UnitPriceParam);
            SqlParameter QuantityProdParam = new SqlParameter
            {
                ParameterName = "@QuantityProd",
                Value = form.QuantityProd
            };
            command.Parameters.Add(QuantityProdParam);
            command.ExecuteNonQuery();
            MessageBox.Show("Товар успешно добавлен");
        }

        private void UpdateQuantityProd_Click(object sender, EventArgs e)
        {
            UpdateProduct form = new UpdateProduct();
            form.ShowDialog();
            // название процедуры
            string sqlExpression = "UpdateQuantityImp";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            // указываем, что команда представляет хранимую процедуру
            command.CommandType = CommandType.StoredProcedure;
            // параметр для имени
            SqlParameter idProductParam = new SqlParameter
            {
                ParameterName = "@idProduct",
                Value = form.idProduct
            };
            command.Parameters.Add(idProductParam);
            SqlParameter QuantityProdParam = new SqlParameter
            {
                ParameterName = "@QuantityProd",
                Value = form.QuantityProd
            };
            command.Parameters.Add(QuantityProdParam);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены");
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct form = new DeleteProduct();
            form.ShowDialog();
            // название процедуры
            string sqlExpression = "DeleteProduct";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            // указываем, что команда представляет хранимую процедуру
            command.CommandType = CommandType.StoredProcedure;
            // параметр для имени
            SqlParameter idProductParam = new SqlParameter
            {
                ParameterName = "@idProduct",
                Value = form.idProduct
            };
            command.Parameters.Add(idProductParam);
            command.ExecuteNonQuery();
            MessageBox.Show("Товар успешно удален");
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            UpdateProducts form = new UpdateProducts();
            form.ShowDialog();
            // название процедуры
            string sqlExpression = "UpdateProducts";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            // указываем, что команда представляет хранимую процедуру
            command.CommandType = CommandType.StoredProcedure;
            // параметр для имени
            SqlParameter idProductParam = new SqlParameter
            {
                ParameterName = "@idProduct",
                Value = form.idProduct
            };
            command.Parameters.Add(idProductParam);
            SqlParameter NameProductParam = new SqlParameter
            {
                ParameterName = "@NameProduct",
                Value = form.NameProduct
            };
            command.Parameters.Add(NameProductParam);
            SqlParameter UnitPriceParam = new SqlParameter
            {
                ParameterName = "@UnitPrice",
                Value = form.UnitPrice
            };
            command.Parameters.Add(UnitPriceParam);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены");
        }

        private void UpdateClient_Click(object sender, EventArgs e)
        {
            UpdateClient form = new UpdateClient();
            form.ShowDialog();
            // название процедуры
            string sqlExpression = "UpdateClient";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            // указываем, что команда представляет хранимую процедуру
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter idClientParam = new SqlParameter
            {
                ParameterName = "@idClient",
                Value = form.idClient
            };
            command.Parameters.Add(idClientParam);
            // параметр для имени
            SqlParameter FirstNameParam = new SqlParameter
            {
                ParameterName = "@FirstName",
                Value = form.FirstName
            };
            // добавляем параметр
            command.Parameters.Add(FirstNameParam);
            // параметр для отчества
            SqlParameter MiddleNameParam = new SqlParameter
            {
                ParameterName = "@MiddleName",
                Value = form.MiddleName
            };
            command.Parameters.Add(MiddleNameParam);
            // параметр для фамилии
            SqlParameter LastNameParam = new SqlParameter
            {
                ParameterName = "@LastName",
                Value = form.LastName
            };
            command.Parameters.Add(LastNameParam);
            SqlParameter PhoneParam = new SqlParameter
            {
                ParameterName = "@Phone",
                Value = form.Phone
            };
            command.Parameters.Add(PhoneParam);
            SqlParameter EmailParam = new SqlParameter
            {
                ParameterName = "@Email",
                Value = form.Email
            };
            command.Parameters.Add(EmailParam);
            var result = command.ExecuteNonQuery();
            if (result == 1)
                MessageBox.Show("Данные обновлены");
            else
                MessageBox.Show("Произошла ошибка попробуйте снова");
        }
    }
}
