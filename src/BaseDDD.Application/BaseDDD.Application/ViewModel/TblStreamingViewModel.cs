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
    public class TblStreamingViewModel
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string? Nome { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Lancamento { get; set; }

        public int? Nota { get; set; }

        [Unicode(false)]
        public string? Descricao { get; set; }

        public int? CodigoClassificacao { get; set; }

        public int? CodigoGenero { get; set; }

        public int? CodigoTipoStreaming { get; set; }

        public byte[]? Imagem { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Criacao { get; set; }

        [ForeignKey("CodigoClassificacao")]
        [InverseProperty("tblStreamings")]
        public virtual TblClassificacaoViewModel? CodigoClassificacaoNavigation { get; set; }

        [ForeignKey("CodigoGenero")]
        [InverseProperty("tblStreamings")]
        public virtual TblGeneroViewModel? CodigoGeneroNavigation { get; set; }

        [ForeignKey("CodigoTipoStreaming")]
        [InverseProperty("tblStreamings")]
        public virtual TblTipoStreamingViewModel? CodigoTipoStreamingNavigation { get; set; }
    }
}
