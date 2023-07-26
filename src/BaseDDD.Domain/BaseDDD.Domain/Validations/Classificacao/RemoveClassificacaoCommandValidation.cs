using BaseDDD.Domain.Commands.Classificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Domain.Validations.Classificacao
{
    public class RemoveClassificacaoCommandValidation : ClassificacaoValidation<RemoveClassificacaoCommand>
    {
        public RemoveClassificacaoCommandValidation()
        {
                
        }
    }
}
