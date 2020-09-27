using System;

namespace JewelleryMine.Model.Entities
{
    public partial class JewelCollection
    {
        public Guid JewelId { get; set; }
        public Jewel Jewel { get; set; }
        public Guid ProductCollectionId { get; set; }
        public ProductCollection ProductCollection { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}