using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!!,Performing Regual Expression in C#");

            StringValidation stringValidation = new StringValidation();

            //UC1
            Console.WriteLine("Enter The string: ");
            string firstName = Console.ReadLine();
            stringValidation.ValidateEnterString(firstName);
            

            //UC2
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The string: ");
            string lower = Console.ReadLine();
            stringValidation.ValidateEnterString(lower);
            Console.ReadLine();
        }
    }
}
