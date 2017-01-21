using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volant.Model;

namespace Volant.Data
{
    public class VolantSeedData : DropCreateDatabaseIfModelChanges<VolantEntities>
    {
        protected override void Seed(VolantEntities context)
        {
            GetCustomer().ForEach(c => context.Customers.Add(c));
            GetProjectStatus().ForEach(ps => context.ProjectStatuses.Add(ps));
            GetProject().ForEach(p => context.Projects.Add(p));

            context.Commit();
        }

        private static List<Customer> GetCustomer()
        {
            return new List<Customer>
            {
                new Customer {
                    name = "ECOPETROL"
                },
                new Customer {
                    name = "TEAM FOOD"
                },
                new Customer {
                    name = "AP PLUS"
                }
            };
        }

        private static List<ProjectStatus> GetProjectStatus()
        {
            return new List<ProjectStatus>
            {
                new ProjectStatus {
                    name = "Open",
                },
                new ProjectStatus {
                    name = "In Progress"
                },
                new ProjectStatus {
                    name = "Completed"
                }
            };
        }

        private static List<Project> GetProject()
        {
            return new List<Project>
            {
                new Project {
                    name = "P17001",
                    description="Proyecto de Prueba 001",
                    customerId = 2,
                    startDate =  new DateTime(2017, 1, 1),
                    endDate=  new DateTime(2017, 2, 1),
                    progress = 0,
                    projectStatusId = 1
                },
                new Project {
                     name = "P44531",
                    description="Proyecto de Prueba 002",
                    customerId = 1,
                    startDate =  new DateTime(2017, 1, 1),
                    endDate=  new DateTime(2017, 2, 1),
                    progress = 0,
                    projectStatusId = 1
                }
            };
        }

    }
}
