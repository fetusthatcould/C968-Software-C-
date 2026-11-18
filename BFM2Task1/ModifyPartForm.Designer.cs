namespace BFM2Task1
{
    partial class ModifyPartForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            TitleLabel = new Label();
            InHouseRadioButton = new RadioButton();
            OutsourcedRadioButton = new RadioButton();
            IdLabel = new Label();
            NameLabel = new Label();
            InventoryLabel = new Label();
            PriceLabel = new Label();
            MaxLabel = new Label();
            MinLabel = new Label();
            SourceLabel = new Label();
            IdTextBox = new TextBox();
            NameTextBox = new TextBox();
            InventoryTextBox = new TextBox();
            PriceTextBox = new TextBox();
            MaxTextBox = new TextBox();
            MinTextBox = new TextBox();
            SourceTextBox = new TextBox();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TitleLabel.Location = new Point(22, 20);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(102, 21);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Modify Part";
            // 
            // InHouseRadioButton
            // 
            InHouseRadioButton.AutoSize = true;
            InHouseRadioButton.Location = new Point(140, 22);
            InHouseRadioButton.Name = "InHouseRadioButton";
            InHouseRadioButton.Size = new Size(73, 19);
            InHouseRadioButton.TabIndex = 1;
            InHouseRadioButton.TabStop = true;
            InHouseRadioButton.Text = "In-House";
            InHouseRadioButton.UseVisualStyleBackColor = true;
            InHouseRadioButton.CheckedChanged += InHouseRadioButton_CheckedChanged;
            // 
            // OutsourcedRadioButton
            // 
            OutsourcedRadioButton.AutoSize = true;
            OutsourcedRadioButton.Location = new Point(240, 22);
            OutsourcedRadioButton.Name = "OutsourcedRadioButton";
            OutsourcedRadioButton.Size = new Size(86, 19);
            OutsourcedRadioButton.TabIndex = 2;
            OutsourcedRadioButton.Text = "Outsourced";
            OutsourcedRadioButton.UseVisualStyleBackColor = true;
            OutsourcedRadioButton.CheckedChanged += OutsourcedRadioButton_CheckedChanged;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(60, 70);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(18, 15);
            IdLabel.TabIndex = 3;
            IdLabel.Text = "ID";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(60, 110);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name";
            // 
            // InventoryLabel
            // 
            InventoryLabel.AutoSize = true;
            InventoryLabel.Location = new Point(60, 150);
            InventoryLabel.Name = "InventoryLabel";
            InventoryLabel.Size = new Size(56, 15);
            InventoryLabel.TabIndex = 5;
            InventoryLabel.Text = "Inventory";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(60, 190);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(66, 15);
            PriceLabel.TabIndex = 6;
            PriceLabel.Text = "Price / Cost";
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(60, 230);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(30, 15);
            MaxLabel.TabIndex = 7;
            MaxLabel.Text = "Max";
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(245, 230);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(28, 15);
            MinLabel.TabIndex = 8;
            MinLabel.Text = "Min";
            // 
            // SourceLabel
            // 
            SourceLabel.AutoSize = true;
            SourceLabel.Location = new Point(60, 270);
            SourceLabel.Name = "SourceLabel";
            SourceLabel.Size = new Size(67, 15);
            SourceLabel.TabIndex = 9;
            SourceLabel.Text = "Machine ID";
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(150, 67);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(130, 23);
            IdTextBox.TabIndex = 10;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(150, 107);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(130, 23);
            NameTextBox.TabIndex = 11;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.Location = new Point(150, 147);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(130, 23);
            InventoryTextBox.TabIndex = 12;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(150, 187);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(130, 23);
            PriceTextBox.TabIndex = 13;
            // 
            // MaxTextBox
            // 
            MaxTextBox.Location = new Point(150, 227);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.Size = new Size(80, 23);
            MaxTextBox.TabIndex = 14;
            // 
            // MinTextBox
            // 
            MinTextBox.Location = new Point(280, 227);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(80, 23);
            MinTextBox.TabIndex = 15;
            // 
            // SourceTextBox
            // 
            SourceTextBox.Location = new Point(150, 267);
            SourceTextBox.Name = "SourceTextBox";
            SourceTextBox.Size = new Size(130, 23);
            SourceTextBox.TabIndex = 16;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(200, 320);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 28);
            SaveButton.TabIndex = 17;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(285, 320);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 28);
            CancelButton.TabIndex = 18;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ModifyPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 375);
            Controls.Add(TitleLabel);
            Controls.Add(InHouseRadioButton);
            Controls.Add(OutsourcedRadioButton);
            Controls.Add(IdLabel);
            Controls.Add(NameLabel);
            Controls.Add(InventoryLabel);
            Controls.Add(PriceLabel);
            Controls.Add(MaxLabel);
            Controls.Add(MinLabel);
            Controls.Add(SourceLabel);
            Controls.Add(IdTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(InventoryTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(MaxTextBox);
            Controls.Add(MinTextBox);
            Controls.Add(SourceTextBox);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Name = "ModifyPartForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private RadioButton InHouseRadioButton;
        private RadioButton OutsourcedRadioButton;
        private Label IdLabel;
        private Label NameLabel;
        private Label InventoryLabel;
        private Label PriceLabel;
        private Label MaxLabel;
        private Label MinLabel;
        private Label SourceLabel;
        private TextBox IdTextBox;
        private TextBox NameTextBox;
        private TextBox InventoryTextBox;
        private TextBox PriceTextBox;
        private TextBox MaxTextBox;
        private TextBox MinTextBox;
        private TextBox SourceTextBox;
        private Button SaveButton;
        private new Button CancelButton;
    }
}