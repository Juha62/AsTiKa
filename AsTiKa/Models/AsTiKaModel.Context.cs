﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsTiKa.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AsTiKaEntities : DbContext
    {
        public AsTiKaEntities()
            : base("name=AsTiKaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Asiakkaan_henkilötiedot> Asiakkaan_henkilötiedot { get; set; }
        public virtual DbSet<Asiakkaan_hoitotiedot> Asiakkaan_hoitotiedot { get; set; }
        public virtual DbSet<Asiakkaan_omaisuus> Asiakkaan_omaisuus { get; set; }
        public virtual DbSet<Asiakkaan_rahan_käyttö> Asiakkaan_rahan_käyttö { get; set; }
        public virtual DbSet<Fysioterapian_kirjaukset> Fysioterapian_kirjaukset { get; set; }
        public virtual DbSet<Hemodynamiikka> Hemodynamiikka { get; set; }
        public virtual DbSet<Infektion_seuranta_ja_hoito> Infektion_seuranta_ja_hoito { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Lääkelista> Lääkelista { get; set; }
        public virtual DbSet<Lääkärin_lausunnot_ja_hoitosuunnitelmat> Lääkärin_lausunnot_ja_hoitosuunnitelmat { get; set; }
        public virtual DbSet<Muistihoitajan_sivu> Muistihoitajan_sivu { get; set; }
        public virtual DbSet<Rokotuslista> Rokotuslista { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tehtävälista_asukkaan_saapuessa_palvelutaloon> Tehtävälista_asukkaan_saapuessa_palvelutaloon { get; set; }
        public virtual DbSet<Vointi_päiväkirja> Vointi_päiväkirja { get; set; }
        public virtual DbSet<Vuokrasopimus> Vuokrasopimus { get; set; }
    
        public virtual ObjectResult<LoginByUsernamePassword_Result> LoginByUsernamePassword(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LoginByUsernamePassword_Result>("LoginByUsernamePassword", usernameParameter, passwordParameter);
        }
    }
}
