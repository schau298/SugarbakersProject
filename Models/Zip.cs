using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sugarbakers.Models
{
    public partial class Zip
    {
        public Zip()
        {
            Customers = new HashSet<Customers>();
        }

        public string Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
    }
}
