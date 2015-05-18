using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_ASP.NetMVC.Models
{
    class Atendente
    {
        public int CodAtendente { get; set; }

        [Required(ErrorMessage = "Preencha o nome do Atendente.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Apelido do Atendente.")]
        public string Apelido { get; set; }
        public bool EhAdministrador { get; set; }

        [Required(ErrorMessage = "Preencha o Peso do Atendente.")]
        public int Peso { get; set; }

    }
}
