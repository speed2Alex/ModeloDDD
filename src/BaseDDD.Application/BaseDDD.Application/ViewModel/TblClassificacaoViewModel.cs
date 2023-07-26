using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BaseDDD.Application.ViewModel
{
    public class TblClassificacaoViewModel
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string? Nome { get; set; }

        [StringLength(20)]
        [Unicode(false)]
        public string? IdadeMaxima { get; set; }

        [Unicode(false)]
        public string? Descricao { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Criacao { get; set; }

        [InverseProperty("CodigoClassificacaoNavigation")]
        public virtual ICollection<TblStreamingViewModel> tblStreamingsViewModel { get; set; } = new List<TblStreamingViewModel>();
    }
}
