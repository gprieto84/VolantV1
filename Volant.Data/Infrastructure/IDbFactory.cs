using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volant.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        VolantEntities Init();
    }
}
