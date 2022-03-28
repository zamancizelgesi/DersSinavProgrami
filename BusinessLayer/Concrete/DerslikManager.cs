using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
     public class DerslikManager : IDerslikService
    {
        IDerslikDAL derslikDAL;

        public DerslikManager(IDerslikDAL derslikDAL)
        {
            this.derslikDAL = derslikDAL;
        }

        public void DerslikAdd(Derslik derslik)
        {
            throw new NotImplementedException();
        }

        public void DerslikRemove(Derslik derslik)
        {
            derslikDAL.Delete(derslik);
        }

        public void DerslikUpdate(Derslik derslik)
        {
            derslikDAL.Update(derslik);
            
        }

        public Derslik GetById(int id)
        {
            return derslikDAL.GetById(id);
        }

        public Derslik GetByIdD(int id)
        {
            throw new NotImplementedException();
        }

        public List<Derslik> GetList()
        {
             return derslikDAL.GetListAll();
        }

        public List<Derslik> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Derslik t)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Derslik t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Derslik t)
        {
            throw new NotImplementedException();
        }
    }
}
