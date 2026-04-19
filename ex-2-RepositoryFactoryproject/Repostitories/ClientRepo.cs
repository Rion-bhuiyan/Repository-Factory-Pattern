using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2_RepositoryFactoryproject.Model.Repostitories
{
    public class ClientRepo : iRepo
    {
        public void Delete(Client client)
        {
            Client _client=ClientDB.clientList.FirstOrDefault(x=>x.ClientID==client.ClientID);
            if (_client!=null)
            {
                ClientDB.clientList.Remove(client);
            }

        }

        public IEnumerable<Client> GetAll()
        {
            return ClientDB.clientList;
        }

        public Client GetByID(int clientId)
        {
            Client client = ClientDB.clientList.FirstOrDefault(x => x.ClientID ==clientId);
            return client;
        }

        public void Insert(Client client)
        {
             ClientDB.clientList.Add(client);
        }

        public void Update(Client client)
        {
            Client _client=ClientDB.clientList.FirstOrDefault(x=>x.ClientID == client.ClientID);
            if (_client.ClientName != null)
            {
                _client.ClientName = client.ClientName;
            }
            if(_client.Age!=0)
            {
                _client.Age = client.Age;
            }
        }
    }
}
