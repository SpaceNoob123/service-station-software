using System.Collections.Generic;
namespace Service_station_software
{
    public class Master : Person
    {
        public int Id { get; set; }
        public string Level { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {PhoneNumber},{Level}";
        }
    }
}
