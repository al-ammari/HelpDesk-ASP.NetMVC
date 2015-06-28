using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_ASP.NetMVC.Models
{
    [MetadataType(typeof(DepartamentoMetadado))]
    partial class Departamento
    {
    }

    class DepartamentoMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar o Nome do Departamento!")]
        [StringLength(50, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres!")]
        public string Nome { get; set; }
    }
}
