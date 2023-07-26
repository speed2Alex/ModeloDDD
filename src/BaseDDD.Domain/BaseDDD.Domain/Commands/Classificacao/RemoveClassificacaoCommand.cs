using BaseDDD.Domain.Validations.Classificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.Commands.Classificacao
{
    public class RemoveClassificacaoCommand : ClassificacaoCommand
    {
        public RemoveClassificacaoCommand(int codigo)
        {
            Codigo = codigo;
            AggregateId = codigo.ToString();
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveClassificacaoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
