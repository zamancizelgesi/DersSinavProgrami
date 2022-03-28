
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
    public class DersProgramiManager : IDersProgramiService
    {
        IDersProgramiDAL dersProgramiDAL;

        public DersProgramiManager(IDersProgramiDAL dersProgramiDAL)
        {
            this.dersProgramiDAL = dersProgramiDAL;
        }

        public DersProgrami GetByIdD(int id)
        {
            return dersProgramiDAL.GetById(id); 
        }

        public List<DersProgrami> GetListAll()
        {
            return dersProgramiDAL.GetListAll();    
        }

        public void TAdd(DersProgrami t)
        {
            dersProgramiDAL.Insert(t);  
        }

        public void TRemove(DersProgrami t)
        {
            dersProgramiDAL.Delete(t);
        }

        public void TUpdate(DersProgrami t)
        {
            dersProgramiDAL.Update(t);  
        }
    }
}
