using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Application.ViewModel
{
    public class TblSexoViewModel
    {
        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string? Descricao { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Criacao { get; set; }

        [InverseProperty("CodigoSexoNavigation")]
        public virtual ICollection<TblUsuarioViewModel> tblUsuarios { get; set; } = new List<TblUsuarioViewModel>();
    }
}
