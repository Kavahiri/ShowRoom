namespace ShowRoom
{
    partial class UpdateProducts
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
            this.label5 = new System.Windows.Forms.Label();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateProd = new System.Windows.Forms.Button();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.idProductTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Цена за единицу товара";
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Location = new System.Drawing.Point(173, 106);
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.Size = new System.Drawing.Size(179, 20);
            this.UnitPriceTextBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Наименование товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Код товара";
            // 
            // UpdateProd
            // 
            this.UpdateProd.Location = new System.Drawing.Point(129, 154);
            this.UpdateProd.Name = "UpdateProd";
            this.UpdateProd.Size = new System.Drawing.Size(99, 23);
            this.UpdateProd.TabIndex = 35;
            this.UpdateProd.Text = "Ввод данных";
            this.UpdateProd.UseVisualStyleBackColor = true;
            this.UpdateProd.Click += new System.EventHandler(this.UpdateProd_Click);
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(173, 65);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.ProductNameTextBox.TabIndex = 34;
            // 
            // idProductTextBox
            // 
            this.idProductTextBox.Location = new System.Drawing.Point(173, 24);
            this.idProductTextBox.Name = "idProductTextBox";
            this.idProductTextBox.Size = new System.Drawing.Size(179, 20);
            this.idProductTextBox.TabIndex = 33;
            // 
            // UpdateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 191);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UnitPriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateProd);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.idProductTextBox);
            this.Name = "UpdateProducts";
            this.Text = "UpdateProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UnitPriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateProd;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox idProductTextBox;
    }
}