using csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViksWares.Models
{

    /// <summary>
    /// Class inherits  from the class item so it has all the attricbutes and methods of the item class
    /// </summary>
    public class PerishableItem : Item
    {
        public PerishableItem() {

           
        }

        /// <summary>
        /// This is a method that can be used by every child class
        /// this will make sure that unless the Item is seffron the Value is between 0 and 50
        /// </summary>
        public  void ValueValidation()
        {
            if (!(this is SaffronPowder))
            { // Ensure value stays within the range of 0 to 50
                Value = Math.Max(0, Math.Min(50, Value));
            }
        }
        /// <summary>
        /// This is a virtual method to update the Value.
        /// Ordinery items decrease a value by 1 when sell by date is > 0  and then 
        /// since this method is a virtual method it can be overloaded by cildren classes and which will allow each specific item to have 
        /// its own calculation of how the value changes
        /// ValueValidaton method is to be called  to cack that value stays between 0 and 50 if not safron
        /// </summary>
        public virtual void UpdateValue()
        {
           if(SellBy > 0)
            {
                Value = Value - 1;
            }
            else
            {
                Value = Value - 2;
            }
            ValueValidation();
        }

        
    }
}
