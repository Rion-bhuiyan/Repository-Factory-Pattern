using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2_RepositoryFactoryproject.Model.Repostitories
{
    public interface iRepo
    {
        IEnumerable<Client> GetAll();
        Client GetByID(int clientId);
        void Insert(Client client);
        void Update(Client client);
        void Delete(Client client);

    }
}
