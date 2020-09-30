using System.Collections.Generic;

namespace JewelleryMine.Model.Entities
{
    public partial class Category
    {
        public Category()
        {
            Jewels = new HashSet<Jewel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Jewel> Jewels { get; set; }
    }
}