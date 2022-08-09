using Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Product : BaseEntity, IEntity
    {
        public string? Title { get; set; }
        public double Price { get; set; }

        public List<ProductImage> ProductImages { get; set; }
    }
}
