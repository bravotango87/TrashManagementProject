using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashManagement.Models
{
    public class PickupDay
    {
        [Key]

        public int Id { get; set; }

        public string Day { get; set; }

        public bool IsPickedUp { get; set; }
    }
}
