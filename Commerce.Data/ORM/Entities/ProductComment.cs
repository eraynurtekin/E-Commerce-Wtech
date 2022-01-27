using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Commerce.Data.ORM.Entities
{
    public class ProductComment:BaseEntity
    {
        public int ProductId { get; set; }
        public string Comment { get; set; }
        public int WebUserId { get; set; }

        [ForeignKey("WebUserId")]
        public WebUser WebUser { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
