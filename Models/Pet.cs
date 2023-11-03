using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pets.Models
{
    public class Pet
    {
        [Key]
        public int IdPet { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public bool HasFur { get; set; }

    }
}