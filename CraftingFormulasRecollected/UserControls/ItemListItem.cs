using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CraftingFormulasRecollected
{
    public partial class ItemListItem : UserControl, INotifyPropertyChanged
    {
        private bool isChecked;
        private ItemState itemState;
        public bool Checked
        {
            get
            {
                return isChecked;

            }
            set
            {
                if (value != isChecked)
                {
                    isChecked = value;
                    RecolorCheckState();
                    NotifyPropertyChanged();
                }
            }
        }
        public ItemState State
        {
            get
            {
                return itemState;
            }
            set
            {
                if (itemState != value)
                {
                    itemState = value;
                    RecolorInfoState();
                }
            }
        }
        public string ItemName
        {
            get { return nameLabel.Text; }
            set { nameLabel.Text = value; }
        }
        public Image Image
        {
            get { return itemImage.BackgroundImage; }
            set { itemImage.BackgroundImage = value; }
        }

        public string ItemInfo
        {
            get { return infoLabel.Text; }
            set { infoLabel.Text = value; }
        }

        public ItemListItem()
        {
            InitializeComponent();
        }

        public ItemListItem(Formula formula)
        {
            InitializeComponent();
            nameLabel.Text = formula.Name;
            itemImage.BackgroundImage = formula.Image;
            infoLabel.Text = formula.Products.Count > 1 ? "+" + (formula.Products.Count - 1).ToString() : "";
            toolTip.SetToolTip(itemImage, formula.Name);
        }

        public ItemListItem(Item item)
        {
            InitializeComponent();
            nameLabel.Text = item.Name;
            itemImage.BackgroundImage = item.Image;
            infoLabel.Text = FormattedValue(item.Stock);
            toolTip.SetToolTip(itemImage, item.Name);
            if (item.Stock == 0)
                State = ItemState.Zero;
        }

        public ItemListItem(ProcessedItem pItem)
        {
            InitializeComponent();
            nameLabel.Text = pItem.Item.Name;
            itemImage.BackgroundImage = pItem.Item.Image;
            infoLabel.Text = FormattedValue(pItem.Quantity);
            toolTip.SetToolTip(itemImage, pItem.Item.Name);
        }

        public ItemListItem(Item item, char sign, int changedQuantity)
        {
            InitializeComponent();
            nameLabel.Text = item.Name;
            itemImage.BackgroundImage = item.Image;
            infoLabel.Text = FormattedValue(item.Stock) + " " + sign + " " + FormattedValue(changedQuantity);
            toolTip.SetToolTip(itemImage, item.Name);

            if (changedQuantity == 0)
            {
                State = ItemState.Normal;
            }
            else if (sign == '+')
            {
                State = ItemState.Gain;
            }
            else if (item.Stock < changedQuantity && sign == '-')
            {
                State = ItemState.Zero;
            }
            else
            {
                State = ItemState.Loss;
            }
        }
        // this still needed?
        public void UpdateCraftableQuantity(Item item, char sign, int changedQuantity)
        {
            infoLabel.Text = FormattedValue(item.Stock) + " " + sign + " " + FormattedValue(changedQuantity);

            if (changedQuantity == 0)
            {
                State = ItemState.Normal;
            }
            else if (sign == '+')
            {
                State = ItemState.Gain;
            }
            else if (item.Stock < changedQuantity && sign == '-')
            {
                State = ItemState.Zero;
            }
            else
            {
                State = ItemState.Loss;
            }
        }

        public void UpdateAsItem(Item item)
        {
            nameLabel.Text = item.Name;
            itemImage.BackgroundImage = item.Image;
            infoLabel.Text = FormattedValue(item.Stock);
            if (item.Stock == 0)
                State = ItemState.Zero;
        }

        public string FormattedValue(int num)
        {
            // 0 to 999
            if (num < 1000)
                return num.ToString();

            // 1K to 99.9K
            if (num < 100000)
                return (Math.Floor(num * 0.01) / 10).ToString("0.#K");

            // 100k to 999k
            if (num < 1000000)
                return Math.Floor(num * 0.001).ToString("0K");

            // 1M to 99.9M
            if (num < 100000000)
                return (Math.Floor(num * 0.00001) / 10).ToString("0.#M");

            // 100M to 999M
            if (num < 1000000000)
                return Math.Floor(num * 0.000001).ToString("0M");

            // 1B to 2.1B
            if (num < int.MaxValue)
                return (Math.Floor(num * 0.00000001) / 10).ToString("#,##0.#B");

            return "Error";
        }

        private void RecolorCheckState()
        {
            if (isChecked)
            {
                this.BackColor = SystemColors.Highlight;
                nameLabel.BackColor = SystemColors.Highlight;
                nameLabel.ForeColor = SystemColors.HighlightText;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                nameLabel.BackColor = SystemColors.Control;
                nameLabel.ForeColor = SystemColors.ControlText;
            }
        }

        private void RecolorInfoState()
        {
            switch (itemState)
            {
                case ItemState.Normal:
                    infoLabel.ForeColor = SystemColors.ControlText;
                    break;
                case ItemState.Zero:
                    infoLabel.ForeColor = Color.Red;
                    break;
                case ItemState.Loss:
                    infoLabel.ForeColor = Color.SaddleBrown;
                    break;
                case ItemState.Gain:
                    infoLabel.ForeColor = Color.Green;
                    break;
                default:
                    infoLabel.ForeColor = Color.Gray;
                    break;
            }
        }

        private void FormulaListItem_Click(object sender, EventArgs e)
        {
            Checked = true;
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void ItemImage_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
