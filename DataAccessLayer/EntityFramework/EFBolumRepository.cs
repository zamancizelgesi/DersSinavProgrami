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
    public  class EFBolumRepository: GenericRepository<Bolum>, IBolumDAL
    {
        public List<Bolum> GetListWithFakulte()
        {
            using (var c = new Context())
            {
                return c.Bolums.Include(x => x.Fakulte).ToList();
            }

        }
    }
}
