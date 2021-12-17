using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = string.Empty;

            CoffeMachine machine = new CoffeMachine();
            Console.WriteLine("......Welcome to my Coffee Shop......");
            Console.WriteLine("\n");
            Console.WriteLine("......How are you doing?......");
            Console.WriteLine("\n");
            Console.WriteLine("====================================================");
            Console.WriteLine("Total Beans : " + CoffeMachine.TotalBeans + " Total Milk : " + CoffeMachine.TotalMilk);
            Console.WriteLine("====================================================");
            Console.WriteLine("\n");
            Console.WriteLine("Please select the Coffee you like to have ...");
            Console.WriteLine("Enter 1 for Cappuccino...");
            Console.WriteLine("Enter 2 for Latte...");
            Console.WriteLine("Enter 3 for Coffee....");
            Console.WriteLine("Enter off to stop");
            Console.WriteLine("====================================================");
            Console.WriteLine("\n");
            do
            {
                choice = Console.ReadLine();
                if (!string.IsNullOrEmpty(choice) && choice.ToUpper() != "OFF")
                {
                    machine.TypeOfCofee = CoffeeList.Create(choice);
                    if (machine.TypeOfCofee != null)
                    {
                        if (machine.TypeOfCofee.FindBeansAndMilkStock())
                        {
                            machine.TypeOfCofee.PrepareCoffee();
                            CoffeMachine.FindBeansStock();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice, please enter the valid value");
                    }
                }
            } while (choice.ToUpper() != "OFF");
        }
    }
}
