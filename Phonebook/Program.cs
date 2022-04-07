using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;

namespace Phonebook
{
    internal class Program
    {
        string dbString = ConfigurationManager.AppSettings.Get("dbString");
        static void Main(string[] args)
        {
            using (var context = new ContactContext())
            {
                var con = new Contact()
                {
                    Id = 1,
                    Name = "Bill",
                    Phonenumber = "03030300000"                    
                };
            }
        }

        public class ContactContext : DbContext
        {
            public DbSet<Contact> Contacts { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(LocalDb)\LocalDBFlashcards;Database=ContactsDB;Integrated Security=True");
            }
        }
    }
}
