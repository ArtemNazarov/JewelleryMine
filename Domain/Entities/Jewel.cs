using System;
using System.Collections.Generic;
using JewelleryMine.Model.Entities;

namespace JewelleryMine.Model.Entities
{
    public partial class Jewel
    {
        public Jewel()
        {
            JewelCollections = new List<JewelCollection>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int CategoryId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid? PhotoId { get; set; }
        public virtual Category Category { get; set; }
        public virtual IList<JewelCollection> JewelCollections { get; set; }
        public virtual Image Photo { get; set; }

    }
}