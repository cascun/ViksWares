using csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViksWares.Models
{
    /// <summary>
    /// This class represents refrigerated items, which are a type of perishable item.
    /// </summary>
    public class Refrigerated : PerishableItem
    {
        public Refrigerated() {
            // Constructor implementation
        }
       
        /// <summary>
        /// This method overrides the UpdateValue method of the base class.
        /// For refrigerated items, the value decreases twice as fast:
        /// - If the sell-by date is greater than 0, the value decreases by 2 each day.
        /// - If the sell-by date is 0 or less, the value decreases by 4 each day.
        /// After updating the value, the ValueValidation method is called to ensure
        /// that the value stays within the acceptable range (0 to 50).
        /// </summary>
        public override void UpdateValue()
        {
            if (SellBy > 0)
            {
                Value = Value - 2;
            }
            else
            {
                Value = Value - 4;
            }
            // Validate the value to ensure it stays within the acceptable range
            ValueValidation();
        }
    }
}
