﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.DOMAİN;

namespace OtelRezervasyonSistemi.SERVİCE
{
    
        public class RezervasyonService
        {
            private readonly RezervasyonDAL _rezervasyonDAL;
            private readonly OdaService _odaService;
            private readonly FaturaService _faturaService;

            public RezervasyonService()
            {
                _rezervasyonDAL = new RezervasyonDAL();
                _odaService = new OdaService();
                _faturaService = new FaturaService();
            }

            public void RezervasyonOlustur(DateTime girisTarihi, DateTime cikisTarihi,
                int odaId, int musteriId , double musteri_kimlik)
            {
                // Validation
                if (girisTarihi >= cikisTarihi)
                {
                    throw new ArgumentException("Giriş tarihi çıkış tarihinden önce olmalıdır.");
                }

                if (girisTarihi.Date < DateTime.Now.Date)
                {
                    throw new ArgumentException("Giriş tarihi geçmiş bir tarih olamaz.");
                }

                // Müsait odaları kontrol et
                List<Oda> musaitOdalar = _odaService.MusaitOdalariGetir();
                if (!musaitOdalar.Exists(o => o.OdaId == odaId))
                {
                    throw new ArgumentException("Seçilen oda müsait değil.");
                }

                // Kalış süresini hesapla
                int gunSayisi = (cikisTarihi - girisTarihi).Days;

                // Seçilen odayı bul ve toplam tutarı hesapla
                Oda secilenOda = musaitOdalar.Find(o => o.OdaId == odaId);
                decimal toplamTutar = secilenOda.OdaFiyat * gunSayisi;

                // Önce fatura oluştur
                _faturaService.FaturaOlustur(0, toplamTutar);

          

            var rezervasyon = new Rezervasyon
            {
                GirisTarih = girisTarihi,
                CikisTarih = cikisTarihi,
                RezervasyonDurum = "Aktif",
                OdaId = odaId,
                MusteriId = musteriId,
                MusteriKimlik = musteri_kimlik,
                //ToplamFiyat = toplamTutar
            };


            _rezervasyonDAL.Insert(rezervasyon);
            }
        public bool RezervasyonSil(double musteriKimlikNo)
        {
            if (musteriKimlikNo <= 0)
            {
                throw new ArgumentException("Geçerli bir müşteri Kimlik No'su giriniz.");
            }

            if (!_rezervasyonDAL.KimlikNoVarMi(musteriKimlikNo.ToString()))
            {
                throw new KeyNotFoundException($"Kimlik No: {musteriKimlikNo} olan müşteri bulunamadı.");
            }

            try
            {
                return _rezervasyonDAL.Sil(musteriKimlikNo);
            }
            catch (Exception ex)
            {
                throw new Exception($"ID: {musteriKimlikNo} olan müşteri silinirken bir hata oluştu.", ex);
            }
        }


        public List<Rezervasyon> AktifRezervasyonlariGetir()
            {
                return _rezervasyonDAL.GetActiveReservations();
            }
        }
}
