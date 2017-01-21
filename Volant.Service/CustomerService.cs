using Volant.Data.Infrastructure;
using Volant.Data.Repositories;
using Volant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volant.Service
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers(string name = null);
        Customer GetCustomer(int id);
        Customer GetCustomer(string name);
        void CreateCustomer(Customer customer);
        void SaveCustomer();
    }

    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public CustomerService(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        #region ICustomerService Members

        public IEnumerable<Customer> GetCustomers(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return customerRepository.GetAll();
            else
                return customerRepository.GetAll().Where(c => c.name == name);
        }

        public Customer GetCustomer(int id)
        {
            var customer = customerRepository.GetById(id);
            return customer;
        }

        public Customer GetCustomer(string name)
        {
            var customer = customerRepository.GetCustomerByName(name);
            return customer;
        }

        public void CreateCustomer(Customer customer)
        {
            customerRepository.Add(customer);
        }

        public void SaveCustomer()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
