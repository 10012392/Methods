//Lara Corkery 08/05/2019
//Task One Methods 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for height of the user 
            Console.Write("Please Enter Your Height In Meters: ");
            double h = double.Parse(Console.ReadLine());
            //Ask for the weight of the user 
            Console.Write("Please Enter Your Weight In Kg's ");
            double w = double.Parse(Console.ReadLine());

            //Result Being Displayed 
            double bmi = BMI(w, h);
            Console.WriteLine("Your BMI is: " + bmi);
        }

        static double BMI(double w, double h)
        {
            return Math.Round(w / (h * h), 1);
        }

        static void Task2(double bmi)
        {
            if (bmi >= 30)
                Console.WriteLine("You Fat Bro.... ");
            else if (bmi >= 25 && bmi < 30)
                Console.WriteLine("You Need To Loose Some Weight.....");
            else if (bmi >= 18.5 && bmi < 25) ;
            Console.WriteLine("oooosh....");
            else
                Console.WriteLine("You To Skinny ");
        }
    }
}
