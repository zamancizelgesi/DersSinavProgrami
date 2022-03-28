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
    public class FakulteManager : IFakulteService
    {
        IFakulteDAL fakulteDAL;

        public FakulteManager(IFakulteDAL fakulteDAL)
        {
            this.fakulteDAL = fakulteDAL;
        }

        public Fakulte GetByIdD(int id)
        {
            return fakulteDAL.GetById(id);
        }

        public List<Fakulte> GetListAll()
        {
            return fakulteDAL.GetListAll(); 
        }

        public void TAdd(Fakulte t)
        {
            fakulteDAL.Insert(t);   
        }

        public void TRemove(Fakulte t)
        {
            fakulteDAL.Delete(t);
        }

        public void TUpdate(Fakulte t)
        {
            fakulteDAL.Update(t);   
        }
    }
}
