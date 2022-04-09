using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class UserInput
    {
        private ContactsController controller = new ContactsController();
        internal void DisplayTableInput()
        {
            controller.ViewAllContacts();
        }
        
        internal void AddContactInput()
        {
            Contact contact = new Contact();

            Console.WriteLine("\n Adding a Contact... \n Type MENU to return.");
            
            Console.Write("\n Please enter the name of the Contact: ");
            contact.Name = Validation.IsStringValid(Console.ReadLine());
            if (contact.Name == "MENU") { return; }

            Console.Write("\n Please enter the phone number of the Contact: ");
            contact.Phonenumber = Validation.IsPhoneNumberValid(Console.ReadLine());
            if (contact.Phonenumber == "MENU") { return; }

            controller.InsertContact(contact);
            
            Console.WriteLine($"\n Contact: {contact.Name}, {contact.Phonenumber}. has sucessfully been added.\n Press any key to return to MENU...");
            Console.ReadKey();
        }

        internal void UpdateContactInput()
        {
            Contact contact = new Contact();

            Console.WriteLine("\n Updating a Contact... \n Type MENU to return.");

            controller.ViewAllContacts();

            Console.Write("\n Please enter an ID for the Contact you which to update: ");
            string inputId = Validation.IsPhoneNumberValid(Console.ReadLine());
            if (inputId == "MENU") { return; }
            
            Console.Write("\n Please enter the new name for the Contact: ");
            contact.Name = Validation.IsStringValid(Console.ReadLine());
            if (contact.Name == "MENU") { return; }

            Console.Write("\n Please enter the new phone number for the Contact: ");
            contact.Phonenumber = Validation.IsPhoneNumberValid(Console.ReadLine());
            if (contact.Phonenumber == "MENU") { return; }

            controller.UpdateContact(contact, int.Parse(inputId));

            Console.WriteLine($"\n Contact: {contact.Name}, {contact.Phonenumber}. has sucessfully been updated.\n Press any key to return to MENU...");
            Console.ReadKey();
        }

        internal void DeleteContactInput()
        {
            Console.WriteLine("\n Deleting a Contact... \n Type MENU to return.");

            controller.ViewAllContacts();

            Console.Write("\n Please enter an ID for the Contact you which to Delete: ");
            string inputId = Validation.IsPhoneNumberValid(Console.ReadLine());
            if (inputId == "MENU") { return; }

            Console.Write($"\n Are you sure you wish to delete record number: {inputId} (y or n)? ");
            string delete = Console.ReadLine();
            if (delete != "y") { return; }

            controller.DeleteContact(int.Parse(inputId));

            Console.WriteLine($"\n Contact ID: {inputId}. has sucessfully been deleted.\n Press any key to return to MENU...");
            Console.ReadKey();
        }
    }
}
