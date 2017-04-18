namespace ContactsCatalog.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ContactsCatalogContext : DbContext
    {

        public ContactsCatalogContext()
            : base("name=ContactsCatalogContext")
        {
            //Database.SetInitializer(new ContactsCatalogDbInitializer());
        }

        public virtual DbSet<Contact> Contacts { get; set; }
    }
}