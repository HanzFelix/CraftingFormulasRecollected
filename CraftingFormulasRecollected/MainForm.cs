using System;
using System.Windows.Forms;

namespace CraftingFormulasRecollected
{
    public partial class MainForm : Form
    {
        private AppInstance instance;
        public MainForm()
        {
            InitializeComponent();
            instance = AppInstance.GetInstance();

            RefreshLists();
            Text = "Crafting Formulas Recollected - New Project";
        }

        // refreshes the listview with the newer instance of formulas and items
        private void RefreshLists()
        {
            formulaListView.ClearItems();
            itemListView.ClearItems();

            foreach (Formula f in instance.Formulas)
            {
                ItemListItem fItem = new ItemListItem(f);
                fItem.Click += new EventHandler(ItemSelected);
                formulaListView.AddItem(fItem);
            }

            foreach (Item i in instance.Items)
            {
                ItemListItem iItem = new ItemListItem(i);
                iItem.Click += new EventHandler(ItemSelected);
                itemListView.AddItem(iItem);
            }

            craftButton.Enabled = false;
            editButton.Enabled = false;
        }

        // enable buttons once a selection is made
        private void ItemSelected(object sender, EventArgs e)
        {
            // enable buttons on selection
            craftButton.Enabled = true;
            editButton.Enabled = true;
        }

        // update buttons based on selected tab
        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl.SelectedTab.Equals(formulasTab))
            {
                craftButton.Visible = true;
                editButton.Text = "Edit Formula";
                newButton.Text = "New Formula";

                itemListView.ClearSelection();
            }
            else if (tabControl.SelectedTab.Equals(itemsTab))
            {
                craftButton.Visible = false;
                editButton.Text = "Edit Item";
                newButton.Text = "New Item";

                formulaListView.ClearSelection();
            }

            craftButton.Enabled = false;
            editButton.Enabled = false;
        }

        // dialog to add a new formula/item to the list
        private void NewButton_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Equals(formulasTab))
            {
                if (new ManageFormulaDialog().ShowDialog() != DialogResult.Cancel)
                    RefreshLists();
            }
            else if (tabControl.SelectedTab.Equals(itemsTab))
            {
                if (new ManageItemDialog().ShowDialog() != DialogResult.Cancel)
                    RefreshLists();
            }
        }

        // dialog to edit the selected formula/item from the list
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Equals(formulasTab))
            {
                if (new ManageFormulaDialog(formulaListView.SelectionIndex).ShowDialog() != DialogResult.Cancel)
                    RefreshLists();
            }
            else if (tabControl.SelectedTab.Equals(itemsTab))
            {
                if (new ManageItemDialog(itemListView.SelectionIndex).ShowDialog() != DialogResult.Cancel)
                    RefreshLists();
            }
        }

        // dialog to craft with the selected formula
        private void CraftButton_Click(object sender, EventArgs e)
        {
            if (new CraftDialog(formulaListView.SelectionIndex).ShowDialog() != DialogResult.Cancel)
                RefreshLists();
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            // prompt whether to save changes or not.
            if (!instance.IsSaved)
            {
                DialogResult result = MessageBox.Show("There are unsaved changes to the current project.\nDo you want to save it first?", "New File", MessageBoxButtons.YesNoCancel); // TODO: update text & caption
                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        if (!instance.SaveAppInstance(false))
                            return;
                        break;
                    default:
                        break;
                }
            }

            instance.NewInstance();
            RefreshLists();
            Text = "Crafting Formulas Recollected - New Project";
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            // if current work is unsaved
            if (!instance.IsSaved)
            {
                DialogResult result = MessageBox.Show("There are unsaved changes to the current project.\nDo you want to save it first?", "Open File", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        if (!instance.SaveAppInstance(false))
                            return;
                        break;
                    default:
                        break;
                }
            }

            // call open file dialog and read list
            if (instance.OpenAppInstance())
            {
                instance = AppInstance.GetInstance();
                RefreshLists();
                Text = "Crafting Formulas Recollected - " + instance.FilePath;
            }
        }

        // save
        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (instance.SaveAppInstance(false))
                Text = "Crafting Formulas Recollected - " + instance.FilePath;
        }

        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            // open savedialog and save
            if (instance.SaveAppInstance(true))
                Text = "Crafting Formulas Recollected - " + instance.FilePath;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            // work unsaved?
            if (!instance.IsSaved)
            {
                DialogResult result = MessageBox.Show("There are unsaved changes to the current project.\nDo you want to save it first?", "Exit", MessageBoxButtons.YesNoCancel); // TODO: update text & caption
                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        if (!instance.SaveAppInstance(false))
                            return;
                        break;
                    default:
                        break;
                }
            }
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!instance.IsSaved)
            {
                DialogResult result = MessageBox.Show("There are unsaved changes to the current project.\nDo you want to save it first?", "Exit", MessageBoxButtons.YesNoCancel); // TODO: update text & caption
                switch (result)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        if (!instance.SaveAppInstance(false))
                            e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
