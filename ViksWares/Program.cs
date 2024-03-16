using System;
using System.Collections.Generic;
using ViksWares.Models;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to  Viks Wares!");

            // Display options to the user
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Run Shop");
            Console.WriteLine("2. Run Test");
            Console.Write("Enter your choice (1 or 2): ");

            // Read user input
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int choice))
            {
                // Call method based on user choice
                switch (choice)
                {
                    case 1:
                        RunShop();
                        break;
                    case 2:
                       // RunTest();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1 or 2.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }



        private static void RunShop()
        {

            Console.WriteLine("Welcome To our shop!");


            // List of items in the shop
            IList<Item> Items = new List<Item>{
                new PerishableItem {Name = "Shoe Laces", SellBy = 10, Value = 20},
                new AgedParmigiano {Name = "Aged Parmigiano", SellBy = 2, Value = 0},
                new PerishableItem {Name = "Book of Resolutions", SellBy = 5, Value = 7},
                new SaffronPowder {Name = "Saffron Powder", SellBy = 0, Value = 80},
                new SaffronPowder {Name = "Saffron Powder", SellBy = -1, Value = 80},
                new ConcertTicket
                {
                    Name = "Concert tickets to Talkins Festival",
                    SellBy = 15,
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
                new Refrigerated {Name = "Refrigerated milk", SellBy = 3, Value = 6}
            };
            // Create a new instance of ViksWares with the list of items
            var app = new ViksWares(Items);


            // Loop for 30 days to simulate item value updates
            for (var i = 0; i < 31; i++)
            {

                // Display day number
                Console.WriteLine("-------- day " + i + " --------");

                // Display header for item attributes
                Console.WriteLine("name, sellIn, quality");

                // Display attributes of each item
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }

                Console.WriteLine("");
                // Update the value of items for the next day
                app.UpdateValue();
            }


        }
    }
}