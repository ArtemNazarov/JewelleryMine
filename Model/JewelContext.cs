using System;
using JewelleryMine.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace JewelleryMine.Model
{
    public class JewelContext : DbContext
    {
        public virtual DbSet<Jewel> Jewels { get; set; }

        public virtual DbSet<ProductCollection> ProductCollections { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Image> Images { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Material> Materials { get; set; }

        public virtual DbSet<JewelCollection> JewelCollections { get; set; }

        // public static readonly ILoggerFactory loggerFactory = new LoggerFactory(new[] {
        //      new ConsoleLoggerProvider()
        // });

        public JewelContext(DbContextOptions<JewelContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AgentDress;Trusted_Connection=True;");
            if (!optionsBuilder.IsConfigured)
            {
                throw new Exception("В OrnamentalContext отсутствует строка подключения.");
            }
            // optionsBuilder.UseLoggerFactory()
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jewel>()
            .HasOne<Category>(jewel => jewel.Category)
            .WithMany(category => category.Jewels)
            .HasForeignKey(jewel => jewel.CategoryId);

            modelBuilder.Entity<Jewel>()
            .HasOne<Material>(jewel => jewel.Material)
            .WithMany(material => material.Jewels)
            .HasForeignKey(jewel => jewel.MaterialId);

            modelBuilder.Entity<Jewel>()
            .HasOne<Image>(jewel => jewel.Photo)
            .WithMany(image => image.Jewels)
            .HasForeignKey(jewel => jewel.PhotoId);

            #region jewel-to-product-collection
            modelBuilder.Entity<JewelCollection>().HasKey(jewelCollection => new { jewelCollection.JewelId, jewelCollection.ProductCollectionId });

            modelBuilder.Entity<JewelCollection>()
            .HasOne<ProductCollection>(jewelCollection => jewelCollection.ProductCollection)
            .WithMany(jewelCollection => jewelCollection.JewelCollections)
            .HasForeignKey(jewelCollection => jewelCollection.ProductCollectionId);

            modelBuilder.Entity<JewelCollection>()
            .HasOne<Jewel>(jewelCollection => jewelCollection.Jewel)
            .WithMany(jewelCollection => jewelCollection.JewelCollections)
            .HasForeignKey(jewelCollection => jewelCollection.JewelId);
            #endregion jewel-to-product-collection

            modelBuilder.Entity<ProductCollection>();

            modelBuilder.Entity<Category>()
            .HasMany(e => e.Jewels)
            .WithOne(e => e.Category)
            .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<Material>()
            .HasMany(e => e.Jewels)
            .WithOne(e => e.Material)
            .HasForeignKey(e => e.MaterialId);

            modelBuilder.Entity<Image>()
            .HasMany(e => e.Jewels)
            .WithOne(e => e.Photo)
            .HasForeignKey(e => e.PhotoId);

            modelBuilder.Entity<Image>()
            .HasMany(e => e.Users)
            .WithOne(e => e.Photo)
            .HasForeignKey(e => e.PhotoId);

            modelBuilder.Entity<User>();
        }
    }
}