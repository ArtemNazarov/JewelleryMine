using JewelleryMine.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelleryMine.Model.Configuration
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> modelBuilder)
        {
            modelBuilder
               .HasMany(e => e.Jewels)
               .WithOne(e => e.Category)
               .HasForeignKey(e => e.CategoryId);

            modelBuilder
                .HasData(new Category
                {
                    Id = 1,
                    Name = "Rings",
                },
                new Category
                {
                    Id = 2,
                    Name = "Watches"
                },
                new Category
                {
                    Id = 3,
                    Name = "Pendants"
                },
                new Category
                {
                    Id = 4,
                    Name = "Bracelets"
                },
                new Category
                {
                    Id = 5,
                    Name = "Chains"
                },
                new Category
                {
                    Id = 6,
                    Name = "Charms"
                },
                new Category
                {
                    Id = 7,
                    Name = "Necklace"
                },
                new Category
                {
                    Id = 8,
                    Name = "Brooches"
                });
        }
    }
}
