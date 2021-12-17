using CoffeeMachineAssessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTest.CoffeeMachine
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void When_BeansAreLessThan5_AND_MilkIsLessThan3_Expect_FindBeansAndMilkStockAsFalse_ForCappuccino()
        {
            // Arrange
            CoffeMachine.TotalBeans = 4;
            CoffeMachine.TotalMilk = 2;
            CoffeeBase coffee = CoffeeList.Create("1");
            //Act             
            //Assert
            Assert.IsFalse(coffee.FindBeansAndMilkStock());
        }
        [TestMethod]
        public void When_BeansAreMoreThan5_AND_MilkIsMoreThan3_Expect_FindBeansAndMilkStockAsTrue_ForCappuccino()
        {
            // Arrange
            CoffeMachine.TotalBeans = 6;
            CoffeMachine.TotalMilk = 4;
            CoffeeBase coffee = CoffeeList.Create("1");
            //Act             
            //Assert
            Assert.IsTrue(coffee.FindBeansAndMilkStock());
        }
        [TestMethod]
        public void When_BeansAreLessThan3_AND_MilkIsLessThan2_Expect_FindBeansAndMilkStockAsFalse_ForLatte()
        {
            // Arrange
            CoffeMachine.TotalBeans = 2;
            CoffeMachine.TotalMilk = 1;
            CoffeeBase coffee = CoffeeList.Create("2");
            //Act             
            //Assert
            Assert.IsFalse(coffee.FindBeansAndMilkStock());
        }
        [TestMethod]
        public void When_BeansAreMoreThan3_AND_MilkIsMoreThan2_Expect_FindBeansAndMilkStockAsTrue_ForLatte()
        {
            // Arrange
            CoffeMachine.TotalBeans = 4;
            CoffeMachine.TotalMilk = 3;
            CoffeeBase coffee = CoffeeList.Create("2");
            //Act             
            //Assert
            Assert.IsTrue(coffee.FindBeansAndMilkStock());
        }
        [TestMethod]
        public void When_BeansAreLessThan2_AND_MilkIsLessThan1_Expect_FindBeansAndMilkStockAsFalse_ForCoffee()
        {
            // Arrange
            CoffeMachine.TotalBeans = 1;
            CoffeMachine.TotalMilk = 0;
            CoffeeBase coffee = CoffeeList.Create("3");
            //Act             
            //Assert
            Assert.IsFalse(coffee.FindBeansAndMilkStock());
        }
        [TestMethod]
        public void When_BeansAreMoreThan2_AND_MilkIsMoreThan1_Expect_FindBeansAndMilkStockAsTrue_ForCoffee()
        {
            // Arrange
            CoffeMachine.TotalBeans = 3;
            CoffeMachine.TotalMilk = 2;
            CoffeeBase coffee = CoffeeList.Create("3");
            //Act             
            //Assert
            Assert.IsTrue(coffee.FindBeansAndMilkStock());
        }
        [TestMethod]
        public void Find_MilkAndBeansRequired_To_PrepareCoffee_Cappuccino()
        {
            // Arrange
            CoffeMachine.TotalBeans = 25;
            CoffeMachine.TotalMilk = 20;
            CoffeeBase coffee = CoffeeList.Create("1");
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader("5"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
                    //Act
                    coffee.PrepareCoffee();

                    //Assert - Check the amount of milk & beans consume
                    Assert.AreEqual(25 - coffee.Beans, CoffeMachine.TotalBeans);
                    Assert.AreEqual(20 - coffee.Milk, CoffeMachine.TotalMilk);
                }
            }
        }
        [TestMethod]
        public void Find_MilkAndBeansRequired_To_PrepareCoffee_Latte()
        {
            // Arrange
            CoffeMachine.TotalBeans = 25;
            CoffeMachine.TotalMilk = 20;
            CoffeeBase coffee = CoffeeList.Create("2");
            //Act
            coffee.PrepareCoffee();
            //Assert - Check the amount of milk & beans consume
            Assert.AreEqual(25 - coffee.Beans, CoffeMachine.TotalBeans);
            Assert.AreEqual(20 - coffee.Milk, CoffeMachine.TotalMilk);
        }

        [TestMethod]
        public void Find_MilkAndBeansRequired_To_Prepare_Coffe_WithMilk()
        {
            // Arrange
            CoffeMachine.TotalBeans = 25;
            CoffeMachine.TotalMilk = 20;
            CoffeeBase coffee = CoffeeList.Create("3");
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader("Y"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
                    //Act
                    coffee.PrepareCoffee();
                    //Assert - Check the amount of milk & beans consume
                    Assert.AreEqual(25 - coffee.Beans, CoffeMachine.TotalBeans);
                    Assert.AreEqual(20 - coffee.Milk, CoffeMachine.TotalMilk);
                }
            }
        }

        [TestMethod]
        public void Find_BeansRequired_To_PrepareDrink_Coffe_WithOutMilk()
        {
            // Arrange
            CoffeMachine.TotalBeans = 25;
            CoffeMachine.TotalMilk = 20;
            CoffeeBase coffee = CoffeeList.Create("3");
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader("N"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
                    //Act
                    coffee.PrepareCoffee();
                    //Assert - Check the amount of milk & beans consume
                    Assert.AreEqual(25 - coffee.Beans, CoffeMachine.TotalBeans);
                    Assert.AreEqual(20, CoffeMachine.TotalMilk);
                }
            }
        }
    }
}
