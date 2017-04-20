using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsCatalog.Models
{
    public class Contact
    {
        public int Id { get; set; }


        [MinLength(1)]
        public string Name { get; set; }

        public string Address { get; set; }

        public string ContactInformation { get; set; }

        public string ProfilePicturePath { get; set; }
    }
}
