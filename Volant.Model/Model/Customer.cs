using System;
using System.Collections.Generic;

namespace Volant.Model
{
    public partial class Customer
    {
        public int customerId { get; set; }
        public string name { get; set; }
        public DateTime? dateCreated { get; set; }
        public DateTime? dateUpdated { get; set; }
        public int customerStatusId { get; set; }
        public virtual List<Project> projects { get; set; }
    }
}