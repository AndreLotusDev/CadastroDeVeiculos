using CadastroDeVeiculo.Data.Mapeamentos;
using CadastroDeVeiculo.Dominio.Modelos;
using CadastroDeVeiculo.Dominio.Modelos.Enums;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CadastroDeVeiculo.Data.Contexto
{
    public class Banco : DbContext
    {
        public Banco()
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<EStatus>();
        }

        public Banco(DbContextOptions<Banco> options) : base(options)
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<EStatus>();

            Database.Migrate();
        }

        public DbSet<Proprietario> Proprietarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum<EStatus>();

            modelBuilder.ApplyConfiguration(new Mapeamentos.Mapeamentos());
        }
    }
}
