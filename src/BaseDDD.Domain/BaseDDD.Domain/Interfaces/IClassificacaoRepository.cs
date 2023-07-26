using BaseDDD.Domain.Interfaces.Generico;
using BaseDDD.Domain.Log.Models;
using BaseDDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.Interfaces
{
    public interface IClassificacaoRepository : IRepositoryAsync<TblClassificacao>
    {
        Task<TblClassificacao> GetByNome(string? nome);
    }
}
