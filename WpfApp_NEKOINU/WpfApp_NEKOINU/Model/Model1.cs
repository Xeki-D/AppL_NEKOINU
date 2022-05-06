namespace WpfApp_NEKOINU.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<acheter> acheter { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<commande> commande { get; set; }
        public virtual DbSet<produit> produit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<client>()
                .Property(e => e.NOM_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.PRENOM_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.MDP_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.ADR_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.VILLE_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.CP_CLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.commande)
                .WithRequired(e => e.client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<commande>()
                .HasMany(e => e.acheter)
                .WithRequired(e => e.commande)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.NOM_PRODUIT)
                .IsUnicode(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.DESC_PRODUIT)
                .IsUnicode(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.IMG_PRODUIT)
                .IsUnicode(false);

            modelBuilder.Entity<produit>()
                .HasMany(e => e.acheter)
                .WithRequired(e => e.produit)
                .WillCascadeOnDelete(false);
        }
    }
}
