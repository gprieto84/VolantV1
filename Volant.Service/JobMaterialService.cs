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
    public interface IJobMaterialService
    {

        IEnumerable<JobMaterial> GetJobMaterialsByJob(int? jobId);
        void SaveJob();

    }

    public class JobMaterialService : IJobMaterialService
    {
        private readonly IJobMaterialRepository jobMaterialRepository;
        private readonly IUnitOfWork unitOfWork;

        public JobMaterialService(IJobMaterialRepository jobMaterialRepository, IUnitOfWork unitOfWork)
        {
            this.jobMaterialRepository = jobMaterialRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IJobService Members



        public IEnumerable<JobMaterial> GetJobMaterialsByJob(int? id)
        {
            var jobMaterials = jobMaterialRepository.GetJobMaterialsByJob(id);
            return jobMaterials;
        }


        public void SaveJob()
        {
            unitOfWork.Commit();
        }

        #endregion

    }
}
