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
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public Guid? PhotoId { get; set; }
        public string Guid { get; set; }
        public string Pin { get; set; }
        public string AuthPhone { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string DeviceToken { get; set; }
        public int? LastActivityEvent { get; set; }
        public int? DeviceOs { get; set; }
        public Image Photo { get; set; }
    }
}