using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCORELP2021.Models.Consultas
{
    public class Agendamento
    {

        public string nomeMedico { get; set; } // Medico
        public string nomePaciente { get; set; } // Paciente
        public string nomePlano { get; set; } // Plano
        public string descricaoConsulta { get; set; } // PlanoDeSaude

    }
}
