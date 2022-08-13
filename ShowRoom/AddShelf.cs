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
    public partial class AddShelf : Form
    {
        public string idClient;
        public string idRate;
        public string RentalPeriod;
        public AddShelf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idClient = textBox1.Text;
            idRate = textBox2.Text;
            RentalPeriod = textBox3.Text;
            this.Close();
        }
    }
}
