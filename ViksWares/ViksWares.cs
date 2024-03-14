using System.Collections.Generic;
using ViksWares.Models;

namespace csharp
{
    public class ViksWares
    {
        IList<Item> Items;
        public ViksWares(IList<Item> Items)
        {
            this.Items = Items;
        }

        /// <summary>
        /// Updates the value of each perishable item in the inventory.
        /// Iterates through all items, casting each one to PerishableItem to call the overridden UpdateValue method,
        /// which updates the item's value according to its specific behavior.
        /// Decrements the sell-by date for each item.
        /// </summary>
        public void UpdateValue()
        {
            foreach (var item in Items)
            {                
                // Cast each item to PerishableItem and call its UpdateValue method
                ((PerishableItem)item).UpdateValue();

                // Decrease the sell-by date for the item if item not SaffronPowder

                ((PerishableItem)item).UpdateSellBy();
                //if (!(item is SaffronPowder))
                //{
                //    item.SellBy = item.SellBy - 1;
                //}

            }
        }

        //public void UpdateValue()
        //{
        //    for (var i = 0; i < Items.Count; i++)
        //    {
        //        if (Items[i].Name != "Aged Parmigiano" && Items[i].Name != "Concert tickets to Talkins Festival")
        //        {
        //            if (Items[i].Value > 0)
        //            {
        //                if (Items[i].Name != "Saffron Powder")
        //                {
        //                    Items[i].Value = Items[i].Value - 1;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            if (Items[i].Value < 50)
        //            {
        //                Items[i].Value = Items[i].Value + 1;

        //                if (Items[i].Name == "Concert tickets to Talkins Festival")
        //                {
        //                    if (Items[i].SellBy < 11)
        //                    {
        //                        if (Items[i].Value < 50)
        //                        {
        //                            Items[i].Value = Items[i].Value + 1;
        //                        }
        //                    }

        //                    if (Items[i].SellBy < 6)
        //                    {
        //                        if (Items[i].Value < 50)
        //                        {
        //                            Items[i].Value = Items[i].Value + 1;
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        if (Items[i].Name != "Saffron Powder")
        //        {
        //            Items[i].SellBy = Items[i].SellBy - 1;
        //        }

        //        if (Items[i].SellBy < 0)
        //        {
        //            if (Items[i].Name != "Aged Parmigiano")
        //            {
        //                if (Items[i].Name != "Concert tickets to Talkins Festival")
        //                {
        //                    if (Items[i].Value > 0)
        //                    {
        //                        if (Items[i].Name != "Saffron Powder")
        //                        {
        //                            Items[i].Value = Items[i].Value - 1;
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    Items[i].Value = Items[i].Value - Items[i].Value;
        //                }
        //            }
        //            else
        //            {
        //                if (Items[i].Value < 50)
        //                {
        //                    Items[i].Value = Items[i].Value + 1;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
