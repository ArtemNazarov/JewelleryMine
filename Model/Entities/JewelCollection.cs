namespace JewelleryMine.Model.Entities
{
    public partial class JewelCollection
    {
        public int JewelId { get; set; }
        public Jewel Jewel { get; set; }

        public int ProductCollectionId { get; set; }

        public ProductCollection ProductCollection { get; set; }

    }
}