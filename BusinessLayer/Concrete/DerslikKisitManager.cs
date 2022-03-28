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
    public class DerslikKisitManager : IDerslikKisitService
    {
        IDerslikKisitDAL derslikKisitDAL;

        public DerslikKisitManager(IDerslikKisitDAL derslikKisitDAL)
        {
            this.derslikKisitDAL = derslikKisitDAL;
        }
        public List<DerslikKisit> GetDerslikKisitListWithDerslik()
        {
            return derslikKisitDAL.GetListWithDerslik();
        }

        public DerslikKisit GetByIdD(int id)
        {
            return derslikKisitDAL.GetById(id);
        }

        public List<DerslikKisit> GetListAll()
        {
            return derslikKisitDAL.GetListAll();
        }

        public void TAdd(DerslikKisit t)
        {
            derslikKisitDAL.Insert(t);
        }

        public void TRemove(DerslikKisit t)
        {
            derslikKisitDAL.Delete(t);  
        }

        public void TUpdate(DerslikKisit t)
        {
            derslikKisitDAL.Update(t);  
        }
    }
}
