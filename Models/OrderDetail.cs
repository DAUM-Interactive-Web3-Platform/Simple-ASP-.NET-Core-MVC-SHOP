using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int SnowboardId { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public virtual Snowboard Snowboard { get; set; }
        public virtual Order Order { get; set; }
    }
}
