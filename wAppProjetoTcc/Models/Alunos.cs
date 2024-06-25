using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace wAppProjetoTcc.Models
{
    public partial class Alunos : DbContext
    {
        public Alunos()
            : base("Alunos") //("name=Alunos")
        {
        }

        public virtual DbSet<Aluno> Aluno { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Aluno>()
                .Property(e => e.Rm)
                .IsUnicode(false);

            modelBuilder.Entity<Aluno>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Aluno>()
                .Property(e => e.Senha)
                .IsUnicode(false);
        }
    }
}
