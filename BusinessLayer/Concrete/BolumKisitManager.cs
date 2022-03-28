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
    public  class BolumKisitManager : IBolumKısıtService
    {
        IBolumKisitDAL bolumKisitDAL;

        public BolumKisitManager(IBolumKisitDAL bolumKisitDAL)
        {
            this.bolumKisitDAL = bolumKisitDAL;
        }

        public List<BolumKisit> GetBolumKisitListByBolum(int id)
        {
            return bolumKisitDAL.GetListAll();
        }

        public List<BolumKisit> GetBolumKisitListWithSablonZaman()
        {
            return bolumKisitDAL.GetListWithSablonZaman();
        }
        public BolumKisit GetByIdD(int id)
        {
            return bolumKisitDAL.GetById(id);
        }

        public List<BolumKisit> GetListAll()
        {
            return bolumKisitDAL.GetListAll();  
        }

        public void TAdd(BolumKisit t)
        {
            bolumKisitDAL.Insert(t);
        }

        public void TRemove(BolumKisit t)
        {
            bolumKisitDAL.Delete(t);    
        }

        public void TUpdate(BolumKisit t)
        {
            bolumKisitDAL.Update(t);    
        }
    }
}
