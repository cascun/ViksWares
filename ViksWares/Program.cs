using System;
using System.Collections.Generic;
using ViksWares.Models;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To our shop!");

            IList<Item> Items = new List<Item>{
                new PerishableItem {Name = "Shoe Laces", SellBy = 10, Value = 20},
                new AgedParmigiano {Name = "Aged Parmigiano", SellBy = 2, Value = 0},
                new PerishableItem {Name = "Book of Resolutions", SellBy = 5, Value = 7},
                new SaffronPowder {Name = "Saffron Powder", SellBy = 0, Value = 80},
                new SaffronPowder {Name = "Saffron Powder", SellBy = -1, Value = 80},
                new ConcertTicket
                {
                    Name = "Concert tickets to Talkins Festival",
                    SellBy = 50,
                    Value = 20
                },
                new ConcertTicket
                {
                    Name = "Concert tickets to Talkins Festival",
                    SellBy = 10,
                    Value = 49
                },
                new ConcertTicket
                {
                    Name = "Concert tickets to Talkins Festival",
                    SellBy = 5,
                    Value = 49
                },
                // this Refrigerated item does not work properly yet
                new Refrigerated {Name = "Refrigerated milk", SellBy = 3, Value = 6}
            };

            var app = new ViksWares(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                app.UpdateValue();
            }

            Console.ReadKey();
        }
    }
}