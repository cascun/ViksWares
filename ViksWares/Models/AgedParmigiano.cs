using csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViksWares.Models
{
    /// <summary>
    /// This class represents Aged Parmigiano, which is a type of perishable item.
    /// </summary>
    public class AgedParmigiano : PerishableItem
    {   

        public AgedParmigiano() {
            // Constructor implementation
        }

        /// <summary>
        /// This method overrides the UpdateValue method of the base class.
        /// For Aged Parmigiano, the value increases by 1 each day if SellBy is more then 0,
        /// value increases by 2 if value is 0 or less.
        /// After updating the value, the ValueValidation method is called to ensure
        /// that the value stays within the acceptable range (0 to 50).
        /// </summary>
        public override void UpdateValue()
        {
            if(SellBy> 0)
            {

                Value = Value + 1;
            }
            else
            {

                Value = Value + 2;
            }

            ValueValidation();
        }
    }
}
