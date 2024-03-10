using csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViksWares.Models
{/// <summary>
 /// Class impliments PerishableItem
 /// </summary>
    public class SaffronPowder : PerishableItem
    {
      
        /// <summary>
        /// This method does not do anything currently as Safron Powder never changes it's price
        /// at the end we alwasys validate the value
        /// </summary>
        public override void UpdateValue()
        {

            ValueValidation();
        }
    }
}
