using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Phonebook.Program;

namespace Phonebook
{
    internal class ContactsController
    {
        public static void ViewAllContacts()
        {
            using (var context = new ContactContext())
            {
                var results = context.Contacts.ToList();
                TableVisuals.DisplayTable(results);
            }
        }
        public static void InsertContact(Contact contact)
        {
            using (var context = new ContactContext())
            {
                context.Contacts.Add(contact);
                context.SaveChanges();
            }
        }
    }
}
