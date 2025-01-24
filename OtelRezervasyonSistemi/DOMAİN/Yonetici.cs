using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.DOMAİN
{
    public class Yonetici
    {
        public int YoneticiId { get; set; }

        public string YoneticiIsim { get; set; }

        public string YoneticiSoyisim { get; set; }

        public string YoneticiKimlik { get; set; }

        public string YoneticiTelefon { get; set; }

        public string YoneticiSifre { get; set; }

        public Yonetici(int yoneticiId, string yoneticiIsim, string yoneticiSoyisim, string yoneticiKimlik, string yoneticiTelefon, string yoneticiSifre)
        {
            YoneticiId = yoneticiId;
            YoneticiIsim = yoneticiIsim;
            YoneticiSoyisim = yoneticiSoyisim;
            YoneticiKimlik = yoneticiKimlik;
            YoneticiTelefon = yoneticiTelefon;
            YoneticiSifre = yoneticiSifre;
        }
    }
}
