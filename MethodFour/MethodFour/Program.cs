//Lara Corkery 08/05/2019
//Exercise Four 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter A Number From 1 - 7: ");
            Console.WriteLine("\nThat Number Corresponds To: " + Day(int.Parse(Console.ReadLine())));
            Console.ReadLine();
        }

        static string Day(int num)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            return days[num - 1];
        }
    }
}
