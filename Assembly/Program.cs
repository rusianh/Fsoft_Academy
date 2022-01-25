using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Console.WriteLine("hello assembly");
            Console.WriteLine(obj.HelloFromUniverse());
            Console.ReadKey();
        }
    }
}
