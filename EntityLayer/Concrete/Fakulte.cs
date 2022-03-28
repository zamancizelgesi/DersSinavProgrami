using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Fakulte
    {
        [Key]
        public int FakulteId { get; set; }
        public string? FakulteAdi { get; set; }
        public ICollection<Bolum>? Bolums{ get; set; }
    }
}
