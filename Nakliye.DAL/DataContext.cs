namespace Nakliye.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Nakliye.ENTITY;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=ConnectionString")
        {
        }

        public virtual DbSet<Adresler> Adresler { get; set; }
        public virtual DbSet<MusteriAdres> MusteriAdres { get; set; }
        public virtual DbSet<Musteriler> Musteriler { get; set; }
        public virtual DbSet<Nakliyeciler> Nakliyeciler { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Taşımalar> Taşımalar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adresler>()
                .HasMany(e => e.Taşımalar)
                .WithRequired(e => e.Adresler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Adresler>()
                .HasMany(e => e.MusteriAdres)
                .WithRequired(e => e.Adresler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musteriler>()
                .HasMany(e => e.MusteriAdres)
                .WithRequired(e => e.Musteriler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musteriler>()
                .HasMany(e => e.Taşımalar)
                .WithRequired(e => e.Musteriler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nakliyeciler>()
                .Property(e => e.NakliyeciSehir)
                .IsFixedLength();

            modelBuilder.Entity<Nakliyeciler>()
                .Property(e => e.NakliyeciSemt)
                .IsFixedLength();

            modelBuilder.Entity<Nakliyeciler>()
                .HasMany(e => e.Taşımalar)
                .WithRequired(e => e.Nakliyeciler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nakliyeciler>()
                .HasMany(e => e.Photo)
                .WithRequired(e => e.Nakliyeciler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Photo>()
                .Property(e => e.Photo1)
                .IsUnicode(false);
        }
    }
}
