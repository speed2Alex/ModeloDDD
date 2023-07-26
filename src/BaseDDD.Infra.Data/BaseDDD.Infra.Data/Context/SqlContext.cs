using BaseDDD.Domain.Models;
using BaseDDD.Infra.Data.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Infra.Data.Context
{
    public class SqlContext : DbContext
    {
        private readonly IHostingEnvironment _env;
        public readonly IHttpContextAccessor _httpContext;

        public SqlContext(IHostingEnvironment env, IHttpContextAccessor httpContextAccessor)
        {
            _env = env;
            _httpContext = httpContextAccessor;
        }

        public virtual DbSet<TblClassificacao> tblClassificacoes { get; set; }
        
        public virtual DbSet<TblGenero> tblGeneros { get; set; }

        public virtual DbSet<TblSexo> tblSexos { get; set; }

        public virtual DbSet<TblStreaming> tblStreamings { get; set; }

        public virtual DbSet<TblTipoStreaming> tblTipoStreamings { get; set; }

        public virtual DbSet<TblUsuario> tblUsuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TblClassificacaoConfiguration());
            modelBuilder.ApplyConfiguration(new TblGeneroConfiguration());
            modelBuilder.ApplyConfiguration(new TblSexoConfiguration());
            modelBuilder.ApplyConfiguration(new TblStreamingConfiguration());
            modelBuilder.ApplyConfiguration(new TblTipoStreamingConfiguration());
            modelBuilder.ApplyConfiguration(new TblUsuarioConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
