namespace HelpDesk_ASP.NetMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HelpDesk : DbContext
    {
        public HelpDesk()
            : base("name=HelpDesk")
        {
        }

        public virtual DbSet<Atendente> Atendente { get; set; }
        public virtual DbSet<Avaliacao> Avaliacao { get; set; }
        public virtual DbSet<Contato> Contato { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Interacao> Interacao { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Suporte> Suporte { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atendente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Avaliacao>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .HasMany(e => e.Suporte)
                .WithRequired(e => e.Contato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Departamento>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Departamento>()
                .HasMany(e => e.Atendente)
                .WithRequired(e => e.Departamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Departamento>()
                .HasMany(e => e.Suporte)
                .WithRequired(e => e.Departamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Interacao>()
                .Property(e => e.Mensagem)
                .IsUnicode(false);

            modelBuilder.Entity<Interacao>()
                .Property(e => e.ObsOculta)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Suporte)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Suporte>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Suporte>()
                .HasMany(e => e.Avaliacao)
                .WithRequired(e => e.Suporte)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Suporte>()
                .HasMany(e => e.Interacao)
                .WithRequired(e => e.Suporte)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tipo>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo>()
                .HasMany(e => e.Suporte)
                .WithRequired(e => e.Tipo)
                .WillCascadeOnDelete(false);
        }
    }
}
