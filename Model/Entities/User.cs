using System;

namespace JewelleryMine.Model.Entities
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime? BirthDate { get; set; }
        public Guid? PhotoId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string BrowserType { get; set; }
        public string DeviceType { get; set; }
        public int? DeviceOs { get; set; }
        public Image Photo { get; set; }
        public string IpAddress { get; set; }
        public string Locale { get; set; }
        public string UtmSource { get; set; }
        public string UtmMedium { get; set; }
        public string UtmCampaign { get; set; }
        public string UtmTerm { get; set; }
        public string UtmContent { get; set; }
    }
}