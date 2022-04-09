using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class UserInput
    {
        public static void AddContactInput()
        {
            Contact contact = new Contact();

            Console.WriteLine("Adding a Contact... \n Type MENU to return.");
            
            Console.Write("\n Please enter the name of the Contact: ");
            contact.Name = Validation.IsStringValid(Console.ReadLine());
            if (contact.Name == "MENU") { return; }

            Console.Write("\n Please enter the phone number of the Contact: ");
            contact.Phonenumber = Validation.IsNumberValid(Console.ReadLine());
            if (contact.Phonenumber == "MENU") { return; }

            ContactsController.InsertContact(contact);
            
            Console.WriteLine($"\n Contact: {contact.Name}, {contact.Phonenumber}. has sucessfully been added.\n Press any key to return to MENU...");
            Console.ReadKey();
        }
    }
}
