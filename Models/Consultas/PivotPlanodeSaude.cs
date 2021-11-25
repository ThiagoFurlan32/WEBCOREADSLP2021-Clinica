using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCORELP2021.Models.Consultas
{
    public class PivotPlanodeSaude
    {

        public int ID { get; set; }

        [DisplayName("Paciente")]
        public string paciente { get; set; }
        public string UNIMED { get; set; }
        public string SULAMERICA { get; set; }
        public string CASSI { get; set; }
        public string FUNCEF { get; set; }
        public string NENHUM { get; set; }
    }
}
