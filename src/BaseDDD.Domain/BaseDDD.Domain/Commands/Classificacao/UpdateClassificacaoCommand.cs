using BaseDDD.Domain.Validations.Classificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.Commands.Classificacao
{
    public class UpdateClassificacaoCommand : ClassificacaoCommand
    {
        public UpdateClassificacaoCommand(int codigo, string? nome, string? idadeMaxima, string? descricao)
        {
            Codigo = codigo;
            Nome = nome;
            IdadeMaxima = idadeMaxima;
            Descricao = descricao;
            AggregateId = codigo.ToString();
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateClassificacaoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
