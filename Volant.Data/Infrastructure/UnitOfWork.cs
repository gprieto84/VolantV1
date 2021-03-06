﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volant.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private VolantEntities dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public VolantEntities DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public DbRawSqlQuery<T> SQLQuery<T>(string sql, params object[] parameters)
        {
            return dbContext.Database.SqlQuery<T>(sql, parameters);
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
