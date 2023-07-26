using BaseDDD.Domain.Log.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.Events.Classificacao
{
    public class ClassificacaoUpdatedEvent: Event
    {
        public ClassificacaoUpdatedEvent(int codigo, string? nome, string? idadeMaxima, string? descricao)
        {
            Codigo = codigo;
            Nome = nome;
            IdadeMaxima = idadeMaxima;
            Descricao = descricao;
        }
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? IdadeMaxima { get; set; }
        public string? Descricao { get; set; }
    }
}
