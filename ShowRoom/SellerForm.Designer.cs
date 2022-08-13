namespace ShowRoom
{
    partial class SellerForm
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
            this.AddSale = new System.Windows.Forms.Button();
            this.ListSale = new System.Windows.Forms.Button();
            this.showRoomDataSet1 = new ShowRoom.ShowRoomDataSet();
            this.listProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showRoomDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listProductsTableAdapter = new ShowRoom.ShowRoomDataSetTableAdapters.ListProductsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSale
            // 
            this.AddSale.Location = new System.Drawing.Point(41, 205);
            this.AddSale.Name = "AddSale";
            this.AddSale.Size = new System.Drawing.Size(167, 23);
            this.AddSale.TabIndex = 1;
            this.AddSale.Text = "Добавить данные о покупке";
            this.AddSale.UseVisualStyleBackColor = true;
            this.AddSale.Click += new System.EventHandler(this.AddSale_Click);
            // 
            // ListSale
            // 
            this.ListSale.Location = new System.Drawing.Point(413, 205);
            this.ListSale.Name = "ListSale";
            this.ListSale.Size = new System.Drawing.Size(167, 23);
            this.ListSale.TabIndex = 2;
            this.ListSale.Text = "Просмотр всех покупок";
            this.ListSale.UseVisualStyleBackColor = true;
            this.ListSale.Click += new System.EventHandler(this.ListSale_Click);
            // 
            // showRoomDataSet1
            // 
            this.showRoomDataSet1.DataSetName = "ShowRoomDataSet";
            this.showRoomDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listProductsBindingSource
            // 
            this.listProductsBindingSource.DataMember = "ListProducts";
            this.listProductsBindingSource.DataSource = this.showRoomDataSet1BindingSource;
            // 
            // showRoomDataSet1BindingSource
            // 
            this.showRoomDataSet1BindingSource.DataSource = this.showRoomDataSet1;
            this.showRoomDataSet1BindingSource.Position = 0;
            // 
            // listProductsTableAdapter
            // 
            this.listProductsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 172);
            this.dataGridView1.TabIndex = 3;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 276);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ListSale);
            this.Controls.Add(this.AddSale);
            this.Name = "SellerForm";
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showRoomDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddSale;
        private System.Windows.Forms.Button ListSale;
        private ShowRoomDataSet showRoomDataSet1;
        private System.Windows.Forms.BindingSource showRoomDataSet1BindingSource;
        private System.Windows.Forms.BindingSource listProductsBindingSource;
        private ShowRoomDataSetTableAdapters.ListProductsTableAdapter listProductsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}