using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop.Domain.Entities
{
    public class Good
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public List<PickupPoint> PickupPoints { get; set; } = new List<PickupPoint>();
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }


    }
}
