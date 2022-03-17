using CadastroDeVeiculo.Dominio.Modelos;
using CadastroDeVeiculo.Dominio.Modelos.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeVeiculo.Data.Mapeamentos
{
    public class Mapeamentos : IEntityTypeConfiguration<Proprietario>
    {
        public void Configure(EntityTypeBuilder<Proprietario> builder)
        {
            builder.ToTable("proprietarios");

            builder.Property(p => p.Nome)
                .IsRequired(true)
                .HasMaxLength(200)
                .HasColumnName("nome")
                .HasComment("Indica informações sobre o nome de nascimento da pessoa");

            builder.Property(p => p.Status)
                .IsRequired(true)
                .HasDefaultValue(EStatus.ATIVO)
                .HasColumnName("status")
                .HasComment("Indica se essa classe esta ativa ou nao");

            builder.Property(p => p.Documento)
                .IsRequired(false)
                .HasMaxLength(100)
                .HasColumnName("documento")
                .HasComment("Indica infomrações de registro da pessoa dono do carro");

            builder.Property(p => p.Email)
                .IsRequired(true)
                .HasColumnName("email")
                .HasMaxLength(300)
                .HasComment("Email para mandar informações para o proprietario");

            builder.Property(p => p.Endereco)
                .IsRequired(false)
                .HasColumnName("endereco")
                .HasComment("Indica onde o proprietario mora");

            
        }
    }
}
