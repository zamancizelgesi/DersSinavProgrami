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
    public class DonemManager : IDonemService
    {
        IDonemDAL donemDAL;

        public DonemManager(IDonemDAL donemDAL)
        {
            this.donemDAL = donemDAL;
        }

        public Donem GetByIdD(int id)
        {
            return donemDAL.GetById(id);
        }

        public List<Donem> GetListAll()
        {
            return donemDAL.GetListAll();   
        }

        public void TAdd(Donem t)
        {
            donemDAL.Insert(t); 
        }

        public void TRemove(Donem t)
        {
           donemDAL.Delete(t);
        }

        public void TUpdate(Donem t)
        {
            donemDAL.Update(t); 
        }
    }
}
