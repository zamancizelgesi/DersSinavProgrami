using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDerslikService : IGenericService<Derslik>
    {
        //void DerslikAdd(Derslik derslik); //Buralar generic olacak tüm sınıfları oluşturmayacğım o yüzden
        //void DerslikRemove(Derslik derslik);
        //void DerslikUpdate(Derslik derslik);

        //List<Derslik> GetList();

        //Derslik GetById(int id);
    }
}
