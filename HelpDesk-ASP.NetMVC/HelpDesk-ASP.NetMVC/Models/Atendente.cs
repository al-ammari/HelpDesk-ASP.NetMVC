namespace HelpDesk_ASP.NetMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Atendente")]
    public partial class Atendente
    {
        [Key]
        public int CodAtendente { get; set; }
        public string Nome { get; set; }
        public int CodDepta { get; set; }
        public virtual Departamento Departamento { get; set; }
    }
}
