namespace ShowRoom
{
    partial class AddProducts
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
            this.label6 = new System.Windows.Forms.Label();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.QuantityProdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddP = new System.Windows.Forms.Button();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.idShelfsTextBox = new System.Windows.Forms.TextBox();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Цена за единицу товара";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Количество";
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Location = new System.Drawing.Point(189, 174);
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.Size = new System.Drawing.Size(179, 20);
            this.UnitPriceTextBox.TabIndex = 28;
            // 
            // QuantityProdTextBox
            // 
            this.QuantityProdTextBox.Location = new System.Drawing.Point(189, 138);
            this.QuantityProdTextBox.Name = "QuantityProdTextBox";
            this.QuantityProdTextBox.Size = new System.Drawing.Size(179, 20);
            this.QuantityProdTextBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Наименование товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Номер полки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Код клиента";
            // 
            // AddP
            // 
            this.AddP.Location = new System.Drawing.Point(138, 215);
            this.AddP.Name = "AddP";
            this.AddP.Size = new System.Drawing.Size(99, 23);
            this.AddP.TabIndex = 23;
            this.AddP.Text = "Ввод данных";
            this.AddP.UseVisualStyleBackColor = true;
            this.AddP.Click += new System.EventHandler(this.AddP_Click);
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(189, 104);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.ProductNameTextBox.TabIndex = 22;
            // 
            // idShelfsTextBox
            // 
            this.idShelfsTextBox.Location = new System.Drawing.Point(189, 69);
            this.idShelfsTextBox.Name = "idShelfsTextBox";
            this.idShelfsTextBox.Size = new System.Drawing.Size(179, 20);
            this.idShelfsTextBox.TabIndex = 21;
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.Location = new System.Drawing.Point(189, 36);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(179, 20);
            this.idClientTextBox.TabIndex = 20;
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 259);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UnitPriceTextBox);
            this.Controls.Add(this.QuantityProdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddP);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.idShelfsTextBox);
            this.Controls.Add(this.idClientTextBox);
            this.Name = "AddProducts";
            this.Text = "AddProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UnitPriceTextBox;
        private System.Windows.Forms.TextBox QuantityProdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddP;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox idShelfsTextBox;
        private System.Windows.Forms.TextBox idClientTextBox;
    }
}