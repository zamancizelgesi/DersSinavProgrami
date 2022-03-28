using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBolumKısıtService : IGenericService<BolumKisit>
    {

        List<BolumKisit> GetBolumKisitListWithSablonZaman();
        List<BolumKisit> GetBolumKisitListByBolum(int id);

    }
}
