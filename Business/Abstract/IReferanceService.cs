using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReferanceService
    {
        void Add(Referance referance);
        void Delete(Referance referance);
        void Update(Referance referance);
        Referance GetById(int id);
        List<Referance> GetAll();

    }
}
