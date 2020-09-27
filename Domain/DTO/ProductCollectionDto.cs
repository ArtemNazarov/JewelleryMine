using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelleryMine.Domain.DTO
{
    public class ProductCollectionDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime? CreatedOn { get; set; }

        public IEnumerable<JewelCollectionDto> JewelCollections { get; set; }
    }
}
