using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbkBank.Abstract
{
    public abstract class Para 
   { 
    public string Ad { get; set; }

    public double Miktar { get; set; }

    public double Yukseklik { get; set; } = 0.25;

    public abstract double Hacim();

    public abstract double FazladanHacimEkle(double hacim);

    public abstract double MinHacimHesapla(double hacim);
   }
}
