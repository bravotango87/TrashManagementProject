using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashManagement.Models
{
    public class DayOfWeek
    {
        public IEnumerable<Customer> Customers { get; set; }

        public string SelectDay { get; set; }
    }
}
