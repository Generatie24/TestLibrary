using LibraryValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test i Is Integer");
            string input = Console.ReadLine();

            var result = Validator.IsInteger(input);
            Console.WriteLine(result);



        }
    }
}
