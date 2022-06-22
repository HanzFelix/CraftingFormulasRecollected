using System;
using System.Windows.Forms;

namespace CraftingFormulasRecollected
{
    // Add, Edit, or Delete a Formula
    public partial class ManageFormulaDialog : Form
    {
        private readonly int selectionIndex;
        private readonly bool isEditing;
        private AppInstance instance;
        private Formula tempFormula;

        // "New Formula" state
        public ManageFormulaDialog()
        {
            InitializeComponent();
            instance = AppInstance.GetInstance();
            isEditing = false;

            tempFormula = new Formula();
            deleteButton.Visible = false;
            confirmButton.Text = "Add";
            Text = "New Formula";
        }

        // "Edit Formula" state
        public ManageFormulaDialog(int selectionIndex)
        {
            InitializeComponent();
            this.selectionIndex = selectionIndex;
            instance = AppInstance.GetInstance();
            isEditing = true;

            tempFormula = instance.GetFormula(selectionIndex);

            Text = "Edit Formula: " + tempFormula.Name;
            formulaNameTextBox.Text = tempFormula.Name;
            notesTextBox.Text = tempFormula.Notes;

            RefreshProductList();
            RefreshMaterialList();

            confirmButton.Text = "Save";
        }

        // clear the productlistview and add the formula products to the listview again.
        private void RefreshProductList()
        {
            productListView.ClearItems();
            foreach (ProcessedItem pi in tempFormula.Products)
            {
                ItemListItem pItem = new ItemListItem(pi);
                pItem.Click += new EventHandler(ProductItemSelected);
                productListView.AddItem(pItem);
            }
            editProductButton.Enabled = false;
            removeProductButton.Enabled = false;
        }

        // clear the materiallistview and add the formula materials to the listview again.
        private void RefreshMaterialList()
        {
            materialListView.ClearItems();
            foreach (ProcessedItem pi in tempFormula.Materials)
            {
                ItemListItem mItem = new ItemListItem(pi);
                mItem.Click += new EventHandler(MaterialItemSelected);
                materialListView.AddItem(mItem);
            }
            editMaterialButton.Enabled = false;
            removeMaterialButton.Enabled = false;
        }

        // allow user to manage selection after choosing a product in the listview
        private void ProductItemSelected(object sender, EventArgs e)
        {
            // enable buttons on selection
            editProductButton.Enabled = true;
            removeProductButton.Enabled = true;
        }

        // allow user to manage selection after choosing a material in the listview
        private void MaterialItemSelected(object sender, EventArgs e)
        {
            // enable buttons on selection
            editMaterialButton.Enabled = true;
            removeMaterialButton.Enabled = true;
        }


        // add a product using SelectItemDialog
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            using (SelectItemDialog sid = new SelectItemDialog())
            {
                if (sid.ShowDialog() == DialogResult.OK)
                {
                    tempFormula.AddProduct(sid.SelectedProcessedItem);
                    RefreshProductList();

                    // use first product's name if only one in the list so far.
                    if (tempFormula.Products.Count == 1)
                        formulaNameTextBox.Text = sid.SelectedProcessedItem.Item.Name;
                }
            }
        }

        // add a material using SelectItemDialog
        private void AddMaterialButton_Click(object sender, EventArgs e)
        {
            using (SelectItemDialog sid = new SelectItemDialog())
            {
                if (sid.ShowDialog() == DialogResult.OK)
                {
                    tempFormula.AddMaterial(sid.SelectedProcessedItem);
                    RefreshMaterialList();
                }
            }
        }

        // edit a product using SelectItemDialog
        private void EditProductButton_Click(object sender, EventArgs e)
        {
            using (SelectItemDialog sid = new SelectItemDialog(tempFormula.Products[productListView.SelectionIndex]))
            {
                if (sid.ShowDialog() == DialogResult.OK)
                {
                    tempFormula.UpdateProduct(productListView.SelectionIndex, sid.SelectedProcessedItem);
                    RefreshProductList();

                    // update the formula's name when still the only one in the list.
                    if (tempFormula.Products.Count == 1)
                        formulaNameTextBox.Text = sid.SelectedProcessedItem.Item.Name;
                }
            }
        }

        // edit a product using SelectItemDialog
        private void EditMaterialButton_Click(object sender, EventArgs e)
        {
            using (SelectItemDialog sid = new SelectItemDialog(tempFormula.Materials[materialListView.SelectionIndex]))
            {
                if (sid.ShowDialog() == DialogResult.OK)
                {
                    tempFormula.UpdateMaterial(materialListView.SelectionIndex, sid.SelectedProcessedItem);
                    RefreshMaterialList();
                }
            }
        }

        // remove the product from the formula
        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            tempFormula.RemoveProduct(productListView.SelectionIndex);
            RefreshProductList();
        }

        // remove the material from the formula
        private void RemoveMaterialButton_Click(object sender, EventArgs e)
        {
            tempFormula.Materials.RemoveAt(materialListView.SelectionIndex);
            RefreshMaterialList();
        }

        // delete the formula
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this formula?\nThis cannot be undone.",
                                       "Delete Formula",
                                       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                instance.DeleteFormula(selectionIndex);
                DialogResult = DialogResult.Yes;
                Close();
            }
        }

        // add/save the formula by retrieving the field values
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            tempFormula.Name = formulaNameTextBox.Text;
            tempFormula.Notes = notesTextBox.Text;

            if (isEditing)
                instance.UpdateFormula(selectionIndex, tempFormula);
            else
                instance.AddFormula(tempFormula);

            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
