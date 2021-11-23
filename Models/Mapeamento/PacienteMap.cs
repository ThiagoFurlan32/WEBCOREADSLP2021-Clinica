using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCORELP2021.Models.Dominio;

namespace WEBCORELP2021.Models.Mapeamento
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.nome).HasMaxLength(45).IsRequired();
            builder.Property(p => p.cidade).HasMaxLength(25).IsRequired();
            builder.Property(p => p.endereco).HasMaxLength(25).IsRequired();
            builder.Property(p => p.idade).IsRequired();
            builder.Property(p => p.email).HasMaxLength(50).IsRequired();
            builder.Property(p => p.numero).HasMaxLength(11).IsRequired();
            builder.Property(p => p.cpf).HasMaxLength(14).IsRequired();
            builder.HasIndex(p => p.cpf).IsUnique();

            builder.HasMany(p => p.planoDeSaude).WithOne(p => p.paciente).HasForeignKey(p => p.pacienteID).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(p => p.consultas).WithOne(p => p.paciente).HasForeignKey(p => p.pacienteID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
