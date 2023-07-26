using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.Interfaces.Generico
{
    public interface IGenerico<T> where T : class 
    {
        Task Register(T objeto);
        Task Update(T objeto);
        Task Remove(T objeto);
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        
    }
}
