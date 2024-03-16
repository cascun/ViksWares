using csharp;
using NUnit.Framework;
using System.Collections.Generic;
using ViksWares.Models;

namespace ViksWares.Test
{
    public class ViksWaresTester
    {
        csharp.ViksWares _viksWares { get; set; } = null;

        //Naming Convention - ClassName_MethodName_ExpectedResult

        [Test]
        public void AgedParmigiano_UpdateValue_Value_Six()
        {
            //Arrange - Go get your variables, whatever you need, your classes, get yur functions
            IList<Item> Items = new List<Item> { new AgedParmigiano { Name = "Aged Parmigiano", SellBy = 10, Value = 5 } };

            //Act - Execute this function
            _viksWares = new csharp.ViksWares(Items);
            _viksWares.UpdateValue();

            //Assert
            Assert.AreEqual(6, Items[0].Value); // Assuming UpdateValue inreses by 1
        }



        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void ConcertTicket_UpdateValue_Value_Eight(int sellBy)
        {
            //Arrange - Go get your variables, whatever you need, your classes, get yur functions
            IList<Item> Items = new List<Item> { new ConcertTicket { Name = "Concert Ticket", SellBy = sellBy, Value = 5 } };

            //Act - Execute this function
            _viksWares = new csharp.ViksWares(Items);
            _viksWares.UpdateValue();

            //Assert
            Assert.AreEqual(8, Items[0].Value); // Assuming UpdateValue value inreses by 3
        }

        [Test]
        public void ConcertTicket_UpdateValue_Value_Zero()
        {
            //Arrange - Go get your variables, whatever you need, your classes, get yur functions
            IList<Item> Items = new List<Item> { new ConcertTicket { Name = "Concert Ticket", SellBy = 0, Value = 5 } };

            //Act - Execute this function
            _viksWares = new csharp.ViksWares(Items);
            _viksWares.UpdateValue();

            //Assert
            Assert.AreEqual(0, Items[0].Value);// Assuming UpdateValue value changes to 0

        }

        [Test]
        public void ConcertTicket_UpdateValue_Value_Six()
        {
            //Arrange - Go get your variables, whatever you need, your classes, get yur functions
            IList<Item> Items = new List<Item> { new ConcertTicket { Name = "Concert Ticket", SellBy = 11, Value = 5 } };

            //Act - Execute this function
            _viksWares = new csharp.ViksWares(Items);
            _viksWares.UpdateValue();

            //Assert
            Assert.AreEqual(6, Items[0].Value); // Assuming UpdateValue value inreses by 1


        }

        [Test]
        public void ConcertTicket_UpdateValue_Value_Seven()
        {
            //Arrange - Go get your variables, whatever you need, your classes, get yur functions
            IList<Item> Items = new List<Item> { new ConcertTicket { Name = "Concert Ticket", SellBy = 6, Value = 5 } };

            //Act - Execute this function
            _viksWares = new csharp.ViksWares(Items);
            _viksWares.UpdateValue();

            //Assert
            Assert.AreEqual(7, Items[0].Value); // Assuming UpdateValue value inreses by 2

        }


        [Test]
        public void PerishableItem_UpdateValue_Value_Four()
        {
            //Arrange - Go get your variables, whatever you need, your classes, get yur functions
            IList<Item> Items = new List<Item> { new PerishableItem { Name = "ShewLase", SellBy = 6, Value = 5 } };

            //Act - Execute this function
            _viksWares = new csharp.ViksWares(Items);
            _viksWares.UpdateValue();

            //Assert
            Assert.AreEqual(4, Items[0].Value); // Assuming UpdateValue value decreases by 1


        }

        [Test]
        public void Refrigerated_UpdateValue_Value_Eight()
        {
            //Arrange - Go get your variables, whatever you need, your classes, get yur functions
            IList<Item> Items = new List<Item> { new Refrigerated { Name = "ShewLase", SellBy = 6, Value = 10 } };

            //Act - Execute this function
            _viksWares = new csharp.ViksWares(Items);
            _viksWares.UpdateValue();

            //Assert
            Assert.AreEqual(8, Items[0].Value); // Assuming UpdateValue value decreases by 2

        }

        [Test]
        public void SaffronPowder_UpdateValue_Value_Eighty()
        {
            //Arrange 
            IList<Item> Items = new List<Item> { new SaffronPowder { Name = "Saffron Poder", SellBy = 6, Value = 81 } };

            //Act 
            _viksWares = new csharp.ViksWares(Items);
            _viksWares.UpdateValue();

            //Assert
            Assert.AreEqual(80, Items[0].Value); // Assuming UpdateValue Value remains 80


        }

        [Test]
        public void Perishable_Item_UpdateValue_Should_Decrease_SellBy()
        {
            // Arrange
            IList<Item> Items = new List<Item>
                {
                    new PerishableItem { Name = "Shoe Laces", SellBy = 10, Value = 20 }
                };

            _viksWares = new csharp.ViksWares(Items);

            // Act
            _viksWares.UpdateValue();

            // Assert
            Assert.That(Items[0].SellBy, Is.EqualTo(9)); // Assuming UpdateValue SellBy decreases  by 1



        }

        [Test]
        public void Perishable_Item_UpdateValue_Should_Handle_Negative_SellBy()
        {
            // Arrange
            IList<Item> Items = new List<Item>{
                    new PerishableItem { Name = "Test Item", SellBy = 0, Value = 10 }
                };
            _viksWares = new csharp.ViksWares(Items);

            // Act
            _viksWares.UpdateValue();

            // Assert
            Assert.That(Items[0].SellBy, Is.EqualTo(-1)); // SellBy should be decremented to -1

        }



    }
}