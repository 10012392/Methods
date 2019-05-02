//Lara Corkery 02/05/2019
//Completing Method Exercise 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise Two 
            Console.WriteLine("This Application Will Convert Miles into Kilometers:");
            Console.WriteLine("Enter The Amount Of Miles:");
            int miles1 = int.Parse(Console.ReadLine());
            double total = Conversion(miles1);

            Console.WriteLine("The Amount In Miles Is: " + miles1);
            Console.WriteLine("The Result In Kilometers Is: " + total);
            Console.ReadLine();
           
        }
        static double Conversion(int miles1)
        {
            return miles1 * 1.609 ;
        }





    
    }
}
