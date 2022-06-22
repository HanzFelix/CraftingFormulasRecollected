using System;
using System.Drawing;
using System.Windows.Forms;

namespace CraftingFormulasRecollected
{
    // Add, Edit, or Delete an Item
    public partial class ManageItemDialog : Form
    {
        private AppInstance instance;
        private Item tempItem;
        private int selectionIndex;
        private bool isEditing;

        // "New Formula" state
        public ManageItemDialog()
        {
            InitializeComponent();
            instance = AppInstance.GetInstance();
            tempItem = new Item();

            itemNameTextBox.Text = tempItem.Name;
            stockNumeric.Value = tempItem.Stock;
            notesTextBox.Text = tempItem.Notes;

            itemPreview.UpdateAsItem(tempItem);
            isEditing = false;
            deleteButton.Visible = false;
            confirmButton.Text = "Add";
            Text = "New Item";
        }

        // "Edit Formula" state
        public ManageItemDialog(int selectionIndex)
        {
            InitializeComponent();
            instance = AppInstance.GetInstance();
            this.selectionIndex = selectionIndex;
            isEditing = true;

            tempItem = instance.GetItem(selectionIndex);

            itemNameTextBox.Text = tempItem.Name;
            stockNumeric.Value = tempItem.Stock;
            notesTextBox.Text = tempItem.Notes;

            itemPreview.UpdateAsItem(tempItem);
            confirmButton.Text = "Save";
            Text = "Edit Item: " + tempItem.Name;
        }

        // prompt a confirmation before deleting the formula
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Formulas that use this item will be altered.\n\nAre you sure you want to delete it?",
                                       "Delete Item",
                                       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                instance.DeleteItem(selectionIndex);
                DialogResult = DialogResult.Yes;
                Close();
            }
        }

        // add/save the item by retrieving the field values
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            tempItem.Name = itemNameTextBox.Text;
            tempItem.Image = itemPreview.Image;
            tempItem.Stock = (int)stockNumeric.Value;
            tempItem.Notes = notesTextBox.Text;

            if (isEditing)
                instance.UpdateItem(selectionIndex, tempItem);
            else
                instance.AddItem(tempItem);

            DialogResult = DialogResult.Yes;
            Close();
        }

        // opens a filedialog to choose an image
        private void BrowseImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Picture Files (*.bmp;*.gif;*.jpeg;*.jpg;*.png)|*.bmp;*.gif;*.jpeg;*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        itemPreview.Image = Image.FromFile(ofd.FileName);
                    }
                    catch (OutOfMemoryException)
                    {
                        MessageBox.Show("There was an error opening the image."
                            + "\nIt may be in an unsupported or invalid format.");
                    }
                }
            }
        }

        // resets the item's image to default
        private void ClearImageButton_Click(object sender, EventArgs e)
        {
            itemPreview.Image = Properties.Resources.item_empty;
        }

        // update the itempreview's item name when textbox's text has changed.
        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            itemPreview.ItemName = itemNameTextBox.Text;
        }

        // update the itempreview when stock quantity has changed
        private void stockNumeric_ValueChanged(object sender, EventArgs e)
        {
            itemPreview.ItemInfo = itemPreview.FormattedValue((int)stockNumeric.Value);
        }

        // subtract by 10 without going below the minimum
        private void stockSubTenButton_Click(object sender, EventArgs e)
        {
            if (stockNumeric.Value < 10)
            {
                stockNumeric.Value = 0;
            }
            else
            {
                stockNumeric.Value -= 10;
            }
        }

        // add 10 without going above the maximum
        private void stockAddTenButton_Click(object sender, EventArgs e)
        {
            if (stockNumeric.Value > (stockNumeric.Maximum - 10))
            {
                stockNumeric.Value = stockNumeric.Maximum;
            }
            else
            {
                stockNumeric.Value += 10;
            }
        }
    }
}
