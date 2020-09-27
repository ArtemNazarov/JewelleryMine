using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelleryMine.Domain.DTO
{
    public class JewelDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int CategoryId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid? PhotoId { get; set; }
        public IEnumerable<JewelCollectionDto> JewelCollections { get; set; }

    }

}
