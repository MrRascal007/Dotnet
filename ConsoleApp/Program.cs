using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add(5, 10);
            //int c = 0;
            //c = Add(5, 10);
            Console.WriteLine("enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = Add(a, b);

            Console.WriteLine("the sum of  a & b  {0} ", Convert.ToString(c));
            Console.ReadLine();
        }
        public static int Add(int a,int b)
        {
            //Console.WriteLine("enter value for a ", a);
            //Console.ReadLine();
            //Console.WriteLine("enter value for b ", b);
            //Console.ReadLine();
            //Console.WriteLine("The result is ", a+b);
            //Console.ReadLine();
            return a + b;
        }
    }
}
