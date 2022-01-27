using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Commerce.Data.ORM.Entities
{
    public class ProductImage:BaseEntity
    {
        public int ProductId { get; set; }
        public string ImagePath { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
