using Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client
{
    public class DataManager
    {
        public List<Jewelery> Jewelery { get; set; }
        public List<Order> Order { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }

        public DataManager()
        {
            using (WebAppContext db = new WebAppContext())
            {
                Jewelery = db.Jewelery.ToList();
                Order = db.Order.ToList();
                OrderDetail = db.OrderDetail.ToList();
            }
            
        }
    }
}
