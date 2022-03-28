using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciId { get; set; }
        public string? OgrenciAdi { get; set; }
        public string? OgrenciSoyadi { get; set; }
        public int? OgrenciNumarasi { get; set; }
        public int? AkademisyenId { get; set; }
        public int? DersId { get; set; }
        public Akademisyen? Akademisyen { get; set; }
        public Ders? Ders { get; set; }

    }
}
