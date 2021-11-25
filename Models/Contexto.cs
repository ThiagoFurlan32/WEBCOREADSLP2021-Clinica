using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCORELP2021.Models.Dominio;
using WEBCORELP2021.Models.Consultas;

namespace WEBCORELP2021.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<PlanoDeSaude> PlanosDeSaude { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<WEBCORELP2021.Models.Consultas.PivotPlanodeSaude> PivotPlanodeSaude { get; set; }
    }
}
