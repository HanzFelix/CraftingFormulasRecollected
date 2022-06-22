using System;
using System.Windows.Forms;

namespace CraftingFormulasRecollected.UserControls
{
    public partial class ItemListView : UserControl
    {
        public bool WrapContents
        {
            get
            {
                return (flowLayoutPanel.WrapContents);
            }
            set
            {
                flowLayoutPanel.WrapContents = value;
            }
        }
        public int SelectionIndex { get; set; }
        public ItemListView()
        {
            InitializeComponent();
        }

        public void AddItem(ItemListItem item)
        {
            item.Click += new EventHandler(ItemSelect);
            flowLayoutPanel.Controls.Add(item);
        }
        private void ItemSelect(object sender, EventArgs e)
        {
            ItemListItem listItem = (ItemListItem)sender;
            foreach (ItemListItem item in flowLayoutPanel.Controls)
            {
                if (!listItem.Equals(item))
                    item.Checked = false;
            }
            SelectionIndex = flowLayoutPanel.Controls.IndexOf(listItem);
        }

        public ItemListItem ListItemAt(int index)
        {
            return (ItemListItem)flowLayoutPanel.Controls[index];
        }

        public void ClearSelection()
        {
            foreach (ItemListItem item in flowLayoutPanel.Controls)
                item.Checked = false;
        }

        public void ClearItems()
        {
            flowLayoutPanel.Controls.Clear();
        }
    }
}
