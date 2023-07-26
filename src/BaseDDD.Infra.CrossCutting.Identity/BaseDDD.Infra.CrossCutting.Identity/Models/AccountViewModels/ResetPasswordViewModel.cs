using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaseDDD.Infra.CrossCutting.IoC.Models.AccountViewModels
{
    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string UserId { get; set; }

        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Senha")]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação de senha")]
        [Compare("Password", ErrorMessage = "A Confirmação de senha não confere com a senha digitada.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }

        public string Contrato { get; set; }
    }
}
