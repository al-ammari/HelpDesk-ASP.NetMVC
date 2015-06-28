namespace HelpDesk_ASP.NetMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Interacao")]
    public partial class Interacao
    {
        [Key]
        public int CodInteracao { get; set; }
        public string Mensagem { get; set; }
        public DateTime Data { get; set; }
        public string ObsOculta { get; set; }
        public int CodSuporte { get; set; }
        public virtual Suporte Suporte { get; set; }
    }
}
