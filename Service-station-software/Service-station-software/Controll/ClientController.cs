using System.Collections.Generic;
namespace Service_station_software.Controll
{
    public class ClientController
    {
        private readonly List<Client> clients;

        public ClientController()
        {
            clients = new List<Client>();
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        public List<Client> GetAllClients()
        {
            return clients;
        }
    }
}
