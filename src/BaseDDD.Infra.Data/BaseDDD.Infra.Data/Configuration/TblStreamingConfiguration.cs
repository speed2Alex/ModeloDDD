using BaseDDD.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Infra.Data.Configuration
{
    public class TblStreamingConfiguration : IEntityTypeConfiguration<TblStreaming>
    {
        public void Configure(EntityTypeBuilder<TblStreaming> builder)
        {
            builder.ToTable("tblStreaming");
            builder.HasKey(e => e.Codigo)
                .HasName("PK_tblStreaming");

            builder.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("Nome");

            builder.Property(e => e.Criacao)
                .HasDefaultValueSql("(getdate())");

            builder.HasOne(d => d.CodigoClassificacaoNavigation)
                .WithMany(p => p.tblStreamings).HasConstraintName("FK_tblStreaming_tblClassificacao");

            builder.HasOne(d => d.CodigoGeneroNavigation)
                .WithMany(p => p.tblStreamings).HasConstraintName("FK_tblStreaming_tblGenero");

            builder.HasOne(d => d.CodigoTipoStreamingNavigation)
                .WithMany(p => p.tblStreamings).HasConstraintName("FK_tblStreaming_tblTipoStreaming");
        }
    }
}
