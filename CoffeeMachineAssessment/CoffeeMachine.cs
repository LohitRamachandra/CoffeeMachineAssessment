using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineAssessment
{
    public class CoffeMachine
    {
        public static int TotalBeans;
        public static int TotalMilk;

        public CoffeeBase TypeOfCofee;

        static CoffeMachine()
        {
            CoffeMachine.TotalBeans = 25;
            CoffeMachine.TotalMilk = 20;
        }

        public static void FindBeansStock()
        {
            if (CoffeMachine.TotalBeans <= 5)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Warning : Low bean capacity !!!");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
    }
}
