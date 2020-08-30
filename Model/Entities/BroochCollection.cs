using System.Collections.Generic;

namespace BroochMine.Model.Entities
{
    public partial class BroochCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Brooch> Brooches { get; set; }
    }
}