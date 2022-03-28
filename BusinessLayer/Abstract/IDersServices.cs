using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDersServices : IGenericService<Ders>
    {
        //void DersAdd(Ders ders); //Buralar generic olacak tüm sınıfları oluşturmayacğım o yüzden
        //void DersRemove(Ders ders);
        //void DersUpdate(Ders ders);

        //List<Ders> GetList();

        //Ders GetById(int id);
        List<Ders> GetDersListWithAkademisyen();
    }
}
