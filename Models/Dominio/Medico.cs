using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCORELP2021.Models.Dominio
{
    [Table("Medico")]
    public class Medico
    {
        internal object paciente;

        [Key]
        [DisplayName("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [DisplayName("Nome")]
        [StringLength(45, ErrorMessage ="Tamanho inválido.", MinimumLength = 5)]
        [Required(ErrorMessage ="Campo Obrigatório!")]
        public string nome { get; set; }

        [DisplayName("Cidade")]
        [StringLength(25, ErrorMessage ="Tamanho inválido.")]
        [Required(ErrorMessage ="Campo Obrigatório!")]
        public string cidade { get; set; }

        [DisplayName("Endereco")]
        [Required(ErrorMessage ="Campo Obrigatório!")]
        public string endereco { get; set; }

        [DisplayName("Idade")]
        [Required(ErrorMessage ="Campo Obrigatório!")]
        public int idade { get; set; }

        [DisplayName("E-mail")]
        [StringLength(50, ErrorMessage ="Tamanho inválido.")]
        [DataType(DataType.EmailAddress, ErrorMessage ="E-mail inválido.")]
        public string email { get; set; }

        [DisplayName("Telefone")]
        [StringLength(11, ErrorMessage ="Insira apenas o DDD e o número.")]
        public string numero { get; set; }

        [DisplayName("CPF")]
        [StringLength(14)]
        public string cpf { get; set; }

        public ICollection<Consulta> consultas { get; set; }
    }
}
