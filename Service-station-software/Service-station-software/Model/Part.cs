namespace Service_station_software
{
    public class Part
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public Car Car { get; set; }
    }
}
