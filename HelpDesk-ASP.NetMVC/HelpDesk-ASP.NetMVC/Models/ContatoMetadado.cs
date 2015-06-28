using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_ASP.NetMVC.Models
{
    [MetadataType( typeof(ContatoMetadado))]
   public partial class Contato
    {
    }

    public class ContatoMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar o Nome!")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o E-mail!")]
        [StringLength(60, ErrorMessage = "O E-mail deve possuir no máximo 60 caracteres!")]
        public string Email { get; set; }
    }
}
