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
    public class SablonZamanManager : ISablonZamanService
    {
        ISablonZamanDAL sablonZamanDAL;

        public SablonZamanManager(ISablonZamanDAL sablonZamanDAL)
        {
            this.sablonZamanDAL = sablonZamanDAL;
        }

        public SablonZaman GetByIdD(int id)
        {
            return sablonZamanDAL.GetById(id);  
        }

        public List<SablonZaman> GetListAll()
        {
            return sablonZamanDAL.GetListAll(); 
        }

        public void TAdd(SablonZaman t)
        {
            sablonZamanDAL.Insert(t);   
        }

        public void TRemove(SablonZaman t)
        {
            sablonZamanDAL.Delete(t);

        }

        public void TUpdate(SablonZaman t)
        {
            sablonZamanDAL.Update(t);   
        }
    }
}
