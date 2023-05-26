using System.Collections.Generic;
namespace Service_station_software
{
    public class Client : Person
    {
        public int Id { get; set; }
        public List<Car> Cars { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {PhoneNumber}";
        }
    }
}
