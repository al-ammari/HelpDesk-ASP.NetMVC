using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_ASP.NetMVC.Models
{
    class SuporteTipo
    {
        public int CodTipo { get; set; }
        [Required(ErrorMessage = "Preencha o nome do Tipo de suporte.")]
        public string Tipo { get; set; }
    }
}
