//Lara Corkery 02/05/2019
//Completing Method Exercise 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One 
            Console.WriteLine("This Application Will Do Something ");
            Console.WriteLine("Please Enter A Number: ");
            int num1 = int.Parse(Console.ReadLine());
            int total = ReturnNumbers(num1);

            Console.WriteLine(total);
            Console.ReadLine();
        }
            static int ReturnNumbers(int num1)
            {
                return num1 - num1 * 2;
            }



           
     
    }
}
