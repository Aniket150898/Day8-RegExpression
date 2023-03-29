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


            ////UC2
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter The string: ");
            string lower = Console.ReadLine();
            stringValidation.ValidateLowerString(lower);


            //UC3
            Console.WriteLine("-----------------------------------");
            stringValidation.CheckHtmlTags();
            

            //UC5
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter image extension: ");
            string img = Console.ReadLine();
            stringValidation.ImageType(img);

            //UC6
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter Proper Website: ");
            string web = Console.ReadLine();
            stringValidation.WebsiteType(web);
            Console.ReadLine();

        }
    }
}
