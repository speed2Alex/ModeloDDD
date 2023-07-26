using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaseDDD.Infra.CrossCutting.IoC.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Contrato não informado")]
        [MinLength(2)]
        [MaxLength(20)]
        public string Contrato { get; set; }

        [Required(ErrorMessage = "Usuário não informado")]
        [MinLength(2)]
        [MaxLength(20)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Senha não informada")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Lembrar senha?")]
        public bool RememberMe { get; set; }
    }
}
