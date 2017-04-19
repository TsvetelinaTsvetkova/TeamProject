namespace ContactsCatalog.Data.ContactsCatalogStore
{
    using ContactsCatalog.Models;
    using System.Collections.Generic;
    using System.Linq;

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

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public Contact AddNewContact()
        {
            var newContact = new Contact
            {
                Name = "New Contact"
            };
            this.context.Contacts.Add(newContact);
            return (newContact);
        }
    }
}
