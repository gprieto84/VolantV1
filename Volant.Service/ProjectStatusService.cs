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
    public interface IProjectStatusService
    {
        IEnumerable<ProjectStatus> GetAll();
    }

    public class ProjectStatusService : IProjectStatusService
    {
        private readonly IProjectStatusRepository projectStatusRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProjectStatusService(IProjectStatusRepository projectStatusRepository, IUnitOfWork unitOfWork)
        {
            this.projectStatusRepository = projectStatusRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IProjectService Members

        public IEnumerable<ProjectStatus> GetAll()
        {
            var project = projectStatusRepository.GetAll();
            return project;
        }
        

        public void SaveProject()
        {
            unitOfWork.Commit();
        }
        
        #endregion

    }
}
