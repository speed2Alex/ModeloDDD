using BaseDDD.Domain.Events.Classificacao;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.EventHandlers
{
    public class ClassificacaoEventHandler :
        INotificationHandler<ClassificacaoRegisteredEvent>,
        INotificationHandler<ClassificacaoUpdatedEvent>,
        INotificationHandler<ClassificacaoRemovedEvent>
    {
        public Task Handle(ClassificacaoRegisteredEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ClassificacaoUpdatedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ClassificacaoRemovedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
