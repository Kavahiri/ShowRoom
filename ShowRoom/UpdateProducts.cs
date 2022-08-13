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
    public partial class UpdateProducts : Form
    {
        public string idProduct;
        public string NameProduct;
        public string UnitPrice;
        public string QuantityProd;
        public UpdateProducts()
        {
            InitializeComponent();
        }

        private void UpdateProd_Click(object sender, EventArgs e)
        {
            idProduct = idProductTextBox.Text;
            NameProduct = ProductNameTextBox.Text;
            UnitPrice = UnitPriceTextBox.Text;
            QuantityProd = QuantityProdTextBox.Text;
            this.Close();
        }
    }
}
