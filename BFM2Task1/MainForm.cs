using System.Windows.Forms;

namespace BFM2Task1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Inventory.PopulateSampleData();

            // 1. Bind the Inventory lists to your DataGridViews
            partsDataGridView.DataSource = Inventory.AllParts;
            productsDataGridView.DataSource = Inventory.Products;

            // Column headers to match the mock-up
            partsDataGridView.Columns["PartID"].HeaderText = "Part ID";
            partsDataGridView.Columns["InStock"].HeaderText = "Inventory";
            partsDataGridView.Columns["Price"].DefaultCellStyle.Format = "0.00";

            productsDataGridView.Columns["ProductID"].HeaderText = "Product ID";
            productsDataGridView.Columns["InStock"].HeaderText = "Inventory";
            productsDataGridView.Columns["Price"].DefaultCellStyle.Format = "0.00";
            //productsDataGridView.Columns["AssociatedParts"].Visible = false;

            // 2. Format grids to match the mock-up and prevent user edits
            partsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            partsDataGridView.ReadOnly = true;
            productsDataGridView.ReadOnly = true;

            partsDataGridView.AllowUserToAddRows = false;
            productsDataGridView.AllowUserToAddRows = false;

            // Optional: Hide the bottom row header column for a cleaner look
            partsDataGridView.RowHeadersVisible = false;
            productsDataGridView.RowHeadersVisible = false;
        }

        // --- Search Functionality ---

        private void SearchPartsButton_Click(object sender, EventArgs e)
        {
            string searchValue = SearchPartsTextBox.Text.Trim().ToLower();
            partsDataGridView.ClearSelection();
            bool matchFound = false;


            if (!string.IsNullOrEmpty(searchValue))
            {
                foreach (DataGridViewRow row in partsDataGridView.Rows)
                {
                    string idText = row.Cells["PartID"].Value?.ToString() ?? "";
                    string nameText = row.Cells["Name"].Value?.ToString()?.ToLower() ?? "";

                    // Search by either PartID or Name
                    if (row.Cells["PartID"].Value.ToString().Contains(searchValue) ||
                        row.Cells["Name"].Value.ToString().ToLower().Contains(searchValue))
                    {
                        row.Selected = true;
                        matchFound = true;
                        break; // Highlight the first match and stop
                    }
                }

                if (!matchFound)
                {
                    MessageBox.Show("No matching part found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SearchProductsButton_Click(object sender, EventArgs e)
        {
            string searchValue = SearchProductsTextBox.Text.Trim().ToLower();
            productsDataGridView.ClearSelection();
            bool matchFound = false;


            if (!string.IsNullOrEmpty(searchValue))
            {
                foreach (DataGridViewRow row in productsDataGridView.Rows)
                {
                    string idText = row.Cells["ProductID"].Value?.ToString() ?? "";
                    string nameText = row.Cells["Name"].Value?.ToString()?.ToLower() ?? "";

                    if (row.Cells["ProductID"].Value.ToString().Contains(searchValue) ||
                        row.Cells["Name"].Value.ToString().ToLower().Contains(searchValue))
                    {
                        row.Selected = true;
                        matchFound = true;
                        break;
                    }
                }

                if (!matchFound)
                {
                    MessageBox.Show("No matching product found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // --- Exit Application ---

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void AddPartButton_Click(object sender, EventArgs e)
        {
            using (AddPartForm addPartForm = new AddPartForm())
            {
                addPartForm.ShowDialog();
            }
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.CurrentRow == null || !partsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Part selectedPart = (Part)partsDataGridView.CurrentRow.DataBoundItem;

            if (Inventory.isPartAssociated(selectedPart.PartID))
            {
                MessageBox.Show("Cannot delete a part that is associated with a product.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete {selectedPart.Name}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                Inventory.deletePart(selectedPart);
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {

        }
    }
}
