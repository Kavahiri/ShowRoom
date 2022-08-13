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
    public partial class AddProducts : Form
    {
        public string idClient;
        public string idShelf;
        public string NameProduct;
        public string UnitPrice;
        public string QuantityProd;
        public AddProducts()
        {
            InitializeComponent();
        }

        private void AddP_Click(object sender, EventArgs e)
        {
            idClient = idClientTextBox.Text;
            idShelf = idShelfsTextBox.Text;
            NameProduct = ProductNameTextBox.Text;
            UnitPrice = UnitPriceTextBox.Text;
            QuantityProd = QuantityProdTextBox.Text;
            this.Close();
        }
    }
}
