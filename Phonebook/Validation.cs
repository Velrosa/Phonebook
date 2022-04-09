using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class Validation
    {
        public static string IsStringValid(string inputString)
        {
            while (true)
            {
                bool isValid = true;

                if (inputString == "MENU")
                {
                    return inputString;
                }

                if (String.IsNullOrEmpty(inputString))
                {
                    Console.WriteLine(" Null or Empty string is invalid.");
                    isValid = false;
                }
                foreach (char c in inputString)
                {
                    if (!Char.IsLetter(c) && c != ' ' && c != '/' && c != '?')
                    {
                        Console.WriteLine($" \"{c}\" is not a valid character.");
                        isValid = false;
                    }
                }

                if (!isValid)
                {
                    Console.Write(" Invalid entry, Please enter again: ");
                    inputString = Console.ReadLine();
                }
                else { break; }
            }
            return inputString;
        }

        public static string IsPhoneNumberValid(string inputString)
        {
            while (true)
            {
                bool isValid = true;

                if (inputString == "MENU")
                {
                    return inputString;
                }

                if (String.IsNullOrEmpty(inputString))
                {
                    Console.WriteLine(" Null or Empty string is invalid.");
                    isValid = false;
                }
                foreach (char c in inputString)
                {
                    if (!Char.IsDigit(c))
                    {
                        Console.WriteLine($" \"{c}\" is not a valid number.");
                        isValid = false;
                    }
                }
                if (inputString.Length > 11)
                {
                    Console.WriteLine(" Phonenumber is too long.");
                    isValid = false;
                }

                if (!isValid)
                {
                    Console.Write(" Invalid Phonenumber, Please enter again: ");
                    inputString = Console.ReadLine();
                }
                else { break; }
            }
            return inputString;
        }
    }
}
