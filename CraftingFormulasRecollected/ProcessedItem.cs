using System;

namespace CraftingFormulasRecollected
{
    // Items that are used in formulas to measure the quantity needed
    [Serializable]
    public class ProcessedItem
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }

        public ProcessedItem()
        {
            Item = new Item();
            Quantity = 0;
        }
        public ProcessedItem(Item item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }
    }
}
