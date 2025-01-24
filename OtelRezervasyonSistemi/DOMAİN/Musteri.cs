using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.DOMAİN
{
    public class Musteri
    {
        public int MusteriId { get; set; }

        public string MusteriIsim { get; set; }

        public string MusteriSoyisim { get; set; }

        public string MusteriKimlik { get; set; }

        public string MusteriTelefon { get; set; }

        public Musteri(int musteriId, string musteriIsim, string musteriSoyisim, string musteriKimlik, string musteriTelefon)
        {
            MusteriId = musteriId;
            MusteriIsim = musteriIsim;
            MusteriSoyisim = musteriSoyisim;
            MusteriKimlik = musteriKimlik;
            MusteriTelefon = musteriTelefon;
        }
    }
}
