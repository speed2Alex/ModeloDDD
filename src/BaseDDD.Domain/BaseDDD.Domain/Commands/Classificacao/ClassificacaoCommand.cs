using BaseDDD.Domain.Log.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.Commands.Classificacao
{
    public abstract class ClassificacaoCommand : Command
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? IdadeMaxima { get; set; }
        public string? Descricao { get; set; }
    }
}
