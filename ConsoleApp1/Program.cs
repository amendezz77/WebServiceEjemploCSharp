using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.WebService;

namespace ConsoleApp1
{
    internal static class Program
    { 
       private static void Main(string[] args)
        {
            var service = new WebService1();
            Console.WriteLine("Square root of 64 ={0} ", service.SquareRoot(64));

            Console.ReadKey();
        }
     }
}
