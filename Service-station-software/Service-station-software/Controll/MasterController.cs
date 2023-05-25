using System.Collections.Generic;
namespace Service_station_software.Controll
{
    public class MasterController
    {
        private readonly List<Master> masters;

        public MasterController()
        {
            masters = new List<Master>();
        }

        public void AddMaster(Master master)
        {
            masters.Add(master);
        }

        public List<Master> GetAllMasters()
        {
            return masters;
        }
    }
}
