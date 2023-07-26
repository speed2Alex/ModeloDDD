using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.Log.Events
{
    public interface IHandler<in T> where T : Message
    {
        void Handle(T message);
    }
}
