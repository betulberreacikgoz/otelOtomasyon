using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.DOMAİN;

namespace OtelRezervasyonSistemi.SERVİCE
{
  
        public class YoneticiService
        {
            private readonly YoneticiDAL _yoneticiDAL;
           // private readonly YoneticiDAL _rezervasyonDAL;

            public YoneticiService()
            {
                _yoneticiDAL = new YoneticiDAL();
            }

            public bool GirisYap(string kimlik, string sifre)
            {
                if (string.IsNullOrEmpty(kimlik) || string.IsNullOrEmpty(sifre))
                {
                    throw new ArgumentException("Kimlik ve şifre alanları boş olamaz.");
                }

                return _yoneticiDAL.ValidateLogin(kimlik, sifre);
            }

            public Yonetici YoneticiGetir(int yoneticiId)
            {
                return _yoneticiDAL.GetById(yoneticiId);
            }
       
        }

        //public bool RezervasyonSil(int musteriKimlikNo)
        //{
        //    if (musteriKimlikNo <= 0)
        //    {
        //        throw new ArgumentException("Geçerli bir müşteri kimlik numarası giriniz.");
        //    }

        //    // Müşterinin rezervasyonunun var olup olmadığını kontrol et
        //    if ( !_rezervasyonDAL.KimlikNoVarMi(musteriKimlikNo.ToString()))
        //    {
        //        throw new KeyNotFoundException($"Kimlik No: {musteriKimlikNo} olan müşteri bulunamadı.");
        //    }

        //    try
        //    {
        //        return _rezervasyonDAL.Sil(musteriKimlikNo);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"ID: {musteriKimlikNo} olan rezervasyon silinirken bir hata oluştu.", ex);
        //    }
        //}
    }
    

