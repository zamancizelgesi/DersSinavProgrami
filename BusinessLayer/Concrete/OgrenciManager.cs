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
    public class OgrenciManager : IOgrenciService
    {
        IOgrenciDAL ogrenciDAL;

        public OgrenciManager(IOgrenciDAL ogrenciDAL)
        {
            this.ogrenciDAL = ogrenciDAL;
        }

        public Ogrenci GetByIdD(int id)
        {
            return ogrenciDAL.GetById(id);
        }

        public List<Ogrenci> GetListAll()
        {
            return ogrenciDAL.GetListAll(); 
        }

        public void TAdd(Ogrenci t)
        {
            ogrenciDAL.Insert(t);   
        }

        public void TRemove(Ogrenci t)
        {
            ogrenciDAL.Delete(t);   
        }

        public void TUpdate(Ogrenci t)
        {
            ogrenciDAL.Update(t);   
        }
    }
}
