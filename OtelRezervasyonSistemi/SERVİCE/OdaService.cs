﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.DOMAİN;

namespace OtelRezervasyonSistemi.SERVİCE
{
   
    
        public class OdaService
        {
            private readonly OdaDAL _odaDAL;

            public OdaService()
            {
                _odaDAL = new OdaDAL();
            }

        public void OdaEkle(string isim, decimal fiyat, string tip)
        {
           
            Oda oda = new Oda(
                0, // ID will be generated by database
                isim,
                fiyat,
                "Müsait", // Yeni oda varsayılan olarak müsait
                tip
            );
            _odaDAL.Insert(oda);
        }

        public List<Oda> MusaitOdalariGetir()
        {
            return _odaDAL.GetAvailableRooms();
        }

      

       
        /// <summary>
        /// Oda bilgilerini DataGridView'e yükler.
        /// </summary>
        /// <param name="dgv">Verilerin yükleneceği DataGridView.</param>
        public void IdyeGoreGetir(DataGridView dgv)
        {
            _odaDAL.IdyeGoreGetir(dgv);
        }

        public void OdaGuncelle(int odaId, string isim, decimal fiyat, string durum, string tip)
        {
            Oda oda = new Oda(
                odaId,
                isim,
                fiyat,
                durum,
                tip
            );
            _odaDAL.Update(oda);
        }

        public void OdaSil(int odaId)
        {
            _odaDAL.Delete(odaId); 
        }
    }
}
