namespace BFM2Task1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.TextBox SearchPartsTextBox;
        private System.Windows.Forms.TextBox SearchProductsTextBox;
        private System.Windows.Forms.Button SearchPartsButton;
        private System.Windows.Forms.Button SearchProductsButton;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button ModifyPartButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ModifyProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button ExitButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            titleLabel = new Label();
            partsLabel = new Label();
            productsLabel = new Label();
            partsDataGridView = new DataGridView();
            productsDataGridView = new DataGridView();
            SearchPartsTextBox = new TextBox();
            SearchProductsTextBox = new TextBox();
            SearchPartsButton = new Button();
            SearchProductsButton = new Button();
            AddPartButton = new Button();
            ModifyPartButton = new Button();
            DeletePartButton = new Button();
            AddProductButton = new Button();
            ModifyProductButton = new Button();
            DeleteProductButton = new Button();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)partsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F);
            titleLabel.Location = new Point(16, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(227, 21);
            titleLabel.TabIndex = 15;
            titleLabel.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Font = new Font("Segoe UI", 12F);
            partsLabel.Location = new Point(30, 70);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(44, 21);
            partsLabel.TabIndex = 14;
            partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Font = new Font("Segoe UI", 12F);
            productsLabel.Location = new Point(700, 70);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(71, 21);
            productsLabel.TabIndex = 7;
            productsLabel.Text = "Products";
            // 
            // partsDataGridView
            // 
            partsDataGridView.AllowUserToResizeRows = false;
            partsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            partsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsDataGridView.Location = new Point(30, 100);
            partsDataGridView.Name = "partsDataGridView";
            partsDataGridView.Size = new Size(630, 240);
            partsDataGridView.TabIndex = 11;
            // 
            // productsDataGridView
            // 
            productsDataGridView.AllowUserToResizeRows = false;
            productsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Location = new Point(700, 100);
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.Size = new Size(630, 240);
            productsDataGridView.TabIndex = 4;
            // 
            // SearchPartsTextBox
            // 
            SearchPartsTextBox.Location = new Point(430, 67);
            SearchPartsTextBox.Name = "SearchPartsTextBox";
            SearchPartsTextBox.Size = new Size(230, 23);
            SearchPartsTextBox.TabIndex = 12;
            // 
            // SearchProductsTextBox
            // 
            SearchProductsTextBox.Location = new Point(1102, 67);
            SearchProductsTextBox.Name = "SearchProductsTextBox";
            SearchProductsTextBox.Size = new Size(228, 23);
            SearchProductsTextBox.TabIndex = 5;
            // 
            // SearchPartsButton
            // 
            SearchPartsButton.Location = new Point(343, 66);
            SearchPartsButton.Name = "SearchPartsButton";
            SearchPartsButton.Size = new Size(75, 27);
            SearchPartsButton.TabIndex = 13;
            SearchPartsButton.Text = "Search";
            SearchPartsButton.UseVisualStyleBackColor = true;
            SearchPartsButton.Click += SearchPartsButton_Click;
            // 
            // SearchProductsButton
            // 
            SearchProductsButton.Location = new Point(1025, 66);
            SearchProductsButton.Name = "SearchProductsButton";
            SearchProductsButton.Size = new Size(75, 27);
            SearchProductsButton.TabIndex = 6;
            SearchProductsButton.Text = "Search";
            SearchProductsButton.UseVisualStyleBackColor = true;
            SearchProductsButton.Click += SearchProductsButton_Click;
            // 
            // AddPartButton
            // 
            AddPartButton.Location = new Point(460, 352);
            AddPartButton.Name = "AddPartButton";
            AddPartButton.Size = new Size(60, 30);
            AddPartButton.TabIndex = 10;
            AddPartButton.Text = "Add";
            AddPartButton.UseVisualStyleBackColor = true;
            // 
            // ModifyPartButton
            // 
            ModifyPartButton.Location = new Point(530, 352);
            ModifyPartButton.Name = "ModifyPartButton";
            ModifyPartButton.Size = new Size(60, 30);
            ModifyPartButton.TabIndex = 9;
            ModifyPartButton.Text = "Modify";
            ModifyPartButton.UseVisualStyleBackColor = true;
            // 
            // DeletePartButton
            // 
            DeletePartButton.Location = new Point(600, 352);
            DeletePartButton.Name = "DeletePartButton";
            DeletePartButton.Size = new Size(60, 30);
            DeletePartButton.TabIndex = 8;
            DeletePartButton.Text = "Delete";
            DeletePartButton.UseVisualStyleBackColor = true;
            DeletePartButton.Click += this.DeletePartButton_Click;
            // 
            // AddProductButton
            // 
            AddProductButton.Location = new Point(1130, 352);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(60, 30);
            AddProductButton.TabIndex = 3;
            AddProductButton.Text = "Add";
            AddProductButton.UseVisualStyleBackColor = true;
            // 
            // ModifyProductButton
            // 
            ModifyProductButton.Location = new Point(1200, 352);
            ModifyProductButton.Name = "ModifyProductButton";
            ModifyProductButton.Size = new Size(60, 30);
            ModifyProductButton.TabIndex = 2;
            ModifyProductButton.Text = "Modify";
            ModifyProductButton.UseVisualStyleBackColor = true;
            // 
            // DeleteProductButton
            // 
            DeleteProductButton.Location = new Point(1270, 352);
            DeleteProductButton.Name = "DeleteProductButton";
            DeleteProductButton.Size = new Size(60, 30);
            DeleteProductButton.TabIndex = 1;
            DeleteProductButton.Text = "Delete";
            DeleteProductButton.UseVisualStyleBackColor = true;
            DeleteProductButton.Click += DeleteProductButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(1250, 470);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(80, 30);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 540);
            Controls.Add(ExitButton);
            Controls.Add(DeleteProductButton);
            Controls.Add(ModifyProductButton);
            Controls.Add(AddProductButton);
            Controls.Add(productsDataGridView);
            Controls.Add(SearchProductsTextBox);
            Controls.Add(SearchProductsButton);
            Controls.Add(productsLabel);
            Controls.Add(DeletePartButton);
            Controls.Add(ModifyPartButton);
            Controls.Add(AddPartButton);
            Controls.Add(partsDataGridView);
            Controls.Add(SearchPartsTextBox);
            Controls.Add(SearchPartsButton);
            Controls.Add(partsLabel);
            Controls.Add(titleLabel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)partsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
