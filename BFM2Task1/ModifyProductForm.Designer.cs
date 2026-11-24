namespace BFM2Task1
{
    partial class ModifyProductForm
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
            IdLabel = new Label();
            NameLabel = new Label();
            InventoryLabel = new Label();
            PriceLabel = new Label();
            MaxLabel = new Label();
            MinLabel = new Label();
            IdTextBox = new TextBox();
            NameTextBox = new TextBox();
            InventoryTextBox = new TextBox();
            PriceTextBox = new TextBox();
            MaxTextBox = new TextBox();
            MinTextBox = new TextBox();
            SearchButton = new Button();
            SearchTextBox = new TextBox();
            CandidatePartsLabel = new Label();
            CandidatePartsGridView = new DataGridView();
            AddPartButton = new Button();
            AssociatedPartsLabel = new Label();
            AssociatedPartsGridView = new DataGridView();
            DeletePartButton = new Button();
            SaveButton = new Button();
            CancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CandidatePartsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssociatedPartsGridView).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TitleLabel.Location = new Point(25, 22);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(131, 21);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Modify Product";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(35, 110);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(18, 15);
            IdLabel.TabIndex = 1;
            IdLabel.Text = "ID";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(35, 150);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            // 
            // InventoryLabel
            // 
            InventoryLabel.AutoSize = true;
            InventoryLabel.Location = new Point(35, 190);
            InventoryLabel.Name = "InventoryLabel";
            InventoryLabel.Size = new Size(56, 15);
            InventoryLabel.TabIndex = 3;
            InventoryLabel.Text = "Inventory";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(35, 230);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(33, 15);
            PriceLabel.TabIndex = 4;
            PriceLabel.Text = "Price";
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(35, 270);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(30, 15);
            MaxLabel.TabIndex = 5;
            MaxLabel.Text = "Max";
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(195, 270);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(28, 15);
            MinLabel.TabIndex = 6;
            MinLabel.Text = "Min";
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(105, 107);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(130, 23);
            IdTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(105, 147);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(130, 23);
            NameTextBox.TabIndex = 8;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.Location = new Point(105, 187);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(130, 23);
            InventoryTextBox.TabIndex = 9;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(105, 227);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(130, 23);
            PriceTextBox.TabIndex = 10;
            // 
            // MaxTextBox
            // 
            MaxTextBox.Location = new Point(105, 267);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.Size = new Size(75, 23);
            MaxTextBox.TabIndex = 11;
            // 
            // MinTextBox
            // 
            MinTextBox.Location = new Point(230, 267);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(75, 23);
            MinTextBox.TabIndex = 12;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(540, 35);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 25);
            SearchButton.TabIndex = 13;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(625, 36);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(195, 23);
            SearchTextBox.TabIndex = 14;
            // 
            // CandidatePartsLabel
            // 
            CandidatePartsLabel.AutoSize = true;
            CandidatePartsLabel.Location = new Point(350, 62);
            CandidatePartsLabel.Name = "CandidatePartsLabel";
            CandidatePartsLabel.Size = new Size(110, 15);
            CandidatePartsLabel.TabIndex = 15;
            CandidatePartsLabel.Text = "All candidate Parts";
            // 
            // CandidatePartsGridView
            // 
            CandidatePartsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CandidatePartsGridView.Location = new Point(350, 82);
            CandidatePartsGridView.Name = "CandidatePartsGridView";
            CandidatePartsGridView.Size = new Size(470, 145);
            CandidatePartsGridView.TabIndex = 16;
            // 
            // AddPartButton
            // 
            AddPartButton.Location = new Point(745, 235);
            AddPartButton.Name = "AddPartButton";
            AddPartButton.Size = new Size(75, 28);
            AddPartButton.TabIndex = 17;
            AddPartButton.Text = "Add";
            AddPartButton.UseVisualStyleBackColor = true;
            AddPartButton.Click += AddPartButton_Click;
            // 
            // AssociatedPartsLabel
            // 
            AssociatedPartsLabel.AutoSize = true;
            AssociatedPartsLabel.Location = new Point(350, 272);
            AssociatedPartsLabel.Name = "AssociatedPartsLabel";
            AssociatedPartsLabel.Size = new Size(176, 15);
            AssociatedPartsLabel.TabIndex = 18;
            AssociatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // AssociatedPartsGridView
            // 
            AssociatedPartsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssociatedPartsGridView.Location = new Point(350, 292);
            AssociatedPartsGridView.Name = "AssociatedPartsGridView";
            AssociatedPartsGridView.Size = new Size(470, 145);
            AssociatedPartsGridView.TabIndex = 19;
            // 
            // DeletePartButton
            // 
            DeletePartButton.Location = new Point(745, 445);
            DeletePartButton.Name = "DeletePartButton";
            DeletePartButton.Size = new Size(75, 28);
            DeletePartButton.TabIndex = 20;
            DeletePartButton.Text = "Delete";
            DeletePartButton.UseVisualStyleBackColor = true;
            DeletePartButton.Click += DeletePartButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(660, 490);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 28);
            SaveButton.TabIndex = 21;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(745, 490);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 28);
            CancelButton.TabIndex = 22;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 540);
            Controls.Add(TitleLabel);
            Controls.Add(IdLabel);
            Controls.Add(NameLabel);
            Controls.Add(InventoryLabel);
            Controls.Add(PriceLabel);
            Controls.Add(MaxLabel);
            Controls.Add(MinLabel);
            Controls.Add(IdTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(InventoryTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(MaxTextBox);
            Controls.Add(MinTextBox);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(CandidatePartsLabel);
            Controls.Add(CandidatePartsGridView);
            Controls.Add(AddPartButton);
            Controls.Add(AssociatedPartsLabel);
            Controls.Add(AssociatedPartsGridView);
            Controls.Add(DeletePartButton);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Name = "ModifyProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)CandidatePartsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssociatedPartsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label IdLabel;
        private Label NameLabel;
        private Label InventoryLabel;
        private Label PriceLabel;
        private Label MaxLabel;
        private Label MinLabel;
        private TextBox IdTextBox;
        private TextBox NameTextBox;
        private TextBox InventoryTextBox;
        private TextBox PriceTextBox;
        private TextBox MaxTextBox;
        private TextBox MinTextBox;
        private Button SearchButton;
        private TextBox SearchTextBox;
        private Label CandidatePartsLabel;
        private DataGridView CandidatePartsGridView;
        private Button AddPartButton;
        private Label AssociatedPartsLabel;
        private DataGridView AssociatedPartsGridView;
        private Button DeletePartButton;
        private Button SaveButton;
        private new Button CancelButton;
    }
}