using System.Collections.Generic;
namespace Service_station_software
{
    // Модель
    public class Master : Person
    {
        public string Level { get; set; }
        public List<string> Specialties { get; set; }
    }
}
