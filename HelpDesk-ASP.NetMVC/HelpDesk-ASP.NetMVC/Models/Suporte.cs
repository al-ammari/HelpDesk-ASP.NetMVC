namespace HelpDesk_ASP.NetMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Suporte")]
    public partial class Suporte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Suporte()
        {
            Avaliacao = new HashSet<Avaliacao>();
            Interacao = new HashSet<Interacao>();
        }

        [Key]
        public int CodSuporte { get; set; }

        public string Titulo { get; set; }

        public DateTime Data { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataLimite { get; set; }

        public int CodContato { get; set; }

        public int CodTipo { get; set; }

        public int CodStatus { get; set; }

        public int CodDepta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avaliacao> Avaliacao { get; set; }

        public virtual Contato Contato { get; set; }

        public virtual Departamento Departamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interacao> Interacao { get; set; }

        public virtual Status Status { get; set; }

        public virtual Tipo Tipo { get; set; }
    }
}
