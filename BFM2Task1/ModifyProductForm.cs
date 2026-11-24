using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BFM2Task1
{
    public partial class ModifyProductForm : Form
    {
        private int _productId;
        private BindingList<Part> _associatedParts = new BindingList<Part>();

        public ModifyProductForm(Product productToModify)
        {
            InitializeComponent();

            _productId = productToModify.ProductID;
            IdTextBox.Text = productToModify.ProductID.ToString();
            NameTextBox.Text = productToModify.Name;
            InventoryTextBox.Text = productToModify.InStock.ToString();
            PriceTextBox.Text = productToModify.Price.ToString();
            MaxTextBox.Text = productToModify.Max.ToString();
            MinTextBox.Text = productToModify.Min.ToString();

            // Copy existing associated parts so Cancel discards edits
            foreach (Part part in productToModify.AssociatedParts)
            {
                _associatedParts.Add(part);
            }

            CandidatePartsGridView.DataSource = Inventory.AllParts;
            AssociatedPartsGridView.DataSource = _associatedParts;

            FormatGrid(CandidatePartsGridView);
            FormatGrid(AssociatedPartsGridView);
        }

        private void FormatGrid(DataGridView grid)
        {
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.RowHeadersVisible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchValue = SearchTextBox.Text.Trim().ToLower();
            CandidatePartsGridView.ClearSelection();
            bool matchFound = false;

            if (!string.IsNullOrEmpty(searchValue))
            {
                foreach (DataGridViewRow row in CandidatePartsGridView.Rows)
                {
                    string idText = row.Cells["PartID"].Value?.ToString() ?? "";
                    string nameText = row.Cells["Name"].Value?.ToString()?.ToLower() ?? "";

                    if (idText.Contains(searchValue) || nameText.Contains(searchValue))
                    {
                        row.Selected = true;
                        matchFound = true;
                    }
                }

                if (!matchFound)
                {
                    MessageBox.Show("No matching part found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            if (CandidatePartsGridView.CurrentRow == null || !CandidatePartsGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a candidate part to add.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Part selectedPart = (Part)CandidatePartsGridView.CurrentRow.DataBoundItem;
            _associatedParts.Add(selectedPart);
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (AssociatedPartsGridView.CurrentRow == null || !AssociatedPartsGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Please select an associated part to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Part selectedPart = (Part)AssociatedPartsGridView.CurrentRow.DataBoundItem;

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to remove {selectedPart.Name} from this product?",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _associatedParts.Remove(selectedPart);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = NameTextBox.Text.Trim();
                int inStock = int.Parse(InventoryTextBox.Text);
                decimal price = decimal.Parse(PriceTextBox.Text);
                int max = int.Parse(MaxTextBox.Text);
                int min = int.Parse(MinTextBox.Text);

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Product name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (min > max)
                {
                    MessageBox.Show("Min cannot be greater than Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (inStock < min || inStock > max)
                {
                    MessageBox.Show("Inventory must be between Min and Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Product updatedProduct = new Product
                {
                    ProductID = _productId,
                    Name = name,
                    InStock = inStock,
                    Price = price,
                    Min = min,
                    Max = max
                };

                foreach (Part part in _associatedParts)
                {
                    updatedProduct.addAssociatedPart(part);
                }

                Inventory.updateProduct(_productId, updatedProduct);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Inventory, Price, Min, and Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}