using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sugarbakers.Models
{
    public partial class Payments
    {
        public int CustomerId { get; set; }
        public DateTime PmtDate { get; set; }
        public decimal? Amt { get; set; }

        public virtual Customers Customer { get; set; }
    }
}
