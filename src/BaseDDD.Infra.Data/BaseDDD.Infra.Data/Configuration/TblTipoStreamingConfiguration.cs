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
    public class TblTipoStreamingConfiguration : IEntityTypeConfiguration<TblTipoStreaming>
    {
        public void Configure(EntityTypeBuilder<TblTipoStreaming> builder)
        {
            builder.ToTable("tblTipoStreaming");
            builder.HasKey(e => e.Codigo)
                .HasName("PK_tblTipoStreaming");

            builder.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("Descricao");

            builder.Property(e => e.Criacao)
                .HasDefaultValueSql("(getdate())");
        }
    }
}
