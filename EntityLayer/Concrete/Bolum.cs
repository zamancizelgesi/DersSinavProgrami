using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bolum
    {
        [Key]
        public int BolumId { get; set; }
        public string? BolumAdi { get; set; }
        public int? FakulteId { get; set; }
        public Fakulte? Fakulte { get; set; }

        public ICollection<BolumKisit>? BolumKisits { get; set; }
        public ICollection<Ders>? Derses { get; set; }

    }
}
