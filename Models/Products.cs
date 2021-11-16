using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sugarbakers.Models
{
    public partial class Products
    {
        public Products()
        {
            ItemsonOrder = new HashSet<ItemsonOrder>();
        }

        public int ProductsId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ItemsonOrder> ItemsonOrder { get; set; }
    }
}
