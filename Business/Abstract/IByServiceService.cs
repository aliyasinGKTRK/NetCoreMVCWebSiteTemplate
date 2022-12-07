using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IByServiceService
    {
        void Add(Service service);
        void Delete(Service service);
        void Update(Service service);
        Service GetById(int id);
        List<Service> GetAll();
    }
}
