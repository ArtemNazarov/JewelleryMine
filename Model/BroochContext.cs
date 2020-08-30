using System;
using BroochMine.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace BroochMine.Model
{
    public class BroochContext : DbContext
    {
        public virtual DbSet<Brooch> Brooches { get; set; }

        public virtual DbSet<BroochCollection> BroochCollections { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Image> Images { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public BroochContext(DbContextOptions<BroochContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AgentDress;Trusted_Connection=True;");
            if (!optionsBuilder.IsConfigured)
            {
                throw new Exception("В DressContext отсутствует строка подключения.");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}