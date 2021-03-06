using System;
using System.Collections.Generic;

namespace JewelleryMine.Model.Entities
{
    public partial class Image
    {
        public Image()
        {
            Jewels = new HashSet<Jewel>();
            Users = new HashSet<User>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] ImageContent { get; set; }
        public byte[] SmallPreview { get; set; }
        public byte[] BigPreview { get; set; }

        public DateTime? CreatedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Jewel> Jewels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        
    }
}