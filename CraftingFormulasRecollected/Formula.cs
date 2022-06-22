using System;
using System.Collections.Generic;
using System.Drawing;

namespace CraftingFormulasRecollected
{
    // Formula consists of a list of products and materials to be used in crafting
    [Serializable]
    public class Formula
    {
        public List<ProcessedItem> Products { get; }
        public List<ProcessedItem> Materials { get; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public Image Image
        {
            get
            {
                if (Products.Count == 0)
                    return Properties.Resources.item_empty;

                return Products[0].Item.Image;
            }
        }

        public Formula()
        {
            Products = new List<ProcessedItem>();
            Materials = new List<ProcessedItem>();
            Name = "";
            Notes = "";
        }

        public void AddProduct(ProcessedItem pi)
        {
            Products.Add(pi);
        }

        public void AddMaterial(ProcessedItem pi)
        {
            Materials.Add(pi);
        }

        public void UpdateProduct(int index, ProcessedItem pi)
        {
            Products[index] = pi;
        }

        public void UpdateMaterial(int index, ProcessedItem pi)
        {
            Materials[index] = pi;
        }

        public void RemoveProduct(int index)
        {
            Products.RemoveAt(index);
        }

        public void RemoveMaterial(int index)
        {
            Materials.RemoveAt(index);
        }
    }
}
