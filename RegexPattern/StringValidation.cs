using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    internal class StringValidation
    {
        public string Name = ("^[a]{1}[b]{2,3}$");
        public void ValidateEnterString(string EnterName)
        {
            if (Regex.IsMatch(EnterName, Name))
                Console.WriteLine("String is Invalid");
            else
                Console.WriteLine("String is Valid :" + EnterName);
        }
    }
}
