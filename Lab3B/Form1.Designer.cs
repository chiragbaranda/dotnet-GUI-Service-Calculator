namespace Lab3B
{
    partial class Lab3B
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
            this.HairDresserGroupBox = new System.Windows.Forms.GroupBox();
            this.HairDresserComboBox = new System.Windows.Forms.ComboBox();
            this.ServiceGroupBox = new System.Windows.Forms.GroupBox();
            this.ServicesListBox = new System.Windows.Forms.ListBox();
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.ChargedItemListBox = new System.Windows.Forms.ListBox();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.PriceListBox = new System.Windows.Forms.ListBox();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.CalculateTotalPriceButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HairDresserGroupBox.SuspendLayout();
            this.ServiceGroupBox.SuspendLayout();
            this.ItemsGroupBox.SuspendLayout();
            this.PriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HairDresserGroupBox
            // 
            this.HairDresserGroupBox.Controls.Add(this.HairDresserComboBox);
            this.HairDresserGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HairDresserGroupBox.Location = new System.Drawing.Point(5, 32);
            this.HairDresserGroupBox.Name = "HairDresserGroupBox";
            this.HairDresserGroupBox.Size = new System.Drawing.Size(163, 209);
            this.HairDresserGroupBox.TabIndex = 0;
            this.HairDresserGroupBox.TabStop = false;
            this.HairDresserGroupBox.Text = "Select a Hair Dresser";
            // 
            // HairDresserComboBox
            // 
            this.HairDresserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HairDresserComboBox.FormattingEnabled = true;
            this.HairDresserComboBox.Items.AddRange(new object[] {
            "Jane",
            "Pat",
            "Ron",
            "Sue",
            "Laurie"});
            this.HairDresserComboBox.Location = new System.Drawing.Point(7, 20);
            this.HairDresserComboBox.Name = "HairDresserComboBox";
            this.HairDresserComboBox.Size = new System.Drawing.Size(143, 21);
            this.HairDresserComboBox.TabIndex = 0;
            // 
            // ServiceGroupBox
            // 
            this.ServiceGroupBox.Controls.Add(this.ServicesListBox);
            this.ServiceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceGroupBox.Location = new System.Drawing.Point(174, 32);
            this.ServiceGroupBox.Name = "ServiceGroupBox";
            this.ServiceGroupBox.Size = new System.Drawing.Size(206, 209);
            this.ServiceGroupBox.TabIndex = 1;
            this.ServiceGroupBox.TabStop = false;
            this.ServiceGroupBox.Text = "Select a Service";
            // 
            // ServicesListBox
            // 
            this.ServicesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesListBox.FormattingEnabled = true;
            this.ServicesListBox.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extension",
            "Up-do"});
            this.ServicesListBox.Location = new System.Drawing.Point(7, 30);
            this.ServicesListBox.Name = "ServicesListBox";
            this.ServicesListBox.Size = new System.Drawing.Size(193, 173);
            this.ServicesListBox.TabIndex = 0;
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.Controls.Add(this.ChargedItemListBox);
            this.ItemsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsGroupBox.Location = new System.Drawing.Point(386, 32);
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.Size = new System.Drawing.Size(194, 209);
            this.ItemsGroupBox.TabIndex = 2;
            this.ItemsGroupBox.TabStop = false;
            this.ItemsGroupBox.Text = "Changed Item :";
            // 
            // ChargedItemListBox
            // 
            this.ChargedItemListBox.Enabled = false;
            this.ChargedItemListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargedItemListBox.FormattingEnabled = true;
            this.ChargedItemListBox.Location = new System.Drawing.Point(7, 30);
            this.ChargedItemListBox.Name = "ChargedItemListBox";
            this.ChargedItemListBox.Size = new System.Drawing.Size(181, 173);
            this.ChargedItemListBox.TabIndex = 0;
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.PriceListBox);
            this.PriceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceGroupBox.Location = new System.Drawing.Point(586, 32);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(190, 209);
            this.PriceGroupBox.TabIndex = 3;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Price: ";
            // 
            // PriceListBox
            // 
            this.PriceListBox.Enabled = false;
            this.PriceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceListBox.FormattingEnabled = true;
            this.PriceListBox.Location = new System.Drawing.Point(7, 30);
            this.PriceListBox.Name = "PriceListBox";
            this.PriceListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PriceListBox.Size = new System.Drawing.Size(177, 173);
            this.PriceListBox.TabIndex = 0;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLabel.Location = new System.Drawing.Point(624, 257);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(77, 13);
            this.TotalPriceLabel.TabIndex = 4;
            this.TotalPriceLabel.Text = "Total Price: ";
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.Enabled = false;
            this.TotalPriceTextBox.Location = new System.Drawing.Point(712, 254);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(58, 20);
            this.TotalPriceTextBox.TabIndex = 5;
            this.TotalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.Location = new System.Drawing.Point(331, 290);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(102, 31);
            this.AddServiceButton.TabIndex = 6;
            this.AddServiceButton.Text = "&Add Service";
            this.AddServiceButton.UseVisualStyleBackColor = true;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // CalculateTotalPriceButton
            // 
            this.CalculateTotalPriceButton.Location = new System.Drawing.Point(439, 290);
            this.CalculateTotalPriceButton.Name = "CalculateTotalPriceButton";
            this.CalculateTotalPriceButton.Size = new System.Drawing.Size(125, 31);
            this.CalculateTotalPriceButton.TabIndex = 7;
            this.CalculateTotalPriceButton.Text = "&Calculate Total Price";
            this.CalculateTotalPriceButton.UseVisualStyleBackColor = true;
            this.CalculateTotalPriceButton.Click += new System.EventHandler(this.CalculateTotalPriceButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(566, 290);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(102, 31);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "&Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(674, 290);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(102, 31);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Lab3B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 343);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateTotalPriceButton);
            this.Controls.Add(this.AddServiceButton);
            this.Controls.Add(this.TotalPriceTextBox);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.ItemsGroupBox);
            this.Controls.Add(this.ServiceGroupBox);
            this.Controls.Add(this.HairDresserGroupBox);
            this.Name = "Lab3B";
            this.Text = "Lab3B";
            this.Load += new System.EventHandler(this.Lab3B_Load);
            this.HairDresserGroupBox.ResumeLayout(false);
            this.ServiceGroupBox.ResumeLayout(false);
            this.ItemsGroupBox.ResumeLayout(false);
            this.PriceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox HairDresserGroupBox;
        private System.Windows.Forms.ComboBox HairDresserComboBox;
        private System.Windows.Forms.GroupBox ServiceGroupBox;
        private System.Windows.Forms.ListBox ServicesListBox;
        private System.Windows.Forms.GroupBox ItemsGroupBox;
        private System.Windows.Forms.ListBox ChargedItemListBox;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.ListBox PriceListBox;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.TextBox TotalPriceTextBox;
        private System.Windows.Forms.Button AddServiceButton;
        private System.Windows.Forms.Button CalculateTotalPriceButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

