using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phonebook.Data.Models
{
    public class Contact
    {
        //Using Required because we don`t want to have contacts without name or number
        [Required] 
        public string Name { get; set; }

        [Required]
        public string Number { get; set; }
    }
}
