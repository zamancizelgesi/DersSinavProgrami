using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AkademisyenKisit
    {
        [Key]
        public int? AkademisyenKisitId { get; set; }
        public int? SablonZamanId{ get; set; }
        public int? AkademisyenId { get; set; }
        public SablonZaman? SablonZaman { get; set; }
        public Akademisyen? Akademisyen { get; set; }
    

    }
}
