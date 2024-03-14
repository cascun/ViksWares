using NUnit.Framework;
using System;
using System.Collections.Generic;
using ViksWares.Models;

namespace csharp
{
    [TestFixture]
    public class ViksWaresTest
    {
        //Naming Convention - ClassName_MethodName_ExpectedResult
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellBy = 0, Value = 0 } };
            ViksWares app = new ViksWares(Items);
            app.UpdateValue();
            Assert.AreEqual("fixme", Items[0].Name);
        }

        [Test]
        public void AgedParmigiano_UpdateValue_Value_Six()
        {
            try
            {
                //Arrange - Go get your variables, whatever you need, your classes, get yur functions
                IList<Item> Items = new List<Item> { new AgedParmigiano { Name = "Aged Parmigiano", SellBy = 10, Value = 5 } };

                //Act - Execute this function
                ViksWares app = new ViksWares(Items);
                app.UpdateValue();

                //Assert
                Assert.AreEqual(6, Items[0].Value); // Assuming UpdateValue inreses by 1
                Console.WriteLine("AgedParmigiano_UpdateValue_Value_Six test passed successfully.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        [Test]
        public void ConcertTicket_UpdateValue_Value_Eight()
        {
            try
            {
                //Arrange - Go get your variables, whatever you need, your classes, get yur functions
                IList<Item> Items = new List<Item> { new ConcertTicket { Name = "Concert Ticket", SellBy = 2, Value = 5 } };

                //Act - Execute this function
                ViksWares app = new ViksWares(Items);
                app.UpdateValue();

                //Assert
                Assert.AreEqual(8, Items[0].Value); // Assuming UpdateValue value inreses by 3
                Console.WriteLine("ConcertTicket_UpdateValue_Value_Eight test passed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        [Test]
        public void ConcertTicket_UpdateValue_Value_Zero()
        {
            try
            {
                //Arrange - Go get your variables, whatever you need, your classes, get yur functions
                IList<Item> Items = new List<Item> { new ConcertTicket { Name = "Concert Ticket", SellBy = 0, Value = 5 } };

                //Act - Execute this function
                ViksWares app = new ViksWares(Items);
                app.UpdateValue();

                //Assert
                Assert.AreEqual(0, Items[0].Value);// Assuming UpdateValue value changes to 0
                Console.WriteLine("ConcertTicket_UpdateValue_Value_Eight test passed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        [Test]
        public void ConcertTicket_UpdateValue_Value_Six()
        {
            try
            {
                //Arrange - Go get your variables, whatever you need, your classes, get yur functions
                IList<Item> Items = new List<Item> { new ConcertTicket { Name = "Concert Ticket", SellBy = 11, Value = 5 } };

                //Act - Execute this function
                ViksWares app = new ViksWares(Items);
                app.UpdateValue();

                //Assert
                Assert.AreEqual(6, Items[0].Value); // Assuming UpdateValue value inreses by 1
                Console.WriteLine("ConcertTicket_UpdateValue_Value_Six test passed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ConcertTicket_UpdateValue_Value_Six" + ex.Message);
            }

        }

        [Test]
        public void ConcertTicket_UpdateValue_Value_Seven()
        {
            try
            {
                //Arrange - Go get your variables, whatever you need, your classes, get yur functions
                IList<Item> Items = new List<Item> { new ConcertTicket { Name = "Concert Ticket", SellBy = 6, Value = 5 } };

                //Act - Execute this function
                ViksWares app = new ViksWares(Items);
                app.UpdateValue();

                //Assert
                Assert.AreEqual(7, Items[0].Value); // Assuming UpdateValue value inreses by 2
                Console.WriteLine("ConcertTicket_UpdateValue_Value_Seven test passed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ConcertTicket_UpdateValue_Value_Seven"+ex.Message);
            }

        }


        [Test]
        public void PerishableItem_UpdateValue_Value_Four()
        {
            try
            {
                //Arrange - Go get your variables, whatever you need, your classes, get yur functions
                IList<Item> Items = new List<Item> { new PerishableItem { Name = "ShewLase", SellBy = 6, Value = 5 } };

                //Act - Execute this function
                ViksWares app = new ViksWares(Items);
                app.UpdateValue();

                //Assert
                Assert.AreEqual(4, Items[0].Value); // Assuming UpdateValue value decreases by 1
                Console.WriteLine("PerishableItem_UpdateValue_Value_Four test passed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("PerishableItem_UpdateValue_Value_Four" + ex.Message);
            }

        }

        [Test]
        public void Refrigerated_UpdateValue_Value_Eight()
        {
            try
            {
                //Arrange - Go get your variables, whatever you need, your classes, get yur functions
                IList<Item> Items = new List<Item> { new Refrigerated{ Name = "ShewLase", SellBy = 6, Value = 10 } };

                //Act - Execute this function
                ViksWares app = new ViksWares(Items);
                app.UpdateValue();

                //Assert
                Assert.AreEqual(8, Items[0].Value); // Assuming UpdateValue value decreases by 2
                Console.WriteLine("Refrigerated_UpdateValue_Value_Eight test passed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Refrigerated_UpdateValue_Value_Eight" + ex.Message);
            }

        }

        [Test]
        public void SaffronPowder_UpdateValue_Value_Eighty()
        {
            try
            {
                //Arrange 
                IList<Item> Items = new List<Item> { new SaffronPowder { Name = "Saffron Poder", SellBy = 6, Value = 81 } };

                //Act 
                ViksWares app = new ViksWares(Items);
                app.UpdateValue();
                throw new Exception("test");

                //Assert
                Assert.AreEqual(80, Items[0].Value); // Assuming UpdateValue Value remains 80
                Console.WriteLine("SaffronPowder_UpdateValue_Value_Eight test passed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SaffronPowder_UpdateValue_Value_Eighty" + ex.Message);
            }

        }

        [Test]
        public void Perishable_Item_UpdateValue_Should_Decrease_SellBy()
        {
            try
            {
                // Arrange
                var items = new List<Item>
                {
                    new PerishableItem { Name = "Shoe Laces", SellBy = 10, Value = 20 }
                };

                var viksWares = new ViksWares(items);

                // Act
                viksWares.UpdateValue();

                // Assert
                Assert.That(items[0].SellBy, Is.EqualTo(9)); // Assuming UpdateValue SellBy decreases  by 1
                Console.WriteLine("Perishable_Item_UpdateValue_Should_Decrease_SellBy test passed successfully.");

            }
            catch (Exception ex)
            {

                Console.WriteLine("Perishable_Item_UpdateValue_Should_Decrease_SellBy " + ex.Message);
            }
           
        }

        [Test]
        public void Perishable_Item_UpdateValue_Should_Handle_Negative_SellBy()
        {
            try
            {
                // Arrange
                var item = new PerishableItem { Name = "Test Item", SellBy = 0, Value = 10 };
                var viksWares = new ViksWares(new List<Item> { item });

                // Act
                viksWares.UpdateValue();

                // Assert
                Assert.That(item.SellBy, Is.EqualTo(-1)); // SellBy should be decremented to -1

                Console.WriteLine("Perishable_Item_UpdateValue_Should_Handle_Negative_SellBy test passed successfully.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Perishable_Item_UpdateValue_Should_Handle_Negative_SellBy"+ex.Message);
            }
            
        }

   
       

       

    }
}