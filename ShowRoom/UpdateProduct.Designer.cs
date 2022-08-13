namespace ShowRoom
{
    partial class UpdateProduct
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
            this.QuantityProdTextBox = new System.Windows.Forms.TextBox();
            this.idProductTextBox = new System.Windows.Forms.TextBox();
            this.UpdateP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Код товара";
            // 
            // QuantityProdTextBox
            // 
            this.QuantityProdTextBox.Location = new System.Drawing.Point(176, 90);
            this.QuantityProdTextBox.Name = "QuantityProdTextBox";
            this.QuantityProdTextBox.Size = new System.Drawing.Size(179, 20);
            this.QuantityProdTextBox.TabIndex = 34;
            // 
            // idProductTextBox
            // 
            this.idProductTextBox.Location = new System.Drawing.Point(176, 54);
            this.idProductTextBox.Name = "idProductTextBox";
            this.idProductTextBox.Size = new System.Drawing.Size(179, 20);
            this.idProductTextBox.TabIndex = 33;
            // 
            // UpdateP
            // 
            this.UpdateP.Location = new System.Drawing.Point(125, 131);
            this.UpdateP.Name = "UpdateP";
            this.UpdateP.Size = new System.Drawing.Size(99, 23);
            this.UpdateP.TabIndex = 32;
            this.UpdateP.Text = "Ввод данных";
            this.UpdateP.UseVisualStyleBackColor = true;
            this.UpdateP.Click += new System.EventHandler(this.UpdateP_Click);
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 195);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.QuantityProdTextBox);
            this.Controls.Add(this.idProductTextBox);
            this.Controls.Add(this.UpdateP);
            this.Name = "UpdateProduct";
            this.Text = "UpdateProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox QuantityProdTextBox;
        private System.Windows.Forms.TextBox idProductTextBox;
        private System.Windows.Forms.Button UpdateP;
    }
}