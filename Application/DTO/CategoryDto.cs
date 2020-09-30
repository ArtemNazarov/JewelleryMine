using JewelleryMine.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelleryMine.Application.DTO
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CategoryDto(Category category)
        {
            Id = category.Id;
            Name = category.Name;
        }

    }
}
