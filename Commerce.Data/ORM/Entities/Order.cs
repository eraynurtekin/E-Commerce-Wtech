using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Commerce.Data.ORM.Entities
{
    public class Order:BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public int WebUserId { get; set; }
        public string OrderAddress { get; set; }

        [ForeignKey("WebUserId")]
        public WebUser WebUser { get; set; }
    }
}
