using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RegexPattern
{
    internal class StringValidation
    {
        public string Name = ("^[a]{1}[b]{2,3}$");

        public string  LowerCase = ("[a-z]+_[a-z]$");

        public string Image = "^([a-z0-9]+)(\\.png)$";

        public void ValidateEnterString(string EnterName)
        {
            if (Regex.IsMatch(EnterName, Name))
                Console.WriteLine("String is Invalid");
            else
                Console.WriteLine("String is Valid :" + EnterName);
        }

        public void ValidateLowerString(string Lower)
        {
            if (Regex.IsMatch(Lower, LowerCase))
                Console.WriteLine("String is Invalid");
            else
                Console.WriteLine("String is Valid :" + Lower);
        }

        public void CheckHtmlTags()
        {
            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>”";
            string pattern = @"<[^>]+>";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        public void ImageType(string image)
        {
            if (Regex.IsMatch(image, Image))
                Console.WriteLine("Valid Image extension");
            else
                Console.WriteLine("Invalid Image extension :" + image);
        }
    }
}
