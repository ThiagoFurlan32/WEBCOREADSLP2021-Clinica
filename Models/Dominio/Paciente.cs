using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCORELP2021.Models.Dominio
{
    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        [DisplayName("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [DisplayName("Paciente")]
        [StringLength(45, ErrorMessage ="Tamanho inválido.", MinimumLength = 5)]
        [Required(ErrorMessage ="Campo Obrigatório!")]
        public string nome { get; set; }

        [DisplayName("Cidade")]
        [StringLength(25, ErrorMessage ="Tamanho inválido.")]
        [Required(ErrorMessage ="Campo Obrigatório!")]
        public string cidade { get; set; }

        [DisplayName("Endereco")]
        [StringLength(25, ErrorMessage ="Tamanho inválido.")]
        [Required(ErrorMessage ="Campo Obrigatório!")]
        public string endereco { get; set; }

        [DisplayName("Idade")]
        [Required(ErrorMessage ="Campo Obrigatório!")]
        public int idade { get; set; }

        [DisplayName("Email")]
        [StringLength(50, ErrorMessage ="Tamanho inválido.")]
        //[DataType(DataType.EmailAddress, ErrorMessage ="E-mail inválido.")]
        [RegularExpression("^[a-zA-Z0-9+-]+[a-zA-Z0-9.+-][a-zA-Z0-9+-]+@[a-zA-Z0-9+-]+[a-zA-Z0-9._+-][.]{1,1}[a-zA-Z]{2,}$", ErrorMessage = "Email inválido")]
        public string email { get; set; }

        [DisplayName("Telefone")]
        [StringLength(11, ErrorMessage ="Insira apenas o DDD e o número.")]
        public string numero { get; set; }

        [DisplayName("CPF")]
        [StringLength(14)]
        public string cpf { get; set; }

        public PlanoDeSaude planoDeSaude { get; set; }
        public int planoDeSaudeID { get; set; }

        public ICollection<Consulta> consultas { get; set; }
    }
}
