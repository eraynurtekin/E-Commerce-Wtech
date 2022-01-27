using System;

namespace Commerce.Data.ORM.Entities
{
    public class WebUser:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
    }
}