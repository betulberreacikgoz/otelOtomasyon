using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.DOMAİN;

namespace OtelRezervasyonSistemi.SERVİCE
{
    public class MusteriService
    {
        private readonly MusteriDAL _musteriDAL;

        public MusteriService()
        {
            _musteriDAL = new MusteriDAL();
        }

        public Musteri MusteriEkle(string isim, string soyisim, string kimlik, string telefon)
        {
            // Doğrulama
            if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim) ||
                string.IsNullOrEmpty(kimlik) || string.IsNullOrEmpty(telefon))
            {
                throw new ArgumentException("Tüm alanlar doldurulmalıdır.");
            }

            if (kimlik.Length != 11 || !kimlik.All(char.IsDigit))
            {
                throw new ArgumentException("Kimlik numarası 11 haneli ve sadece rakamlardan oluşmalıdır.");
            }

            if (_musteriDAL.KimlikNoVarMi(kimlik))
            {
                throw new InvalidOperationException("Bu kimlik numarası ile kayıtlı müşteri zaten var.");
            }

            // Telefon numarası doğrulama
            if (!System.Text.RegularExpressions.Regex.IsMatch(telefon, @"^\d{10,11}$"))
            {
                throw new ArgumentException("Geçerli bir telefon numarası giriniz (10-11 haneli).");
            }

            var musteri = new Musteri(
                0,
                isim.Trim(),
                soyisim.Trim(),
                kimlik,
                telefon
            );

            try
            {
                _musteriDAL.Ekle(musteri);
                return musteri;
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri eklenirken bir hata oluştu.", ex);
            }
        }

        public bool MusteriSil(int musteriId)
        {
            if (musteriId <= 0)
            {
                throw new ArgumentException("Geçerli bir müşteri ID'si giriniz.");
            }

            if (!_musteriDAL.MusteriVarMi(musteriId))
            {
                throw new KeyNotFoundException($"ID: {musteriId} olan müşteri bulunamadı.");
            }

            try
            {
                return _musteriDAL.Sil(musteriId);
            }
            catch (Exception ex)
            {
                throw new Exception($"ID: {musteriId} olan müşteri silinirken bir hata oluştu.", ex);
            }
        }

        public Musteri MusteriGetir(int musteriId)
        {
            if (musteriId <= 0)
            {
                throw new ArgumentException("Geçerli bir müşteri ID'si giriniz.");
            }

            var musteri = _musteriDAL.IdyeGoreGetir(musteriId);
            if (musteri == null)
            {
                throw new KeyNotFoundException($"ID: {musteriId} olan müşteri bulunamadı.");
            }

            return musteri;
        }
        public bool MusteriGuncelle(int musteriId, string isim, string soyisim, string tcKimlik, string telefon)
        {
            // Güncelleme işlemi için gerekli SQL sorgusunu yazın

            // Doğrulama
            if (musteriId <= 0)
            {
                throw new ArgumentException("Geçerli bir müşteri ID'si giriniz.");
            }

            if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim) ||
                string.IsNullOrEmpty(tcKimlik) || string.IsNullOrEmpty(telefon))
            {
                throw new ArgumentException("Tüm alanlar doldurulmalıdır.");
            }

            if (tcKimlik.Length != 11 || !tcKimlik.All(char.IsDigit))
            {
                throw new ArgumentException("Kimlik numarası 11 haneli ve sadece rakamlardan oluşmalıdır.");
            }

            // Telefon numarası doğrulama
            if (!System.Text.RegularExpressions.Regex.IsMatch(telefon, @"^\d{10,11}$"))
            {
                throw new ArgumentException("Geçerli bir telefon numarası giriniz (10-11 haneli).");
            }

            try
            {
                return _musteriDAL.Guncelle(musteriId, isim.Trim(), soyisim.Trim(), tcKimlik, telefon);
            }
            catch (Exception ex)
            {
                throw new Exception($"ID: {musteriId} olan müşteri güncellenirken bir hata oluştu.", ex);
            }
        }
    }
}



