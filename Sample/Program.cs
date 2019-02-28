using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Please enter a,b Values");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Result is" + c);
            Console.ReadKey();
        }
    }
}
