using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vintustore
{
    public class Device
    {
        public string Dev_ID { get; set; }
        public string Dev_Name { get; set; }
        public string Dev_IMEI { get; set; }
        public string Dev_Price { get; set; }
        public string Dev_Specs { get; set; }
    }

    public class RootObject
    {
        public List<Device> Device { get; set; }
    }
}
