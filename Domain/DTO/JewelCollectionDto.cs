using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelleryMine.Domain.DTO
{
    public class JewelCollectionDto
    {
        public Guid JewelId { get; set; }
        public Guid ProductCollectionId { get; set; }
        public DateTime? CreatedOn { get; set; }

    }
}
