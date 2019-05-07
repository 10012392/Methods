//Lara Corkery 08/05/2019
//Exercise Three 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Radius Of The Circle: ");
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine("The Circumference Of The Circle With A Radius Of " + input + " Is " + Math.Round(Circumference(input)));
            Console.WriteLine("The Area of A Circle With A Radius Of " + input + " Is " + Math.Round(Area(input)));
            Console.ReadLine();
        }

        static double Circumference(double rad)
        {
            return rad * 2 * Math.PI;
        }

        static double Area(double rad)
        {
            return (rad * rad) * Math.PI;
        }
    }
}
