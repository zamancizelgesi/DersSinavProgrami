using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DersManager : IDersServices
    {
        IDersDAL dersDAL;

        
        public DersManager(IDersDAL dersDAL)
        {
            this.dersDAL = dersDAL;
        }

       
        public Ders GetByIdD(int id)
        {
            return dersDAL.GetById(id);
        }

        public List<Ders> GetDersListWithAkademisyen()
        {
            return dersDAL.GetListWithAkademisyen();
        }

        public List<Ders> GetList()
        {
            return dersDAL.GetListAll();
        }

        public List<Ders> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Ders t)
        {
            dersDAL.Insert(t);
        }

        public void TRemove(Ders t)
        {
            dersDAL.Delete(t);
        }

        public void TUpdate(Ders t)
        {
            dersDAL.Update(t);
        }
    }
}
