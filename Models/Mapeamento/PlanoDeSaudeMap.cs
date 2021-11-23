using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCORELP2021.Models.Dominio;

namespace WEBCORELP2021.Models.Mapeamento
{
    public class PlanoDeSaudeMap : IEntityTypeConfiguration<PlanoDeSaude>
    {
        public void Configure(EntityTypeBuilder<PlanoDeSaude> builder) { 

            builder.HasMany(p => p.paciente).WithOne(p => p.planoDeSaude).HasForeignKey(p => p.planoDeSaudeID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
