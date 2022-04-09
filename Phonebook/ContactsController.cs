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
        internal void ViewAllContacts()
        {
            using (var context = new ContactContext())
            {
                var results = context.Contacts.ToList();
                TableVisuals.DisplayTable(results);
            }
        }
        internal void InsertContact(Contact contact)
        {
            using (var context = new ContactContext())
            {
                context.Contacts.Add(contact);
                context.SaveChanges();
            }
        }

        internal void UpdateContact(Contact contact, int inputId)
        {
            using (var context = new ContactContext())
            {
                var result = context.Contacts.Find(inputId);
                result.Name = contact.Name;
                result.Phonenumber = contact.Phonenumber;
                context.SaveChanges();
            }
        }

        internal void DeleteContact(int inputId)
        {
            using (var context = new ContactContext())
            {
                var result = context.Contacts.Find(inputId);
                context.Contacts.Remove(result);
                context.SaveChanges();
            }
        }
    }
}
