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
    public class DerslikDersKisitManager : IDerslikDersKisitService
    {
        IDerslikDersKisitDAL derslikDersKisit;
        public DerslikDersKisitManager(IDerslikDersKisitDAL derslikDersKisit)
        {
            this.derslikDersKisit = derslikDersKisit;
        }

        public DerslikDersKisit GetByIdD(int id)
        {
            return derslikDersKisit.GetById(id);
        }

        public List<DerslikDersKisit> GetListAll()
        {
            return derslikDersKisit.GetListAll();
        }

        public void TAdd(DerslikDersKisit t)
        {
            derslikDersKisit.Insert(t);
        }

        public void TRemove(DerslikDersKisit t)
        {
            derslikDersKisit.Delete(t); 
        }

        public void TUpdate(DerslikDersKisit t)
        {
            derslikDersKisit.Update(t);    
        }
    }
}
