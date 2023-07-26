using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.Log.Events
{
    public abstract class StoredEvent : Event
    {
        public StoredEvent(Event theEvent, string data, string user, string sessionId, string ipSolicitacao)
        {
            Id = Guid.NewGuid();
            AggregateId = theEvent.AggregateId?.ToString();
            MessageType = theEvent.MessageType;
            Data = data;
            User = user;
            SessionId = sessionId;
            IpSolicitacao = ipSolicitacao;
        }

        // EF Constructor
        protected StoredEvent() { }

        public Guid Id { get; private set; }

        public string? Data { get; private set; }

        public string? User { get; private set; }

        public string? SessionId { get; set; }
        public string? IpSolicitacao { get; set; }
    }
}
