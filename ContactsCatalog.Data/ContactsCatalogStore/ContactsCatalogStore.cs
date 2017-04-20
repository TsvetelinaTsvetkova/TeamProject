using ContactsCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ContactsCatalog.Data.ContactsCatalogStore
{
    
   public class ContactsCatalogStore
    {
        private ContactsCatalogContext context = new ContactsCatalogContext();

        public void Initialize()
        {
            context.Database.Initialize(true);
        }

        public List<Contact> GetAllContacts()
        {
            return this.context.Contacts.ToList();
        }

        public List<Contact> GetContactsBySearchPattern(string searchPattern)
        {
            if (string.IsNullOrEmpty(searchPattern))
            {
                return this.GetAllContacts();
            }

            return this.context.Contacts.Where(x=>x.Name.ToLower().Contains(searchPattern.ToLower())).ToList();
        }

        public void RemoveContact(Contact contact)
        {
            if (contact == null) return;

            if (contact.Id == 0) return;

            this.context.Contacts.Remove(contact);

            this.context.SaveChanges();
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public Contact AddNewContact()
        {
            var newContact = new Contact
            {
              Name =  "New Contact"
            };            
            this.context.Contacts.Add(newContact);
            return (newContact);
        }
    }
}
