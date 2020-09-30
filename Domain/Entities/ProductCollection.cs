using System;
using System.Collections.Generic;

namespace JewelleryMine.Model.Entities
{
    public partial class ProductCollection
    {
        public ProductCollection()
        {
            JewelCollections = new List<JewelCollection>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime? CreatedOn { get; set; }

        public virtual IList<JewelCollection> JewelCollections {get; set;}
    }
}