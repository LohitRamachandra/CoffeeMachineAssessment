using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineAssessment
{
    public static class CoffeeList
    {
        static Dictionary<string, CoffeeBase> dictionaryObj = null;
        static CoffeeList()
        {
            if (dictionaryObj == null)
            {
                dictionaryObj = new Dictionary<string, CoffeeBase>();
                dictionaryObj.Add("1", new Cappuccino());
                dictionaryObj.Add("2", new Latte());
                dictionaryObj.Add("3", new Coffee());
            }
        }
        public static CoffeeBase Create(string choice)
        {
            return choice != string.Empty && dictionaryObj.ContainsKey(choice) ? dictionaryObj[choice] : null;
        }
    }
}
