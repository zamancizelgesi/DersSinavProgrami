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
    public class AkademisyenManager : IAkademisyenService
    {
        IAkademisyenDAL akademisyenDAL;

        public AkademisyenManager(IAkademisyenDAL akademisyenDAL)
        {
            this.akademisyenDAL = akademisyenDAL;
        }

     

        public Akademisyen GetByIdD(int id)
        {
            return akademisyenDAL.GetById(id);
        }

        public List<Akademisyen> GetListAll()
        {
            return akademisyenDAL.GetListAll();
        }

        public void TAdd(Akademisyen t)
        {
            akademisyenDAL.Insert(t);
        }

        public void TRemove(Akademisyen t)
        {
            akademisyenDAL.Delete(t);   
        }

        public void TUpdate(Akademisyen t)
        {
            akademisyenDAL.Update(t);   
        }
    }
}
