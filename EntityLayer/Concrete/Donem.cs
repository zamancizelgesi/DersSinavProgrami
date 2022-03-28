using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Donem
    {
        [Key]
        public int DonemId { get; set; }
        public string? DonemAdi { get; set; }

        public ICollection<Akademisyen>? Akademisyens { get; set; }
        public ICollection<Ders>? Derses { get; set; }
        public ICollection<DersProgrami>? DersProgramis { get; set; }
        public ICollection<SinavProgrami>? SinavProgramis { get; set; }

    }
}
