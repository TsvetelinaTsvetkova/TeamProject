using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsCatalog.Data
{
    using Models;

   public class ContactsCatalogDbInitializer:DropCreateDatabaseAlways<ContactsCatalogContext>
    {
        protected override void Seed(ContactsCatalogContext context)
        {
            var first = new Contact
            {
                Name = "Ivan",
                Address = "Iv",
                ContactInformation = "Ivv"
            };
            context.Contacts.Add(first);
            context.SaveChanges();
        }
    }
}
