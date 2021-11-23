using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCORELP2021.Models.Dominio
{
    [Table("Consulta")]
    public class Consulta
    {
        [Key]
        [DisplayName("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [DisplayName("Descrição")]
        [StringLength(45, ErrorMessage ="Tamanho inválido.")]
        public string descricao { get; set; }

        public Medico medico { get; set; }
        public int medicoID { get; set; }
        public Paciente paciente { get; set; }
        public int pacienteID { get; set; }
    }
}
