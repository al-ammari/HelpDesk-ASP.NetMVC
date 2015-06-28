using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_ASP.NetMVC.Models
{
    [MetadataType(typeof(SuporteMetadado))]
    partial class MyClass
    {
    }

    class SuporteMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar um Titulo!")]
        [StringLength(150, ErrorMessage = "O Titulo deve possuir no máximo 150 caracteres!")]
        public string Titulo { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public DateTime DataLimite { get; set; }

        [Required]
        public int CodContato { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Tipo de suporte!")]
        public int CodTipo { get; set; }

        [Required]
        public int CodStatus { get; set; }

         [Required(ErrorMessage = "Obrigatório informar o Departamento!")]
        public int CodDepta { get; set; }
    }
}
