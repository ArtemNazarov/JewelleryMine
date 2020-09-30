using JewelleryMine.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelleryMine.Application.DTO
{
    public class JewelDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid? PhotoId { get; set; }
        public string Photo { get; set; }

        public JewelDto(Jewel jewel)
        {
            Id = jewel.Id;
            Name = jewel.Name;
            Price = jewel.Price;
            CategoryId = jewel.CategoryId;
            CategoryName = jewel.Category.Name;
            CreatedOn = jewel.CreatedOn;
            if (jewel.PhotoId != null)
            {
                PhotoId = jewel.PhotoId;
                Photo = Convert.ToBase64String(jewel.Photo.ImageContent);
            }
        }

    }

}
