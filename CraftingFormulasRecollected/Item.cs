using System;
using System.Drawing;

namespace CraftingFormulasRecollected
{
    [Serializable]
    public class Item
    {
        public string Name { get; set; }
        public Image Image { get; set; }
        public int Stock { get; set; }
        public string Notes { get; set; }

        public Item()
        {
            Name = "New Item";
            Image = Properties.Resources.item_empty;
            Stock = 0;
            Notes = "";
        }

        public Item(string name, Image image, int stock, string note)
        {
            Name = name;
            Image = image;
            Stock = stock;
            Notes = note;
        }
    }
}
