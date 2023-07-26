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
    public class TblUsuarioViewModel
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string? Nome { get; set; }

        public int? Idade { get; set; }

        [StringLength(100)]
        [Unicode(false)]
        public string? Email { get; set; }
        public int? CodigoSexo { get; set; }

        public int? CodigoGenero { get; set; }

        [StringLength(30)]
        [Unicode(false)]
        public string? Senha { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Criacao { get; set; }

        [ForeignKey("CodigoGenero")]
        [InverseProperty("tblUsuarios")]
        public virtual TblGeneroViewModel? CodigoGeneroNavigation { get; set; }

        [ForeignKey("CodigoSexo")]
        [InverseProperty("tblUsuarios")]
        public virtual TblSexoViewModel? CodigoSexoNavigation { get; set; }
    }
}
