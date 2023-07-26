using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace BaseDDD.Domain.Log.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }
        public string? AggregateId { get; protected set; }
        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
