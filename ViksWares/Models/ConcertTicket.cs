using csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViksWares.Models
{
    /// <summary>
    /// This class represents Concert Tickets, which are a type of perishable item.
    /// </summary>
    public class ConcertTicket : PerishableItem
    {
        public ConcertTicket() {
            // Constructor implementation
        }

        /// <summary>
        /// This method overrides the UpdateValue method of the base class.
        /// It updates the value of the concert tickets based on how far away the concert is.
        /// - If the sell-by date is more than 10 days away, the value increases by 1 each day.
        /// - If the sell-by date is between 6 and 10 days away, the value increases by 2 each day.
        /// - If the sell-by date is between 1 and 5 days away, the value increases by 3 each day.
        /// - If the sell-by date is 0 or less, the value is set to 0.
        /// After updating the value, the ValueValidation method is called to ensure
        /// that the value stays within the acceptable range (0 to 50).
        /// </summary>
        public override void UpdateValue()
        {
            if(SellBy  > 10)
            {
                Value = Value +1;
            }else if( SellBy > 5)
            {
                Value = Value +2;
            }
            else if (SellBy > 0) 
            {
                Value = Value + 3;
            }
            else 
            {
                Value = 0;
            }
            // Validate the value to ensure it stays within the acceptable range
            ValueValidation();
        }
    }
}
