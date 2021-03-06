﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volant.Data.Infrastructure;
using Volant.Model;

namespace Volant.Data.Repositories
{
    public class JobTypeRepository : RepositoryBase<JobType>, IJobTypeRepository
    {
        public JobTypeRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IJobTypeRepository : IRepository<JobType>
    {

    }
}
