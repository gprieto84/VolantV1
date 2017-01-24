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
    public interface IJobService
    {
        IEnumerable<Job> GetJobs();
        IEnumerable<Job> GetJobsByProject(int? projectId);
        Job GetJob(int id);
        void CreateJob(Job project);
        void SaveJob();
    }

    public class JobService : IJobService
    {
        private readonly IJobRepository jobRepository;
        private readonly IProjectRepository projectRepository;
        private readonly IUnitOfWork unitOfWork;

        public JobService(IJobRepository jobRepository, IProjectRepository projectRepository, IUnitOfWork unitOfWork)
        {
            this.jobRepository = jobRepository;
            this.projectRepository = projectRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IJobService Members

        public IEnumerable<Job> GetJobs()
        {
            var job = jobRepository.GetAll();
            return job;
        }

        public IEnumerable<Job> GetJobsByProject(int? projectId)
        {
            var jobs = jobRepository.GetJobsByProject(projectId);
            return jobs;
        }

        public Job GetJob(int id)
        {
            var job = jobRepository.GetById(id);
            return job;
        }

        public void CreateJob(Job job)
        {
            jobRepository.Add(job);
        }

        public void SaveJob()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}
