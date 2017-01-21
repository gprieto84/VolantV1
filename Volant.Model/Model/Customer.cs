using System.Collections.Generic;

namespace Volant.Model
{
    public class Customer
    {
        public int customerId { get; set; }
        public string name { get; set; }

        public virtual List<Project> projects { get; set; }
    }
}