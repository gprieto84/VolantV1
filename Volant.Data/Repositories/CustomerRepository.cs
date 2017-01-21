using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volant.Data.Infrastructure;
using Volant.Model;

namespace Volant.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Customer GetCustomerByName(string customerName)
        {
            var category = this.DbContext.Customers.Where(c => c.name == customerName).FirstOrDefault();

            return category;
        }

        public override void Update(Customer entity)
        {
            entity.dateUpdated = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetCustomerByName(string customerName);
    }
}
