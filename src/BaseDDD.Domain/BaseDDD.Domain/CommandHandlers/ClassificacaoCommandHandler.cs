using BaseDDD.Domain.CommandHandlers.Generico;
using BaseDDD.Domain.Commands.Classificacao;
using BaseDDD.Domain.Events.Classificacao;
using BaseDDD.Domain.Interfaces;
using BaseDDD.Domain.Interfaces.Generico;
using BaseDDD.Domain.Log.Bus;
using BaseDDD.Domain.Log.Events;
using BaseDDD.Domain.Log.Notifications;
using BaseDDD.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.CommandHandlers
{
    public class ClassificacaoCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewClassificacaoCommand, bool>,
        IRequestHandler<UpdateClassificacaoCommand, bool>,
        IRequestHandler<RemoveClassificacaoCommand, bool>
    {
        private readonly IClassificacaoRepository _classificacaoRepository;
        private readonly IMediatorHandler Bus;

        public ClassificacaoCommandHandler(IClassificacaoRepository classificacaoRepository,
                                     IUnitOfWork uow,
                                     IMediatorHandler bus,
                                     INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
            _classificacaoRepository = classificacaoRepository;
            Bus = bus;
        }
        public Task<bool> Handle(RegisterNewClassificacaoCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Task.FromResult(false);
            }
            var classificacao = new TblClassificacao(request.Codigo, request.Nome, request.IdadeMaxima, request.Descricao);
            _classificacaoRepository.Add(classificacao);

            if (Commit())
            {
                Bus.RaiseEvent(new ClassificacaoRegisteredEvent(request.Codigo, request.Nome, request.IdadeMaxima, request.Descricao));
            }

            return Task.FromResult(true);
        }

        public Task<bool> Handle(UpdateClassificacaoCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Task.FromResult(false);
            }

            var classificacao = new TblClassificacao(request.Codigo, request.Nome, request.IdadeMaxima, request.Descricao);
            var existingClassificacao = _classificacaoRepository.GetByNome(classificacao.Nome);

            if (existingClassificacao != null && existingClassificacao.Result.Codigo != request.Codigo)
            {
                if (!existingClassificacao.Equals(classificacao))
                {
                    Bus.RaiseEvent(new DomainNotification(request.MessageType, "Não existe está descrição de classificaçãp."));
                    return Task.FromResult(false);
                }
            }

            _classificacaoRepository.Update(classificacao);

            if (Commit())
            {
                Bus.RaiseEvent(new ClassificacaoUpdatedEvent(classificacao.Codigo, classificacao.Nome, classificacao.IdadeMaxima, classificacao.Descricao));
            }

            return Task.FromResult(true);
        }

        public Task<bool> Handle(RemoveClassificacaoCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Task.FromResult(false);
            }

            _classificacaoRepository.Remove(request.Codigo);

            if (Commit())
            {
                Bus.RaiseEvent(new ClassificacaoRemovedEvent(request.Codigo));
            }

            return Task.FromResult(true);
        }
    }
}
