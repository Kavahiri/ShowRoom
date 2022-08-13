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
    public partial class AddSale : Form
    {
        public AddSale()
        {
            InitializeComponent();
        }
        public string idProduct;
        public string DateSale;
        public string QuantityProd;
        private void AddS_Click(object sender, EventArgs e)
        {
            idProduct = idProdTextBox.Text;
            DateSale = DateSaleTextBox.Text;
            QuantityProd = QuantityTextBox.Text;
            this.Close();
        }
    }
}
