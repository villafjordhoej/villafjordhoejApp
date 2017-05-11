namespace VilaFjordhoejWS
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VillaContext : DbContext
    {
        public VillaContext()
            : base("name=VillaContext")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<app_behandlinger> app_behandlinger { get; set; }
        public virtual DbSet<app_booking> app_booking { get; set; }
        public virtual DbSet<app_gaest> app_gaest { get; set; }
        public virtual DbSet<app_m_behandling> app_m_behandling { get; set; }
        public virtual DbSet<app_m_vaerelser> app_m_vaerelser { get; set; }
        public virtual DbSet<app_medarbejder> app_medarbejder { get; set; }
        public virtual DbSet<app_vaerelse> app_vaerelse { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<app_behandlinger>()
                .Property(e => e.behandlinger_navn)
                .IsUnicode(false);

            modelBuilder.Entity<app_behandlinger>()
                .Property(e => e.behandlinger_beskrivelse)
                .IsUnicode(false);

            modelBuilder.Entity<app_behandlinger>()
                .Property(e => e.behandlinger_pris)
                .HasPrecision(18, 0);

            modelBuilder.Entity<app_booking>()
                .Property(e => e.booking_allergener)
                .IsUnicode(false);

            modelBuilder.Entity<app_booking>()
                .Property(e => e.booking_information)
                .IsFixedLength();

            modelBuilder.Entity<app_gaest>()
                .Property(e => e.gaest_navn)
                .IsUnicode(false);

            modelBuilder.Entity<app_gaest>()
                .Property(e => e.gaest_adresse)
                .IsUnicode(false);

            modelBuilder.Entity<app_gaest>()
                .Property(e => e.gaest_mail)
                .IsUnicode(false);

            modelBuilder.Entity<app_booking>()
                .Property(e => e.booking_aftaltpris)
                .HasPrecision(18, 0);

            modelBuilder.Entity<app_medarbejder>()
                .Property(e => e.medarbejder_navn)
                .IsUnicode(false);

            modelBuilder.Entity<app_medarbejder>()
                .Property(e => e.medarbejder_adresse)
                .IsUnicode(false);

            modelBuilder.Entity<app_vaerelse>()
                .Property(e => e.vaerelse_navn)
                .IsUnicode(false);

            modelBuilder.Entity<app_vaerelse>()
                .Property(e => e.vaerelse_pris)
                .HasPrecision(18, 0);
        }
    }
}
