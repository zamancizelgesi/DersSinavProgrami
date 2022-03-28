using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Derslik
    {
        [Key]
        public int DerslikId { get; set; }
        public string? DerslikBina { get; set; }
        public string? DerslikKodu { get; set; }
        public string? DerslikTipi { get; set; }
        public int? Kapasite { get; set; }
        public string? KullanimDurumu { get; set; }
        public int? SinavKapasitesi { get; set; }
        public ICollection<DerslikDersKisit>? DerslikDersKisits { get; set; }
        public ICollection<DerslikKisit>? DerslikKisits { get; set; }
        public ICollection<DersProgrami>? DersProgramis { get; set; }
        public ICollection<SinavProgrami>? SinavProgramis { get; set; }

    }
}
