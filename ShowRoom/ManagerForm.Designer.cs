namespace ShowRoom
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showRoomDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showRoomDataSet = new ShowRoom.ShowRoomDataSet();
            this.AddClient = new System.Windows.Forms.Button();
            this.AddProducts = new System.Windows.Forms.Button();
            this.UpdateClient = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.ListProducts = new System.Windows.Forms.Button();
            this.ViewSales = new System.Windows.Forms.Button();
            this.ViewClients = new System.Windows.Forms.Button();
            this.UpdateQuantityProd = new System.Windows.Forms.Button();
            this.UpdateProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // showRoomDataSetBindingSource
            // 
            this.showRoomDataSetBindingSource.DataSource = this.showRoomDataSet;
            this.showRoomDataSetBindingSource.Position = 0;
            // 
            // showRoomDataSet
            // 
            this.showRoomDataSet.DataSetName = "ShowRoomDataSet";
            this.showRoomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(80, 200);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(167, 23);
            this.AddClient.TabIndex = 1;
            this.AddClient.Text = "Добавить арендатора";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // AddProducts
            // 
            this.AddProducts.Location = new System.Drawing.Point(266, 200);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Size = new System.Drawing.Size(167, 23);
            this.AddProducts.TabIndex = 2;
            this.AddProducts.Text = "Добавить товар";
            this.AddProducts.UseVisualStyleBackColor = true;
            this.AddProducts.Click += new System.EventHandler(this.AddProducts_Click);
            // 
            // UpdateClient
            // 
            this.UpdateClient.Location = new System.Drawing.Point(452, 243);
            this.UpdateClient.Name = "UpdateClient";
            this.UpdateClient.Size = new System.Drawing.Size(167, 37);
            this.UpdateClient.TabIndex = 3;
            this.UpdateClient.Text = "Редактировать данные клиента";
            this.UpdateClient.UseVisualStyleBackColor = true;
            this.UpdateClient.Click += new System.EventHandler(this.UpdateClient_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Location = new System.Drawing.Point(266, 243);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(167, 23);
            this.DeleteProduct.TabIndex = 4;
            this.DeleteProduct.Text = "Удалить товар";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // ListProducts
            // 
            this.ListProducts.Location = new System.Drawing.Point(266, 284);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(167, 23);
            this.ListProducts.TabIndex = 7;
            this.ListProducts.Text = "Просмотр всех товаров";
            this.ListProducts.UseVisualStyleBackColor = true;
            this.ListProducts.Click += new System.EventHandler(this.ListProducts_Click);
            // 
            // ViewSales
            // 
            this.ViewSales.Location = new System.Drawing.Point(80, 243);
            this.ViewSales.Name = "ViewSales";
            this.ViewSales.Size = new System.Drawing.Size(167, 23);
            this.ViewSales.TabIndex = 8;
            this.ViewSales.Text = "Просмотр всех покупок";
            this.ViewSales.UseVisualStyleBackColor = true;
            this.ViewSales.Click += new System.EventHandler(this.ViewSales_Click);
            // 
            // ViewClients
            // 
            this.ViewClients.Location = new System.Drawing.Point(80, 284);
            this.ViewClients.Name = "ViewClients";
            this.ViewClients.Size = new System.Drawing.Size(167, 23);
            this.ViewClients.TabIndex = 9;
            this.ViewClients.Text = "Просмотр всех клиентов";
            this.ViewClients.UseVisualStyleBackColor = true;
            this.ViewClients.Click += new System.EventHandler(this.ViewClients_Click);
            // 
            // UpdateQuantityProd
            // 
            this.UpdateQuantityProd.Location = new System.Drawing.Point(452, 286);
            this.UpdateQuantityProd.Name = "UpdateQuantityProd";
            this.UpdateQuantityProd.Size = new System.Drawing.Size(167, 23);
            this.UpdateQuantityProd.TabIndex = 10;
            this.UpdateQuantityProd.Text = "Завоз товара арендодателем";
            this.UpdateQuantityProd.UseVisualStyleBackColor = true;
            this.UpdateQuantityProd.Click += new System.EventHandler(this.UpdateQuantityProd_Click);
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.Location = new System.Drawing.Point(452, 200);
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(167, 37);
            this.UpdateProduct.TabIndex = 5;
            this.UpdateProduct.Text = "Редактировать данные товара";
            this.UpdateProduct.UseVisualStyleBackColor = true;
            this.UpdateProduct.Click += new System.EventHandler(this.UpdateProduct_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 322);
            this.Controls.Add(this.UpdateQuantityProd);
            this.Controls.Add(this.ViewClients);
            this.Controls.Add(this.ViewSales);
            this.Controls.Add(this.ListProducts);
            this.Controls.Add(this.UpdateProduct);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.UpdateClient);
            this.Controls.Add(this.AddProducts);
            this.Controls.Add(this.AddClient);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForms";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button AddProducts;
        private System.Windows.Forms.Button UpdateClient;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button ListProducts;
        private System.Windows.Forms.Button ViewSales;
        private System.Windows.Forms.BindingSource showRoomDataSetBindingSource;
        private ShowRoomDataSet showRoomDataSet;
        private System.Windows.Forms.Button ViewClients;
        private System.Windows.Forms.Button UpdateQuantityProd;
        private System.Windows.Forms.Button UpdateProduct;
    }
}