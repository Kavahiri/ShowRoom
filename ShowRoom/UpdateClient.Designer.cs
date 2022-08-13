namespace ShowRoom
{
    partial class UpdateClient
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateC = new System.Windows.Forms.Button();
            this.MiddleNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Код арендатора ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Почта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Телефон";
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.Location = new System.Drawing.Point(168, 19);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(179, 20);
            this.idClientTextBox.TabIndex = 29;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(168, 189);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(179, 20);
            this.EmailTextBox.TabIndex = 28;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(168, 153);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(179, 20);
            this.PhoneTextBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Фамилия";
            // 
            // UpdateC
            // 
            this.UpdateC.Location = new System.Drawing.Point(118, 229);
            this.UpdateC.Name = "UpdateC";
            this.UpdateC.Size = new System.Drawing.Size(99, 23);
            this.UpdateC.TabIndex = 23;
            this.UpdateC.Text = "Ввод данных";
            this.UpdateC.UseVisualStyleBackColor = true;
            this.UpdateC.Click += new System.EventHandler(this.UpdateC_Click);
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.Location = new System.Drawing.Point(168, 119);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(179, 20);
            this.MiddleNameBox.TabIndex = 22;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(168, 84);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.FirstNameTextBox.TabIndex = 21;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(168, 51);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.LastNameTextBox.TabIndex = 20;
            // 
            // UpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 267);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idClientTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateC);
            this.Controls.Add(this.MiddleNameBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Name = "UpdateClient";
            this.Text = "UpdateClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateC;
        private System.Windows.Forms.TextBox MiddleNameBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
    }
}