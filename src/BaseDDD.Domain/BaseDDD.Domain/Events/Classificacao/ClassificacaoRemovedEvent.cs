using BaseDDD.Domain.Log.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.Events.Classificacao
{
    public class ClassificacaoRemovedEvent : Event
    {
        public ClassificacaoRemovedEvent(int codigo)
        {
            Codigo = Codigo;
            AggregateId = Codigo.ToString();
        }
        public int Codigo { get; set; }
    }
}
