using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Client
{
    public partial class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid JeweleryId { get; set; }
        public int Price { get; set; }

        public virtual Jewelery Jewelery { get; set; }
        public virtual Order Order { get; set; }
    }
}
