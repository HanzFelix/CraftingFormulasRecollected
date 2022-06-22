using System.Windows.Forms;

namespace CraftingFormulasRecollected
{
    // craft products using the formula
    public partial class CraftDialog : Form
    {
        private AppInstance instance;
        private Formula tempFormula;
        private int maxCraftable;

        // index as reference to the formula list
        private int formulaIndex;

        public CraftDialog(int selectionIndex)
        {
            InitializeComponent();
            instance = AppInstance.GetInstance();
            formulaIndex = selectionIndex;
            tempFormula = instance.GetFormula(selectionIndex);

            // prevent maximum crafting operations from exceeding 1,000 times
            maxCraftable = 1000;

            foreach (ProcessedItem pi in tempFormula.Products)
            {
                ItemListItem li = new ItemListItem(pi.Item, '+', pi.Quantity);
                productListView.AddItem(li);

                // prevent item's stock from summing up to 2 billion after crafting
                int x = (1999999999 - pi.Item.Stock) / pi.Quantity;
                if (x >= 0 && x < maxCraftable)
                {
                    maxCraftable = x;
                }
            }

            foreach (ProcessedItem pi in tempFormula.Materials)
            {
                ItemListItem li = new ItemListItem(pi.Item, '-', pi.Quantity);
                materialListView.AddItem(li);

                // maximum possible crafting operations based on remaining materials
                if ((pi.Item.Stock / pi.Quantity) < maxCraftable)
                    maxCraftable = pi.Item.Stock / pi.Quantity;
            }

            // disable crafting interaction when formula items don't meet criteria
            if (maxCraftable == 0)
            {
                craftQuantityTrackBar.Minimum = 0;
                craftQuantityTrackBar.Maximum = 1;
                craftQuantityTrackBar.Value = 0;
                craftQuantityTrackBar.Enabled = false;
                subTenButton.Enabled = false;
                subOneButton.Enabled = false;
                addOneButton.Enabled = false;
                addTenButton.Enabled = false;
                craftButton.Enabled = false;
            }
            else
            {
                craftQuantityTrackBar.Minimum = 1;
                craftQuantityTrackBar.Maximum = maxCraftable;
                craftQuantityTrackBar.Value = 1;
            }

            minValueLabel.Text = craftQuantityTrackBar.Minimum.ToString();
            maxValueLabel.Text = craftQuantityTrackBar.Maximum.ToString();
            currentValueLabel.Text = craftQuantityTrackBar.Value.ToString();
            Text = "Craft: " + tempFormula.Name;
        }

        // update listitems and currentvaluelabel when changing trackbar value
        private void CraftQuantityTrackBar_ValueChanged(object sender, System.EventArgs e)
        {
            currentValueLabel.Text = craftQuantityTrackBar.Value.ToString();
            for (int i = 0; i < tempFormula.Products.Count; i++)
            {
                ItemListItem li = productListView.ListItemAt(i);
                li.ItemInfo = li.FormattedValue(tempFormula.Products[i].Item.Stock) + " + " + li.FormattedValue(craftQuantityTrackBar.Value * tempFormula.Products[i].Quantity);
            }

            for (int i = 0; i < tempFormula.Materials.Count; i++)
            {
                ItemListItem li = materialListView.ListItemAt(i);
                li.ItemInfo = li.FormattedValue(tempFormula.Materials[i].Item.Stock) + " - " + li.FormattedValue(craftQuantityTrackBar.Value * tempFormula.Materials[i].Quantity);
            }
        }

        // subtract by 10 without going below the minimum
        private void SubTenButton_Click(object sender, System.EventArgs e)
        {
            if ((craftQuantityTrackBar.Value - 10) < craftQuantityTrackBar.Minimum)
            {
                craftQuantityTrackBar.Value = craftQuantityTrackBar.Minimum;
            }
            else
            {
                craftQuantityTrackBar.Value -= 10;
            }
        }

        // subtract by 1 without going below the minimum
        private void SubOneButton_Click(object sender, System.EventArgs e)
        {
            if ((craftQuantityTrackBar.Value - 1) < craftQuantityTrackBar.Minimum)
            {
                craftQuantityTrackBar.Value = craftQuantityTrackBar.Minimum;
            }
            else
            {
                craftQuantityTrackBar.Value--;
            }
        }

        // add 1 without going above the maximum
        private void AddOneButton_Click(object sender, System.EventArgs e)
        {
            if ((craftQuantityTrackBar.Value + 1) > craftQuantityTrackBar.Maximum)
            {
                craftQuantityTrackBar.Value = craftQuantityTrackBar.Maximum;
            }
            else
            {
                craftQuantityTrackBar.Value++;
            }
        }

        // add 10 without going above the maximum
        private void AddTenButton_Click(object sender, System.EventArgs e)
        {
            if ((craftQuantityTrackBar.Value + 10) > craftQuantityTrackBar.Maximum)
            {
                craftQuantityTrackBar.Value = craftQuantityTrackBar.Maximum;
            }
            else
            {
                craftQuantityTrackBar.Value += 10;
            }
        }

        // confirm crafting operation
        private void CraftButton_Click(object sender, System.EventArgs e)
        {
            instance.CraftFormula(formulaIndex, craftQuantityTrackBar.Value);

            DialogResult = DialogResult.OK;
            MessageBox.Show("Crafting for " + tempFormula.Name + " succeeded.", "Crafting Complete");
            Close();
        }
    }
}
