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
    public class TblGeneroConfiguration : IEntityTypeConfiguration<TblGenero>
    {
        public void Configure(EntityTypeBuilder<TblGenero> builder)
        {
            builder.ToTable("tblGenero");
            builder.HasKey(e => e.Codigo)
                .HasName("PK_tblGenero");

            builder.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("Descricao");

            builder.Property(e => e.Criacao)
                .HasDefaultValueSql("(getdate())");
        }
    }
}
