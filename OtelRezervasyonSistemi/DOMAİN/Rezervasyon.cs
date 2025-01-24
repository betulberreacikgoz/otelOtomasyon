using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.DOMAİN
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public DateTime GirisTarih { get; set; }

        public DateTime CikisTarih { get; set; }        

        public string RezervasyonDurum { get; set; }

        public int OdaId { get; set; }

        ///public int FaturaId { get; set; } 

        public int MusteriId { get; set; }

        public double MusteriKimlik {  get; set; }

         public Rezervasyon()
         {
         }

        public Rezervasyon(int rezervasyonId, DateTime girisTarih, DateTime cikisTarih, string rezervasyonDurum, double musteriKimlik, int odaId, int faturaId, int musteriId)
        {
            RezervasyonId = rezervasyonId;
            GirisTarih = girisTarih;
            CikisTarih = cikisTarih;
            RezervasyonDurum = rezervasyonDurum;
            MusteriKimlik = musteriKimlik;
            OdaId = odaId;
           // FaturaId = faturaId;
            MusteriId = musteriId;
        }
    }

}

