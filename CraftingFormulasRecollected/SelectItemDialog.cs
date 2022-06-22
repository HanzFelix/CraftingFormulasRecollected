using System;
using System.Windows.Forms;

namespace CraftingFormulasRecollected
{
    // selecting an item to add to the editing formula
    public partial class SelectItemDialog : Form
    {
        private AppInstance instance;

        // ProcessedItem to retrieve after dialog confirmation
        public ProcessedItem SelectedProcessedItem { get; set; }

        // "Add to Formula" state
        public SelectItemDialog()
        {
            InitializeComponent();
            instance = AppInstance.GetInstance();
            SelectedProcessedItem = new ProcessedItem();

            foreach (Item i in instance.Items)
            {
                ItemListItem iItem = new ItemListItem(i);
                iItem.Click += new EventHandler(ItemSelected);
                itemListView.AddItem(iItem);
            }

            confirmButton.Enabled = false;
            confirmButton.Text = "Add";
        }

        // "Edit Formula's Item" state
        public SelectItemDialog(ProcessedItem pItem)
        {
            InitializeComponent();
            instance = AppInstance.GetInstance();
            SelectedProcessedItem = pItem;

            for (int i = 0; i < instance.Items.Count; i++)
            {
                ItemListItem iItem = new ItemListItem(instance.Items[i]);
                iItem.Click += new EventHandler(ItemSelected);
                itemListView.AddItem(iItem);

                if (instance.Items[i].Equals(pItem.Item))
                {
                    iItem.Checked = true;
                    itemListView.SelectionIndex = i;
                }
            }

            quantityNumeric.Value = pItem.Quantity;
            confirmButton.Text = "Save";
        }

        // allow user to confirm the selection after choosing an item
        private void ItemSelected(object sender, EventArgs e)
        {
            confirmButton.Enabled = true;
        }

        // save the quantity and item once the item is confirmed
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SelectedProcessedItem.Item = instance.GetItem(itemListView.SelectionIndex);
            SelectedProcessedItem.Quantity = (int)quantityNumeric.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        // subtract by 10 without going below the minimum
        private void quantitySubTenButton_Click(object sender, EventArgs e)
        {
            if ((quantityNumeric.Value - 10) < quantityNumeric.Minimum)
            {
                quantityNumeric.Value = quantityNumeric.Minimum;
            }
            else
            {
                quantityNumeric.Value -= 10;
            }
        }

        // add 10 without going above the maximum
        private void quantityAddTenButton_Click(object sender, EventArgs e)
        {
            if ((quantityNumeric.Value + 10) > quantityNumeric.Maximum)
            {
                quantityNumeric.Value = quantityNumeric.Maximum;
            }
            else
            {
                quantityNumeric.Value += 10;
            }
        }
    }
}
