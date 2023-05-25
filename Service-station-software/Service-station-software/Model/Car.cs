using System.Collections.Generic;
namespace Service_station_software
{
    public class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Service> Services { get; set; }
        public Master Master { get; set; }
    }
}
