using System;

namespace Commerce.Data.ORM.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}