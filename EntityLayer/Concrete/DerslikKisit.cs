using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class DerslikKisit
    {
        [Key]
        public int DerslikKisitId { get; set; }
        public int SablonZamanId { get; set; }
        public int DerslikId { get; set; }
        public SablonZaman? SablonZaman { get; set; }
        public Derslik? Derslik { get; set; }
    }
}
