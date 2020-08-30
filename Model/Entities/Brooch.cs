namespace BroochMine.Model.Entities
{
    public partial class Brooch
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Price { get; set; }

        public Image Photo {get; set;}

    }
}