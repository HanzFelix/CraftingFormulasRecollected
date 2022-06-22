using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CraftingFormulasRecollected
{
    [Serializable]
    public class AppInstance
    {
        private static AppInstance instance = new AppInstance();

        public List<Formula> Formulas { get; private set; }
        public List<Item> Items { get; private set; }

        // whether the instance was modified since last save or not
        public bool IsSaved { get; private set; }
        public string FilePath { get; private set; }
        
        // placeholder item for deleted items in formulas
        private Item nowDeletedItem;
        private AppInstance()
        {
            Items = new List<Item>();
            Formulas = new List<Formula>();
            FilePath = "";
            nowDeletedItem = new Item()
            {
                Name = "Deleted Item",
                Image = Properties.Resources.item_deleted
            };
            InitializeDefaultFormulas();
        }
        public static AppInstance GetInstance()
        {
            return instance;
        }

        // Creates a new instance without the default formulas
        public void NewInstance()
        {
            Items = new List<Item>();
            Formulas = new List<Formula>();
            FilePath = "";
            IsSaved = true;
        }

        private void InitializeDefaultFormulas()
        {
            Item cube_m = new Item()
            {
                Name = "Rusted Cube",
                Image = Properties.Resources.material_cube_default,
                Stock = 25
            };
            Item extr_m = new Item()
            {
                Name = "Cleansing Extract",
                Image = Properties.Resources.material_extract_default,
                Stock = 30
            };
            Item cube_p = new Item()
            {
                Name = "Polished Cube",
                Image = Properties.Resources.product_cube_default,
                Stock = 5
            };

            Formula formula = new Formula()
            {
                Name = cube_p.Name
            };
            formula.AddMaterial(new ProcessedItem(cube_m, 3));
            formula.AddMaterial(new ProcessedItem(extr_m, 1));
            formula.AddProduct(new ProcessedItem(cube_p, 2));

            Items.Add(cube_m);
            Items.Add(extr_m);
            Items.Add(cube_p);

            Formulas.Add(formula);
            IsSaved = true;
        }

        // get the formula from the specified index
        public Formula GetFormula(int index)
        {
            return Formulas[index];
        }

        // get the item from the specified index
        public Item GetItem(int index)
        {
            return Items[index];
        }

        // add a new formula
        public void AddFormula(Formula formula)
        {
            Formulas.Add(formula);
            IsSaved = false;
        }

        // add a new item
        public void AddItem(Item item)
        {
            Items.Add(item);
            IsSaved = false;
        }

        // update a formula with the provided formula
        public void UpdateFormula(int index, Formula formula)
        {
            Formulas[index] = formula;
            IsSaved = false;
        }

        // update an item with the provided item
        public void UpdateItem(int index, Item item)
        {
            Items[index] = item;
            IsSaved = false;
        }

        // delete the formula from the list
        public void DeleteFormula(int index)
        {
            Formulas.RemoveAt(index);
            IsSaved = false;
        }

        // delete the item from Formulas and Items
        public void DeleteItem(int index)
        {
            Item item = Items[index];
            foreach (Formula f in Formulas)
            {
                foreach (ProcessedItem pi in f.Products)
                {
                    if (pi.Item.Equals(item))
                    {
                        pi.Item = nowDeletedItem;
                        pi.Quantity = 0;
                    }
                }
                foreach (ProcessedItem pi in f.Materials)
                {
                    if (pi.Item.Equals(item))
                    {
                        pi.Item = nowDeletedItem;
                        pi.Quantity = 0;
                    }
                }
            }
            Items.RemoveAt(index);
            IsSaved = false;
        }

        // craft a formula with the specified number of operations
        public void CraftFormula(int formulaIndex, int craftQuantity)
        {
            Formula f = Formulas[formulaIndex];
            for (int i = 0; i < f.Products.Count; i++)
            {
                Item tempItem = f.Products[i].Item;
                tempItem.Stock += f.Products[i].Quantity * craftQuantity;

                UpdateItem(Items.IndexOf(f.Products[i].Item), tempItem);
            }

            for (int i = 0; i < f.Materials.Count; i++)
            {
                Item tempItem = f.Materials[i].Item;
                tempItem.Stock -= f.Materials[i].Quantity * craftQuantity;

                UpdateItem(Items.IndexOf(f.Materials[i].Item), tempItem);
            }
            IsSaved = false;
        }

        // Loads the instance from a file
        public bool OpenAppInstance()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Crafting Formula Savefile (*.cfs)|*.cfs|All files (*.*)|*.*";
                ofd.DefaultExt = "cfs";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileStream f = File.OpenRead(ofd.FileName);
                        BinaryFormatter bf = new BinaryFormatter();
                        instance = (AppInstance)bf.Deserialize(f);
                        FilePath = ofd.FileName;
                        IsSaved = true;
                        f.Close();
                        return true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("There was an error opening the project."
                            + "\nIt may be in an unsupported or invalid format.", "Failed to load project");
                    }
                }
            }
            return false;
        }

        // Saves the instance in a file
        public bool SaveAppInstance(bool isNewFilePath)
        {
            try
            {
                if (isNewFilePath || FilePath.Equals(""))
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Crafting Formula Savefile (*.cfs)|*.cfs|All files (*.*)|*.*";
                    sfd.RestoreDirectory = true;
                    sfd.FileName = "NewProject";
                    sfd.DefaultExt = "cfs";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        FilePath = sfd.FileName;
                    }
                    else
                    {
                        return false;
                    }
                }

                FileStream f = File.OpenWrite(FilePath);
                BinaryFormatter bf = new BinaryFormatter();
                IsSaved = true;
                bf.Serialize(f, instance);
                f.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
    }
}
