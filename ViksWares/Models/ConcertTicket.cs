using csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViksWares.Models
{
    public class ConcertTicket : PerishableItem
    {
        public ConcertTicket() { }

        /// <summary>
        /// Update the Value of the Concert Tickets dipending on how far away the concert is.
        /// at the end we alwasys validate the value
        /// </summary>
        public override void UpdateValue()
        {
            if(SellBy  > 10) //when sell by (consert day) is more 10 days away increas value by 1 each day
            {
                Value = Value +1;
            }else if( SellBy > 5) //when sell by (consert day) is less or equal to  10 days away but more then 5  increas value by 2 each day
            {
                Value = Value +2;
            }
            else if (SellBy > 0) //when sell by (consert day) is less or equal to 5 days away but more then 0  increas value by 3 each day
            {
                Value = Value + 3;
            }
            else // else this means that Sell by is 0 or less Value will go down to 0 
            {
                Value = 0;
            }

            ValueValidation();
        }
    }
}
