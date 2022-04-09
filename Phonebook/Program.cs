using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;

namespace Phonebook
{
    internal class Program
    {
        static string dbString = ConfigurationManager.AppSettings.Get("dbString");
        static void Main(string[] args)
        {
            while (true)
            {
                MainMenu();
            }
        }

        public class ContactContext : DbContext
        {
            public DbSet<Contact> Contacts { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(dbString);
            }
        }

        public static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("\n PHONEBOOK MAIN MENU\n\n" +
                                " What would you like to do?\n\n" +
                                " Type 0 to Close Application.\n" +
                                " Type 1 to View all Contacts.\n" +
                                " Type 2 to Add a Contact.\n" +
                                " Type 3 to Update a Contact.\n" +
                                " Type 4 to Delete a Contact.\n");

            string selector = Convert.ToString(Console.ReadKey(true).KeyChar);

            switch (selector)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    ContactsController.ViewAllContacts();
                    break;
                case "2":
                    UserInput.AddContactInput();
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.Write(" Invalid Entry. press any key to return... ");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
