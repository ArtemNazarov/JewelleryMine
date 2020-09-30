using JewelleryMine.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelleryMine.Application.DTO
{
    public class ProductCollectionDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime? CreatedOn { get; set; }

        public IEnumerable<JewelDto> JewelCollection { get; set; }

        public ProductCollectionDto(ProductCollection productCollection)
        {
            Id = productCollection.Id;
            Name = productCollection.Name;
            CreatedOn = productCollection.CreatedOn;
            JewelCollection = productCollection.JewelCollections.Select(jewelCollection => new JewelDto(jewelCollection.Jewel));
        }
    }
}
