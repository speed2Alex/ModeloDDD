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
    public class TblGeneroViewModel
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string? Descricao { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Criacao { get; set; }

        [InverseProperty("CodigoGeneroNavigation")]
        public virtual ICollection<TblStreamingViewModel> tblStreamings { get; set; } = new List<TblStreamingViewModel>();

        [InverseProperty("CodigoGeneroNavigation")]
        public virtual ICollection<TblUsuarioViewModel> tblUsuarios { get; set; } = new List<TblUsuarioViewModel>();
    }
}
