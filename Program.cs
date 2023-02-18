using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a numbers: ");
           
            double i = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input a numbers: ");

            double j = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input a numbers: ");

            double k = Convert.ToDouble(Console.ReadLine());

            double result = (i + j + k) / 3;

            Console.WriteLine("Your average is: " + result);

            Console.ReadLine();
        }
    }
}
