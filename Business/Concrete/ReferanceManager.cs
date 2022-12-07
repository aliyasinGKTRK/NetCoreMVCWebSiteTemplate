using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReferanceManager : IReferanceService
    {
        IReferanceDal _referanceDal;

        public ReferanceManager(IReferanceDal referanceDal)
        {
            _referanceDal = referanceDal;
        }

        public void Add(Referance referance)
        {
            _referanceDal.Add(referance);
        }

        public void Delete(Referance referance)
        {
            _referanceDal.Delete(referance);
        }


        public List<Referance> GetAll()
        {
            return _referanceDal.GetAll().ToList();
        }

        public Referance GetById(int id)
        {
            return _referanceDal.GetById(id);
        }

        public void Update(Referance referance)
        {
            throw new NotImplementedException();
        }
    }
}
