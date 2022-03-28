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
    public class SinavProgramiManager : ISinavProgramiService
    {
        ISinavProgramiDAL sinavProgramiDAL;

        public SinavProgramiManager(ISinavProgramiDAL sinavProgramiDAL)
        {
            this.sinavProgramiDAL = sinavProgramiDAL;
        }

        public SinavProgrami GetByIdD(int id)
        {
            return sinavProgramiDAL.GetById(id);
        }

        public List<SinavProgrami> GetListAll()
        {
            return sinavProgramiDAL.GetListAll();   
        }

        public void TAdd(SinavProgrami t)
        {
            sinavProgramiDAL.Insert(t); 
        }

        public void TRemove(SinavProgrami t)
        {
            sinavProgramiDAL.Delete(t); 
        }

        public void TUpdate(SinavProgrami t)
        {
            sinavProgramiDAL.Update(t); 
        }
    }
}
