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
    public partial class UpdateDateContract : Form
    {
        public string DateContract;
        public string idClient;
        public UpdateDateContract()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateContract = textBox1.Text;
            idClient = textBox2.Text;
        }
    }
}
