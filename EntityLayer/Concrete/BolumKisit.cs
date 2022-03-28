using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BolumKisit
    {
        [Key]
        public int BolumKisitId { get; set; }
        public int SablonZamanId { get; set; }
        public int BolumId { get; set; }
        public Bolum? Bolum { get; set; }
        public SablonZaman? SablonZaman { get; set; }
    }
}
