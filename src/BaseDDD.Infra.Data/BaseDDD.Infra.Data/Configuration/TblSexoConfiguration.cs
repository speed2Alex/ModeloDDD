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
    public class TblSexoConfiguration : IEntityTypeConfiguration<TblSexo>
    {
        public void Configure(EntityTypeBuilder<TblSexo> builder)
        {
            builder.ToTable("tblSexo");
            builder.HasKey(e => e.Codigo)
                .HasName("PK_tblSexo");

            builder.Property(e => e.Descricao)
                .HasMaxLength(20)
                .HasColumnName("Descricao");

            builder.Property(e => e.Criacao)
                .HasDefaultValueSql("(getdate())");
        }
    }
}
