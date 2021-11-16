using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sugarbakers.Models
{
    public partial class Orders
    {
        public Orders()
        {
            ItemsonOrder = new HashSet<ItemsonOrder>();
        }

        public int OrdersId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? FreightCharge { get; set; }
        public decimal? TotalDue { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<ItemsonOrder> ItemsonOrder { get; set; }
    }
}
