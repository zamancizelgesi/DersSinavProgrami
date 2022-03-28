using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ders
    {
        [Key]
        public int DersId { get; set; }
        public string? DersAdi { get; set; }
        public string? DersKodu { get; set; }
        public int? UygulamaSaati { get; set; }
        public int? TeorikSaati { get; set; }
        public int? ÖğrenciSayisi { get; set; }
        public int? Kontenjan { get; set; }
        public int? BolumId { get; set; }
        public int? AkademisyenId { get; set; }
        public int? DonemId { get; set; }
        public string? DersTipi { get; set; }
        public string? DersSube { get; set; }

        public Bolum? Bolum { get; set; }
        public Akademisyen? Akademisyen { get; set; }
        public Donem? Donem { get; set; }
        public ICollection<DerslikDersKisit>? DerslikDersKisits { get; set; }
        public ICollection<DersProgrami>? DersProgramis { get; set; }
        public ICollection<Ogrenci>? Ogrencis { get; set; }
        public ICollection<SinavProgrami>? SinavProgramis { get; set; }

    }
}
