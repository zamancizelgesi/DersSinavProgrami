using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SablonZaman
    {
        [Key]
        public int SablonZamanId { get; set; }
        public DateTime? DersBaslangic { get; set; }
        public DateTime? DersBitis { get; set; }
        public string? Gun { get; set; }
        public ICollection<AkademisyenKisit>? AkademisyenKisits { get; set; }
        public ICollection<BolumKisit>? BolumKisits { get; set; }
        public ICollection<DerslikKisit>? DerslikKisits { get; set; }

    }
}
