using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empJohn = new PermanentEmployee(1, "John");
            Employee empJason = new TemporaryEmployee(2, "Jason");

            Console.WriteLine($"Employee {empJohn.ToString()}, Bonus {empJohn.CalculateBonus(100000).ToString()}");
            Console.WriteLine($"Employee {empJason.ToString()}, Bonus {empJason.CalculateBonus(150000).ToString()}");
            Console.ReadLine();

        }
    }
}
