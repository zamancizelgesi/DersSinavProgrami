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
    public class BolumManager : IBolumService
    {
        IBolumDAL bolumDAL;
        public List<Bolum> GetBolumListWithFakulte()
        {
            return bolumDAL.GetListWithFakulte();
        }
        public BolumManager(IBolumDAL bolumDAL)
        {
            this.bolumDAL = bolumDAL;
        }

        public Bolum GetByIdD(int id)
        {
            return bolumDAL.GetById(id);
        }

        public List<Bolum> GetListAll()
        {
            return bolumDAL.GetListAll();
        }

        public void TAdd(Bolum t)
        {
            bolumDAL.Insert(t);
        }

        public void TRemove(Bolum t)
        {
            bolumDAL.Delete(t); 
        }

        public void TUpdate(Bolum t)
        {
            bolumDAL.Update(t); 
        }
    }
}
