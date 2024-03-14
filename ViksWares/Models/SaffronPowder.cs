using csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViksWares.Models
{

    /// <summary>
    /// This class represents Saffron Powder, which is a type of perishable item.
    /// </summary>
    public class SaffronPowder : PerishableItem
    {
        public SaffronPowder()
        {
            // Constructor implementation
        }

        public override void UpdateSellBy()
        {
            
        }
        /// <summary>
        /// This method does not update the value of Saffron Powder, as its price never changes.
        /// After updating the value (which does nothing), the ValueValidation method is called
        /// to ensure that the value stays within the acceptable range (0 to 50), although this
        /// is not necessary for Saffron Powder.
        /// </summary>
        public override void UpdateValue()
        {
            Value = 80;
            ValueValidation();
        }
    }
}
