using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_ASP.NetMVC.Models
{
    class SuporteStatus
    {
        public int CodStatus { get; set; }
        [Required(ErrorMessage = "Preencha o nome do Status de suporte.")]
        public string Nome { get; set; }

    }
}
