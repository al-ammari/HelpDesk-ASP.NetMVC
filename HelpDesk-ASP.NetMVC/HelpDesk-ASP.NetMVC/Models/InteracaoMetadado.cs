using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_ASP.NetMVC.Models
{
    [MetadataType(typeof(InteracaoMetadado))]
    partial class Interacao
    {
    }

    class InteracaoMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar uma mensagem!")]
        public string Mensagem { get; set; }

         [Required(ErrorMessage = "O campo Data não pode ser NULL!")]
        public DateTime Data { get; set; }

        [StringLength(255, ErrorMessage = "A Observação Oculta deve possuir no máximo 255 caracteres!")]
        public string ObsOculta { get; set; }

        [Required]
        public int CodSuporte { get; set; }
    }
}
