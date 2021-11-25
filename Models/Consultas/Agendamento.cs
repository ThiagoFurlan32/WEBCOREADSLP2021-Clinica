using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCORELP2021.Models.Consultas
{
    public class Agendamento
    {
        [DisplayName("Médico")]
        public string nomeMedico { get; set; } // Medico

        [DisplayName("Paciente")]
        public string nomePaciente { get; set; } // Paciente

        [DisplayName("Convênio")]
        public string nomePlano { get; set; } // Plano

        [DisplayName("Horário")]
        public string descricaoConsulta { get; set; } // Horário

    }
}
