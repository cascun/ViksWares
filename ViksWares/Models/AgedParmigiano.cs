using csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViksWares.Models
{
    /// <summary>
    /// Class impliments PerishableItem
    /// </summary>
    public class AgedParmigiano : PerishableItem
    {
        public AgedParmigiano() { 
        }
        /// <summary>
        /// overloading UpdateValue, Value increases by 1 each day for Aged Parmigiano
        /// at the end we alwasys validate the value
        /// </summary>
        public override void UpdateValue()
        {
            Value = Value + 1;

            ValueValidation();
        }
    }
}
