using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class DersProgrami
    {
        [Key]
        public int DersProgramiId { get; set; }
        public int? DersGunu { get; set; }
        public DateTime? DersSaati { get; set; }
        public int? DersId { get; set; }
        public int? DerslikId { get; set; }
        public int? DonemId { get; set; }
        public Ders? Ders { get; set; }
        public Derslik? Derslik { get; set; }
        public Donem? Donem { get; set; }

    }
}
