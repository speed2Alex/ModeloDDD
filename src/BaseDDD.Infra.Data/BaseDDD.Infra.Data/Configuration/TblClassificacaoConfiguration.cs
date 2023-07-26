using BaseDDD.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Infra.Data.Configuration
{
    public class TblClassificacaoConfiguration : IEntityTypeConfiguration<TblClassificacao>
    {
        public void Configure(EntityTypeBuilder<TblClassificacao> builder)
        {

            builder.ToTable("tblClassificacao");
            builder.HasKey(e => e.Codigo)
                .HasName("PK_tblClassificacao");

            builder.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("Nome");

            builder.Property(e => e.IdadeMaxima)
                .HasMaxLength(20)
                .HasColumnName("IdadeMaxima");

            builder.Property(e => e.Descricao)
                .HasColumnType("varchar(MAX)")
                .HasColumnName("Descricao");

            builder.Property(e => e.Criacao)
                .HasDefaultValueSql("(getdate())");

        }
    }
}
