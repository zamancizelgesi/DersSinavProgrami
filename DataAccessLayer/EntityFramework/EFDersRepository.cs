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
    public class EFDersRepository : GenericRepository<Ders>, IDersDAL
    {
        
        public List<Ders> GetListWithAkademisyen()
        {
             using( var c = new Context())
            {
                return c.Derses.Include(x => x.Akademisyen).ToList();
            }
            
        }
    }
}
