using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class DerslikDersKisit
    {
        [Key]
        public int DerslikDersKisitId { get; set; }
        public int DerslikId { get; set; }
        public int DersId { get; set; }

        public Derslik? Derslik { get; set; }
        public Ders? Ders { get; set; }
    }
}
