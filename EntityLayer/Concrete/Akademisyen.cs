using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Akademisyen
    {
        [Key]
        public int AkademisyenId { get; set; }
        public string? AkademisyenAdi { get; set; }
        public string? AkademisyenSoyadi { get; set; }
        public string? AkademisyenMail { get; set; }
        public bool? Asistan { get; set; }
        public string? AkademisyenUnvani { get; set; }
        public int? DonemId { get; set; }
        public  Donem? Donem { get; set; }

        public ICollection<AkademisyenKisit>? AkademisyenKisits { get; set; }
        public ICollection<Ders>? Derses { get; set; }
        public ICollection<Ogrenci>? Ogrencis { get; set; }
        public ICollection<SinavProgrami>? SinavProgramis { get; set; }


    }
}
