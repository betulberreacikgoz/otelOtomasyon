using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.DOMAİN
{
    public class Fatura
    {
        public int FaturaId { get; set; }

        public int RezervasyonId { get; set; }

        public DateTime OlusturulmaTarih { get; set; }

        public decimal ToplamTutar { get; set; }

        public Fatura(int faturaId, int rezervasyonId, DateTime olusturulmaTarih, decimal toplamTutar)
        {
            FaturaId = faturaId;
            RezervasyonId = rezervasyonId;
            OlusturulmaTarih = olusturulmaTarih;
            ToplamTutar = toplamTutar;
        }
    }
}
