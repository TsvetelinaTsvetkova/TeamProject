namespace ContactsCatalog.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Contact
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string ContactInformation { get; set; }

        public string ProfilePicturePath { get; set; }
    }
}
