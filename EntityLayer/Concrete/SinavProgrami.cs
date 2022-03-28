using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SinavProgrami
    {
        [Key]
        public int SinavProgramiId { get; set; }
        public int? SinavGunu { get; set; }
        public DateTime? SinavSaati { get; set; }
        public int? DersId { get; set; }
        public int? DerslikId { get; set; }
        public int? DonemId { get; set; }
        public int? AkademisyenId { get; set; }
        public Ders? Ders { get; set; }
        public Derslik? Derslik { get; set; }
        public Donem? Donem { get; set; }
        public Akademisyen? Akademisyen { get; set; }

    }
}
