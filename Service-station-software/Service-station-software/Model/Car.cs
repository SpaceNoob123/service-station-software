using System.Collections.Generic;
namespace Service_station_software
{
    // Модель
    public class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Service> Services { get; set; }
        public Master AssignedMaster { get; set; }
    }
}
