using csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViksWares.Models
{
    /// <summary>
    /// Class impliments PerishableItem
    /// </summary>
    public class Refrigerated : PerishableItem
    {
        public Refrigerated() { }
        // <summary>
        /// overloading UpdateValue, Refrigerated Itmes value decreases twice as fast 
        /// at the end we alwasys validate the value
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

            ValueValidation();
        }
    }
}
