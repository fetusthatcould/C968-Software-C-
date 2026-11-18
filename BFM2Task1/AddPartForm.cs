using System;
using System.Windows.Forms;

namespace BFM2Task1
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
            InHouseRadioButton.Checked = true;
            IdTextBox.Text = "Auto-Gen";
        }

        private void InHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (InHouseRadioButton.Checked)
            {
                SourceLabel.Text = "Machine ID";
            }
        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OutsourcedRadioButton.Checked)
            {
                SourceLabel.Text = "Company Name";
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
                    MessageBox.Show("Part name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                if (InHouseRadioButton.Checked)
                {
                    int machineId = int.Parse(SourceTextBox.Text);
                    Inhouse newPart = new Inhouse
                    {
                        PartID = Inventory.GeneratePartID(),
                        Name = name,
                        InStock = inStock,
                        Price = price,
                        Min = min,
                        Max = max,
                        MachineID = machineId
                    };
                    Inventory.addPart(newPart);
                }
                else
                {
                    string companyName = SourceTextBox.Text.Trim();
                    if (string.IsNullOrWhiteSpace(companyName))
                    {
                        MessageBox.Show("Company Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Outsourced newPart = new Outsourced
                    {
                        PartID = Inventory.GeneratePartID(),
                        Name = name,
                        InStock = inStock,
                        Price = price,
                        Min = min,
                        Max = max,
                        CompanyName = companyName
                    };
                    Inventory.addPart(newPart);
                }

                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Inventory, Price, Min, Max, and Machine ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}