using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_station_software.Model
{
    public class Order
    {
        public DateTime Date { get; set; }
        public Client Client { get; set; }
        public Car Car { get; set; }
        public Master Master { get; set; }
        public Service Service { get; set; }
        public Part Part { get; set; }
    }
}
