using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_ASP.NetMVC.Models
{
    [MetadataType(typeof(TipoMetadado))]
    public partial class Tipo
    {
    }

    public class TipoMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar o Tipo!")]
        [StringLength(50, ErrorMessage = "A descrição deve possuir no máximo 50 caracteres!")]
        public string Descricao { get; set; }
    }
}
