using JewelleryMine.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelleryMine.Domain.DTO
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<JewelDto> Jewels { get; set; }

        public CategoryDto(Category category)
        {
            Id = category.Id;
            Name = category.Name;
            if (category.Jewels != null)
            {
                if (category.Jewels.Count > 0)
                {
                    Jewels = category.Jewels.Select(jewel => new JewelDto
                    {
                        CategoryId = jewel.CategoryId,
                        CreatedOn = jewel.CreatedOn,
                        Id = jewel.Id,
                        Name = jewel.Name,
                        PhotoId = jewel.PhotoId,
                        Price = jewel.Price,
                        JewelCollections = jewel.JewelCollections.Select(jewelCollection => new JewelCollectionDto
                        {
                            CreatedOn = jewelCollection.CreatedOn,
                            JewelId = jewelCollection.JewelId,
                            ProductCollectionId = jewelCollection.ProductCollectionId
                        })
                    });
                }
            }
        }

    }
}
