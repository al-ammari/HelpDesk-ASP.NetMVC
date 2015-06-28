namespace HelpDesk_ASP.NetMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Avaliacao")]
    public partial class Avaliacao
    {
        [Key]
        public int CodAvaliacao { get; set; }

        public int Nota { get; set; }

        [Column(TypeName = "text")]
        public string Comentario { get; set; }

        public int CodSuporte { get; set; }

        public virtual Suporte Suporte { get; set; }
    }
}
