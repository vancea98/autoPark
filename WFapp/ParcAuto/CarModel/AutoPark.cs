using System;
using System.Collections.Generic;
using System.Text;

namespace CarModel
{
    public class AutoPark
    {
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
        public List<Vendor> Vendors { get; set; }

        public AutoPark()
        {
            Cars = new List<Car>();
            Vendors = new List<Vendor>();

        }
    }
}
