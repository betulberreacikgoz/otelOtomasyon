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

        
    }
    

