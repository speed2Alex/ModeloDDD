using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.Interfaces.Generico
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
