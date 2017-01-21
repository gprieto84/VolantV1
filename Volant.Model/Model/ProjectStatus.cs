using System.Collections.Generic;

namespace Volant.Model
{
    public class ProjectStatus
    {
        public int projectStatusId { get; set; }

        public string name { get; set; }

        public virtual List<Project> projects { get; set; }
    }
}