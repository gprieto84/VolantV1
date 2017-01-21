using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volant.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        VolantEntities dbContext;

        public VolantEntities Init()
        {
            return dbContext ?? (dbContext = new VolantEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
