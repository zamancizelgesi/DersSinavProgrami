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
    public class AkademisyenKisitManager : IAkademisyenKisitService
    {
        IAkademisyenKisitDAL akademisyenKisitDAL;
        
        public AkademisyenKisitManager(IAkademisyenKisitDAL akademisyenKisitDAL)
        {
            this.akademisyenKisitDAL = akademisyenKisitDAL;
        }

        public AkademisyenKisit GetByIdD(int id)
        {
           return akademisyenKisitDAL.GetById(id);
        }

        public List<AkademisyenKisit> GetListAll()
        {
            return akademisyenKisitDAL.GetListAll();
        }

        public void TAdd(AkademisyenKisit t)
        {
            akademisyenKisitDAL.Insert(t);
        }

        public void TRemove(AkademisyenKisit t)
        {
            akademisyenKisitDAL.Delete(t);
        }

        public void TUpdate(AkademisyenKisit t)
        {
            akademisyenKisitDAL.Update(t);
        }
    }
}
