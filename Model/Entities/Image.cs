namespace BroochMine.Model.Entities
{
    public partial class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] ImageContent { get; set; }
        public byte[] SmallPreview { get; set; }
        public byte[] BigPreview { get; set; }
    }
}