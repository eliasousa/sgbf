﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGBF.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Arbitro> Arbitro { get; set; }
        public virtual DbSet<Campeonato> Campeonato { get; set; }
        public virtual DbSet<Equipe> Equipe { get; set; }
        public virtual DbSet<Equipe_Campeonato> Equipe_Campeonato { get; set; }
        public virtual DbSet<Escalacao> Escalacao { get; set; }
        public virtual DbSet<Estadio> Estadio { get; set; }
        public virtual DbSet<Jogador> Jogador { get; set; }
        public virtual DbSet<Jogo> Jogo { get; set; }
        public virtual DbSet<Treinador> Treinador { get; set; }
    }
}
