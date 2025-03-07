﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.DOMAİN;

namespace OtelRezervasyonSistemi.SERVİCE
{
   
        public class FaturaService
        {
            private readonly FaturaDAL _faturaDAL;

            public FaturaService()
            {
                _faturaDAL = new FaturaDAL();
            }

            public void FaturaOlustur(int rezervasyonId, decimal toplamTutar)
            {
                Fatura fatura = new Fatura(
                    0, 
                    rezervasyonId,
                    DateTime.Now,
                    toplamTutar
                );
                _faturaDAL.Insert(fatura);
            }

            public Fatura FaturaGetir(int faturaId)
            {
                return _faturaDAL.GetById(faturaId);
            }
        }

    }

