using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop.Domain.Entities
{
    public class PointGoods
    {
        public int PointId { get; set; }
        public PickupPoint PickupPoint { get; set; }
        public int GoodId { get; set; }
        public Good Good { get; set; }
    }
}
