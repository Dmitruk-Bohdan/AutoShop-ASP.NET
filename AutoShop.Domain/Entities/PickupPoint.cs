using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop.Domain.Entities
{
    public class PickupPoint
    {
        public int Id { get; set; }
        public ICollection<Good> Goods { get; set; } = new List<Good>();
        public List<PointGoods> PointGoods { get; set; } = new List<PointGoods> { };
    }
}
