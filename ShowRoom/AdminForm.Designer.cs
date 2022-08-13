namespace ShowRoom
{
    partial class AdminForm
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
            this.QuantityAllProd = new System.Windows.Forms.Button();
            this.GainShowRoom = new System.Windows.Forms.Button();
            this.GainAllClients = new System.Windows.Forms.Button();
            this.DeleteClient = new System.Windows.Forms.Button();
            this.ListClients = new System.Windows.Forms.Button();
            this.ListProducts = new System.Windows.Forms.Button();
            this.ListShelfs = new System.Windows.Forms.Button();
            this.GainOneClient = new System.Windows.Forms.Button();
            this.ViewSales = new System.Windows.Forms.Button();
            this.AddShelf = new System.Windows.Forms.Button();
            this.UpdateDate = new System.Windows.Forms.Button();
            this.ViewRate = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 167);
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
            // QuantityAllProd
            // 
            this.QuantityAllProd.Location = new System.Drawing.Point(27, 224);
            this.QuantityAllProd.Name = "QuantityAllProd";
            this.QuantityAllProd.Size = new System.Drawing.Size(167, 37);
            this.QuantityAllProd.TabIndex = 2;
            this.QuantityAllProd.Text = "Подсчет количества товара клиентов";
            this.QuantityAllProd.UseVisualStyleBackColor = true;
            this.QuantityAllProd.Click += new System.EventHandler(this.QuantityAllProd_Click);
            // 
            // GainShowRoom
            // 
            this.GainShowRoom.Location = new System.Drawing.Point(27, 195);
            this.GainShowRoom.Name = "GainShowRoom";
            this.GainShowRoom.Size = new System.Drawing.Size(167, 23);
            this.GainShowRoom.TabIndex = 3;
            this.GainShowRoom.Text = "Подсчет выручки шоурума";
            this.GainShowRoom.UseVisualStyleBackColor = true;
            this.GainShowRoom.Click += new System.EventHandler(this.GainShowRoom_Click);
            // 
            // GainAllClients
            // 
            this.GainAllClients.Location = new System.Drawing.Point(226, 224);
            this.GainAllClients.Name = "GainAllClients";
            this.GainAllClients.Size = new System.Drawing.Size(167, 37);
            this.GainAllClients.TabIndex = 4;
            this.GainAllClients.Text = "Подсчет выручки всех клиентов";
            this.GainAllClients.UseVisualStyleBackColor = true;
            this.GainAllClients.Click += new System.EventHandler(this.GainAllClients_Click);
            // 
            // DeleteClient
            // 
            this.DeleteClient.Location = new System.Drawing.Point(226, 195);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(167, 23);
            this.DeleteClient.TabIndex = 5;
            this.DeleteClient.Text = "Удаление клиента";
            this.DeleteClient.UseVisualStyleBackColor = true;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // ListClients
            // 
            this.ListClients.Location = new System.Drawing.Point(226, 267);
            this.ListClients.Name = "ListClients";
            this.ListClients.Size = new System.Drawing.Size(167, 23);
            this.ListClients.TabIndex = 6;
            this.ListClients.Text = "Просмотр всех клиентов";
            this.ListClients.UseVisualStyleBackColor = true;
            this.ListClients.Click += new System.EventHandler(this.ListClients_Click);
            // 
            // ListProducts
            // 
            this.ListProducts.Location = new System.Drawing.Point(412, 267);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(167, 23);
            this.ListProducts.TabIndex = 7;
            this.ListProducts.Text = "Просмотр всех товаров";
            this.ListProducts.UseVisualStyleBackColor = true;
            this.ListProducts.Click += new System.EventHandler(this.ListProducts_Click);
            // 
            // ListShelfs
            // 
            this.ListShelfs.Location = new System.Drawing.Point(27, 267);
            this.ListShelfs.Name = "ListShelfs";
            this.ListShelfs.Size = new System.Drawing.Size(167, 23);
            this.ListShelfs.TabIndex = 8;
            this.ListShelfs.Text = "Просмотр всех полок";
            this.ListShelfs.UseVisualStyleBackColor = true;
            this.ListShelfs.Click += new System.EventHandler(this.ListShelfs_Click);
            // 
            // GainOneClient
            // 
            this.GainOneClient.Location = new System.Drawing.Point(412, 224);
            this.GainOneClient.Name = "GainOneClient";
            this.GainOneClient.Size = new System.Drawing.Size(167, 37);
            this.GainOneClient.TabIndex = 9;
            this.GainOneClient.Text = "Подсчет выручки у одного клиента";
            this.GainOneClient.UseVisualStyleBackColor = true;
            this.GainOneClient.Click += new System.EventHandler(this.GainOneClient_Click);
            // 
            // ViewSales
            // 
            this.ViewSales.Location = new System.Drawing.Point(412, 195);
            this.ViewSales.Name = "ViewSales";
            this.ViewSales.Size = new System.Drawing.Size(167, 23);
            this.ViewSales.TabIndex = 10;
            this.ViewSales.Text = "Просмотр всех покупок";
            this.ViewSales.UseVisualStyleBackColor = true;
            this.ViewSales.Click += new System.EventHandler(this.ViewSales_Click);
            // 
            // AddShelf
            // 
            this.AddShelf.Location = new System.Drawing.Point(27, 296);
            this.AddShelf.Name = "AddShelf";
            this.AddShelf.Size = new System.Drawing.Size(167, 23);
            this.AddShelf.TabIndex = 11;
            this.AddShelf.Text = "Добавить полку ";
            this.AddShelf.UseVisualStyleBackColor = true;
            this.AddShelf.Click += new System.EventHandler(this.AddShelf_Click);
            // 
            // UpdateDate
            // 
            this.UpdateDate.Location = new System.Drawing.Point(412, 296);
            this.UpdateDate.Name = "UpdateDate";
            this.UpdateDate.Size = new System.Drawing.Size(167, 23);
            this.UpdateDate.TabIndex = 12;
            this.UpdateDate.Text = "Обновить дату контракта";
            this.UpdateDate.UseVisualStyleBackColor = true;
            this.UpdateDate.Click += new System.EventHandler(this.UpdateDate_Click);
            // 
            // ViewRate
            // 
            this.ViewRate.Location = new System.Drawing.Point(226, 296);
            this.ViewRate.Name = "ViewRate";
            this.ViewRate.Size = new System.Drawing.Size(167, 23);
            this.ViewRate.TabIndex = 13;
            this.ViewRate.Text = "Просмотр всех тарифов";
            this.ViewRate.UseVisualStyleBackColor = true;
            this.ViewRate.Click += new System.EventHandler(this.ViewRate_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(600, 204);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(10, 13);
            this.label.TabIndex = 14;
            this.label.Text = " ";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(603, 224);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(166, 20);
            this.ResultTextBox.TabIndex = 15;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 345);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ViewRate);
            this.Controls.Add(this.UpdateDate);
            this.Controls.Add(this.AddShelf);
            this.Controls.Add(this.ViewSales);
            this.Controls.Add(this.GainOneClient);
            this.Controls.Add(this.ListShelfs);
            this.Controls.Add(this.ListProducts);
            this.Controls.Add(this.ListClients);
            this.Controls.Add(this.DeleteClient);
            this.Controls.Add(this.GainAllClients);
            this.Controls.Add(this.GainShowRoom);
            this.Controls.Add(this.QuantityAllProd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource showRoomDataSetBindingSource;
        private ShowRoomDataSet showRoomDataSet;
        private System.Windows.Forms.Button QuantityAllProd;
        private System.Windows.Forms.Button GainShowRoom;
        private System.Windows.Forms.Button GainAllClients;
        private System.Windows.Forms.Button DeleteClient;
        private System.Windows.Forms.Button ListClients;
        private System.Windows.Forms.Button ListProducts;
        private System.Windows.Forms.Button ListShelfs;
        private System.Windows.Forms.Button GainOneClient;
        private System.Windows.Forms.Button ViewSales;
        private System.Windows.Forms.Button AddShelf;
        private System.Windows.Forms.Button UpdateDate;
        private System.Windows.Forms.Button ViewRate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}