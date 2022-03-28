using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFBolumKisitRepository: GenericRepository<BolumKisit>, IBolumKisitDAL
    {
       
        public List<BolumKisit> GetListWithSablonZaman()
        {
            using (var c = new Context())
            {
                c.BolumKisits.Include(x => x.SablonZaman).ToList();
                return c.BolumKisits.Include(x => x.Bolum).ToList();
           
            }

        }
    }
}
