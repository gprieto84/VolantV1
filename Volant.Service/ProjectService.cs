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
    public interface IProjectService
    {
        IEnumerable<Project> GetProjects();
        IEnumerable<Project> GetCustomerProjects(string customerName, string projectName = null);
        Project GetProject(int id);
        void CreateProject(Project project);
        void SaveProject();
        IEnumerable<Customer> GetAllCustomerByStatus(CustomerStatusId customerId);
    }

    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository projectRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProjectService(IProjectRepository projectRepository, ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            this.projectRepository = projectRepository;
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IProjectService Members

        public IEnumerable<Project> GetProjects()
        {
            var project = projectRepository.GetAll();
            return project;
        }

        public IEnumerable<Project> GetCustomerProjects(string customerName, string projectName = null)
        {
            var customer = customerRepository.GetCustomerByName(customerName);
            return customer.projects.Where(g => g.name.ToLower().Contains(customerName.ToLower().Trim()));
        }

        public Project GetProject(int id)
        {
            var project = projectRepository.GetById(id);
            return project;
        }

        public void CreateProject(Project project)
        {
            projectRepository.Add(project);
        }

        public void SaveProject()
        {
            unitOfWork.Commit();
        }

        public IEnumerable<Customer> GetAllCustomerByStatus(CustomerStatusId customerId)
        {
            return customerRepository.GetAllCustomerByStatus((int) customerId);
        }

        #endregion

    }
}
