namespace Service_station_software
{
    // Модель
    public class Part
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public Car AssignedCar { get; set; }
    }
}
