using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_ASP.NetMVC.Models
{
    class Departamento
    {
        public int CodDepta { get; set; }

        [Required(ErrorMessage = "Preencha o nome do Departamento.")]
        public string Depta { get; set; }
    }
}
