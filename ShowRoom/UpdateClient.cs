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
    public partial class UpdateClient : Form
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string Email;
        public string Phone;
        public string idClient;
        public UpdateClient()
        {
            InitializeComponent();
        }

        private void UpdateC_Click(object sender, EventArgs e)
        {
            FirstName = FirstNameTextBox.Text;
            MiddleName = MiddleNameBox.Text;
            LastName = LastNameTextBox.Text;
            Email = EmailTextBox.Text;
            Phone = PhoneTextBox.Text;
            idClient = idClientTextBox.Text;
            this.Close();
        }
    }
}
