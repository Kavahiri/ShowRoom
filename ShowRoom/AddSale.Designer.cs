namespace ShowRoom
{
    partial class AddSale
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
            this.idProdTextBox = new System.Windows.Forms.TextBox();
            this.DateSaleTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.AddS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idProdTextBox
            // 
            this.idProdTextBox.Location = new System.Drawing.Point(115, 44);
            this.idProdTextBox.Name = "idProdTextBox";
            this.idProdTextBox.Size = new System.Drawing.Size(179, 20);
            this.idProdTextBox.TabIndex = 0;
            // 
            // DateSaleTextBox
            // 
            this.DateSaleTextBox.Location = new System.Drawing.Point(115, 80);
            this.DateSaleTextBox.Name = "DateSaleTextBox";
            this.DateSaleTextBox.Size = new System.Drawing.Size(179, 20);
            this.DateSaleTextBox.TabIndex = 1;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(115, 116);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(179, 20);
            this.QuantityTextBox.TabIndex = 2;
            // 
            // AddS
            // 
            this.AddS.Location = new System.Drawing.Point(115, 153);
            this.AddS.Name = "AddS";
            this.AddS.Size = new System.Drawing.Size(99, 23);
            this.AddS.TabIndex = 3;
            this.AddS.Text = "Ввод данных";
            this.AddS.UseVisualStyleBackColor = true;
            this.AddS.Click += new System.EventHandler(this.AddS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Код товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата продажи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество";
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 198);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddS);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.DateSaleTextBox);
            this.Controls.Add(this.idProdTextBox);
            this.Name = "AddSale";
            this.Text = "AddSale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idProdTextBox;
        private System.Windows.Forms.TextBox DateSaleTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Button AddS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}