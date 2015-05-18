using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_ASP.NetMVC.Models
{
    class Contato
    {
        public int CodContato { get; set; }
        [Required(ErrorMessage = "Preencha o nome do contato")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o e-mail do contato")]
        public string Email { get; set; }

    }
}
