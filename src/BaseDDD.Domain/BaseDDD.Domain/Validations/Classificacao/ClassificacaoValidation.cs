using BaseDDD.Domain.Commands.Classificacao;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.Validations.Classificacao
{
    public abstract class ClassificacaoValidation<T> : AbstractValidator<T> where T : ClassificacaoCommand
    {
        protected void ValidateDescricao()
        {
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Por favor entre com a descrição")
                .Length(2, 150).WithMessage("A descrição dever te entre 2 a 150 caracteres");
        }
    }
}
