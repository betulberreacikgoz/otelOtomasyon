using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.DOMAİN
{
    
        public class Oda
        {
            public int OdaId { get; set; }

            public string OdaIsim { get; set; }

            public decimal OdaFiyat { get; set; }

            public string OdaDurum { get; set; }

            public string OdaTip { get; set; }

        public Oda(int odaId, string odaIsim, decimal odaFiyat, string odaDurum, string odaTip)
        {
            OdaId = odaId;
            OdaIsim = odaIsim;
            OdaFiyat = odaFiyat;
            OdaDurum = odaDurum;
            OdaTip = odaTip;
        }
    }

    }

