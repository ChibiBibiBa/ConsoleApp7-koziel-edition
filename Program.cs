using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Calculator();

            Console.WriteLine(c.Add(1,2));
            Console.WriteLine(c.Mult(2, 4));
        }
    }
}
