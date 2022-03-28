using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context :DbContext
    {
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-F4VOIT7T;Database=Sinav_DersProgrami; integrated security=true;");
        }
        public  DbSet<Akademisyen> Akademisyens { get; set; } = null!;
        public  DbSet<Bolum> Bolums { get; set; } = null!;
        public  DbSet<Ders> Derses { get; set; } = null!;
        public  DbSet<DersProgrami> DersProgramis { get; set; } = null!;
        public  DbSet<Derslik> Dersliks { get; set; } = null!;
        public  DbSet<Donem> Donems { get; set; } = null!;
        public  DbSet<Fakulte> Fakultes { get; set; } = null!;
        public  DbSet<Ogrenci> Ogrencis { get; set; } = null!;
        public DbSet<SablonZaman> SablonZamans { get; set; } = null!;
        public DbSet<AkademisyenKisit> AkademisyenKisits { get; set; } = null!;
        public DbSet<BolumKisit> BolumKisits { get; set; } = null!;
        public DbSet<DerslikKisit> DerslikKisits{ get; set; } = null!;
        public DbSet<DerslikDersKisit> DerslikDersKisits { get; set; } = null!;
        public DbSet<SinavProgrami> SinavProgramis { get; set; } = null!;


    }
}
