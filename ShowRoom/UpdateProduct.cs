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
    public partial class UpdateProduct : Form
    {
        public string idProduct;
        public string QuantityProd;
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void UpdateP_Click(object sender, EventArgs e)
        {
            idProduct = idProductTextBox.Text;
            QuantityProd = QuantityProdTextBox.Text;
            this.Close();
        }
    }
}
