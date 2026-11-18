using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BFM2Task1
{
    public partial class ModifyPartForm : Form
    {
        private int _partId;

        public ModifyPartForm(Part partToModify)
        {
            InitializeComponent();

            _partId = partToModify.PartID;
            IdTextBox.Text = partToModify.PartID.ToString();
            NameTextBox.Text = partToModify.Name;
            InventoryTextBox.Text = partToModify.InStock.ToString();
            PriceTextBox.Text = partToModify.Price.ToString();
            MaxTextBox.Text = partToModify.Max.ToString();
            MinTextBox.Text = partToModify.Min.ToString();

            if (partToModify is Inhouse inhousePart)
            {
                InHouseRadioButton.Checked = true;
                SourceLabel.Text = "Machine ID";
                SourceTextBox.Text = inhousePart.MachineID.ToString();
            }
            else if (partToModify is Outsourced outsourcedPart)
            {
                OutsourcedRadioButton.Checked = true;
                SourceLabel.Text = "Company Name";
                SourceTextBox.Text = outsourcedPart.CompanyName;
            }
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
                    Inhouse updatedPart = new Inhouse
                    {
                        PartID = _partId,
                        Name = name,
                        InStock = inStock,
                        Price = price,
                        Min = min,
                        Max = max,
                        MachineID = machineId
                    };
                    Inventory.updatePart(_partId, updatedPart);
                }
                else
                {
                    string companyName = SourceTextBox.Text.Trim();
                    if (string.IsNullOrWhiteSpace(companyName))
                    {
                        MessageBox.Show("Company Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Outsourced updatedPart = new Outsourced
                    {
                        PartID = _partId,
                        Name = name,
                        InStock = inStock,
                        Price = price,
                        Min = min,
                        Max = max,
                        CompanyName = companyName
                    };
                    Inventory.updatePart(_partId, updatedPart);
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