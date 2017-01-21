using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Volant.Model;

namespace Volant.Web.ViewModel
{
    public class CustomerViewModel
    {
        public int customerId { get; set; }
        public string name { get; set; }

        public virtual List<Project> projects { get; set; }
    }
}