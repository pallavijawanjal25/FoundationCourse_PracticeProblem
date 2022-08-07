using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number For Multiplication");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Aaddition a = new Aaddition();
            a.AdditionOfTwoNumber();
            Console.WriteLine("Enter");
            Substraction s = new Substraction();
            s.SubstractionOfTwoNumber();


           
        }
    }
}
 