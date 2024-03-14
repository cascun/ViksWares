using csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViksWares.Models
{

    /// <summary>
    /// This class inherits from the Item class, thereby inheriting all its attributes and methods.
    /// </summary>
    public class PerishableItem : Item
    {
        public PerishableItem() {
            // Constructor implementation
        }

        /// This method ensures that the value of the item stays within the ra
        /// <summary>nge of 0 to 50,
        /// except for Saffron Powder.
        /// </summary>
        public void ValueValidation()
        {
            if (!(this is SaffronPowder))
            { // Ensure value stays within the range of 0 to 50
                Value = Math.Max(0, Math.Min(50, Value));
            }
        }

        /// <summary>
        /// This virtual method updates the value of the item.
        /// Ordinary items decrease in value by 1 when the sell-by date is greater than 0,
        /// and by 2 when the sell-by date is less than or equal to 0.
        /// Since this method is virtual, it can be overridden by child classes to provide
        /// specific behavior for different types of items.
        /// The ValueValidation method is called to ensure that the value stays within the
        /// acceptable range (0 to 50) if the item is not Saffron Powder.
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
