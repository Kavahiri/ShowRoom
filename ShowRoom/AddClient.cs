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
    public partial class AddClient : Form
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string Email;
        public string Phone;
        public string DateContract;
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddC_Click(object sender, EventArgs e)
        {
            FirstName=FirstNameTextBox.Text;
            MiddleName=MiddleNameBox.Text;
            LastName=LastNameTextBox.Text;
            Email=EmailTextBox.Text;
            Phone=PhoneTextBox.Text;
            DateContract= DateContarctTextBox.Text;
            this.Close();
        }
    }
}
