using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowRoom
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Input_Click(object sender, EventArgs e)
        {
            string Login = LoginTextBox.Text;
            string Pass = PassTextBox.Text;
            switch (Login)
            {
                case "admin":
                    if (String.Equals(Pass, "adminpass"))
                    {
                        this.Hide();
                        AdminForm form = new AdminForm();
                        form.ShowDialog();
                        this.Close();
                        break;
                    }
                    else goto default;
                case "manager":
                    if (String.Equals(Pass, "managerpass"))
                    {
                        this.Hide();
                        ManagerForm form = new ManagerForm();
                        form.ShowDialog();
                        this.Close();
                        break;
                    }
                    else goto default;
                case "seller":
                    if (String.Equals(Pass, "sellerpass"))
                    {
                        this.Hide();
                        SellerForm form = new SellerForm();
                        form.ShowDialog();
                        this.Close();
                        break;
                    }
                    else goto default;
                default:
                    MessageBox.Show("Введены неверные данные логин или пароль.\nПопробуйте еще раз!");
                    break;
            }
            
        }
    }
}
