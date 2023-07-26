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
    internal class TblUsuarioConfiguration : IEntityTypeConfiguration<TblUsuario>
    {
        public void Configure(EntityTypeBuilder<TblUsuario> builder)
        {
            builder.ToTable("tblUsuario");

            builder.HasKey(e => e.Codigo)
                .HasName("PK_tblUsuario");

            builder.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("Nome");

            builder.Property(e => e.Idade)
                .HasColumnName("Idade");

            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("Email");

            builder.Property(e => e.Senha)
                .HasMaxLength(30)
                .HasColumnName("Senha");

            builder.Property(e => e.Criacao).HasDefaultValueSql("(getdate())");

            builder.HasOne(d => d.CodigoGeneroNavigation).WithMany(p => p.tblUsuarios).HasConstraintName("FK_tblUsuario_tblGenero");

            builder.HasOne(d => d.CodigoSexoNavigation).WithMany(p => p.tblUsuarios).HasConstraintName("FK_tblUsuario_tblSexo");
        }
    }
}
