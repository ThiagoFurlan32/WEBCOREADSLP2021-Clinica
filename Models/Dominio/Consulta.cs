﻿using System;
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

        [DisplayName("Horário")]
        [StringLength(45, ErrorMessage ="Tamanho inválido.")]
        public string descricao { get; set; }

        [DisplayName("Médico")]
        public Medico medico { get; set; }

        [DisplayName("Médico")]
        public int medicoID { get; set; }

        [DisplayName("Paciente")]
        public Paciente paciente { get; set; }

        [DisplayName("Paciente")]
        public int pacienteID { get; set; }
    }
}
