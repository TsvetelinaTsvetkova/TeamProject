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
                Address = "Vasil Levski 10",
                ContactInformation = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                                     "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                                     "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                                     "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"
            };
            context.Contacts.Add(first);
            context.SaveChanges();
        }
    }
}
