using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_ASP.NetMVC.Models
{
    [MetadataType(typeof(AvaliacaoMetadado))]
   public partial class Avaliacao
    {
    }
    class AvaliacaoMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar o valor da Nota!")]
        public int Nota { get; set; }

        [Required]
        public int CodSuporte { get; set; }
    }
}
