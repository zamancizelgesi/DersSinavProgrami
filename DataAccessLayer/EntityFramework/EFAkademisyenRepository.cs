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
    public class EFAkademisyenRepository : GenericRepository<Akademisyen>, IAkademisyenDAL
    {
        public List<Akademisyen> GetListWithDonem()
        {
            using (var c = new Context())
            {
                return c.Akademisyens.Include(x => x.Donem).ToList();
            }

        }
    }
}
