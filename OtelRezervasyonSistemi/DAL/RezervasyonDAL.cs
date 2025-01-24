using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DOMAİN;

namespace OtelRezervasyonSistemi.DAL
{

    public class RezervasyonDAL
    {       

        private Baglanti baglanti = new Baglanti();


        public void Insert(Rezervasyon rezervasyon)
        {
            using (MySqlConnection conn = baglanti.baglantiGetir())
            {
                string query = "INSERT INTO Rezervasyon (giris_tarih, cikis_tarih, rezervasyon_durum, oda_id, fatura_id, musteri_id) VALUES (@girisTarih, @cikisTarih, @rezervasyonDurum, @odaId, @faturaId, @musteriId)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@girisTarih", rezervasyon.GirisTarih);
                    cmd.Parameters.AddWithValue("@cikisTarih", rezervasyon.CikisTarih);
                    cmd.Parameters.AddWithValue("@rezervasyonDurum", rezervasyon.RezervasyonDurum);
                    cmd.Parameters.AddWithValue("@odaId", rezervasyon.OdaId);
                    cmd.Parameters.AddWithValue("@faturaId", rezervasyon.FaturaId);
                   // cmd.Parameters.AddWithValue("@musteriId", rezervasyon.MusteriId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool Sil(int rezervasyonId)
        {
            try
            {
                using (MySqlConnection conn = baglanti.baglantiGetir())
                {
                    string query = "DELETE FROM Rezervasyon WHERE rezervasyon_id = @rezervasyonId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rezervasyonId", rezervasyonId);
                        int etkilenenSatir = cmd.ExecuteNonQuery();
                        return etkilenenSatir > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Rezervasyon silinirken bir hata oluştu: " + ex.Message);
            }
        }



        //public bool Sil(int musteriKimlikNo)
        //{
        //    try
        //    {
        //        using (MySqlConnection conn = baglanti.baglantiGetir())
        //        {


        //            string query = "DELETE FROM Musteri WHERE musteri_kimlik = @musteri_kimlik";
        //            using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@musteri_kimlik", musteriKimlikNo);
        //                int etkilenenSatir = cmd.ExecuteNonQuery();
        //                return etkilenenSatir > 0;
        //            }
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw new Exception("Müşteri silinirken bir hata oluştu: " + ex.Message);
        //    }
        //}



        public bool KimlikNoVarMi(string kimlikNo)
        {
            using (MySqlConnection conn = baglanti.baglantiGetir())
            {
                string query = "SELECT COUNT(1) FROM Musteri WHERE musteri_kimlik = @kimlikNo";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kimlikNo", kimlikNo);
                    int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                    return sayi > 0;
                }
            }
        }


        public List<Rezervasyon> GetActiveReservations()
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            using (MySqlConnection conn = baglanti.baglantiGetir())
            {
                string query = "SELECT * FROM Rezervasyon WHERE rezervasyon_durum = 'Aktif'";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rezervasyonlar.Add(new Rezervasyon(
                                Convert.ToInt32(reader["rezervasyon_id"]),
                                Convert.ToDateTime(reader["giris_tarih"]),
                                Convert.ToDateTime(reader["cikis_tarih"]),
                                reader["rezervasyon_durum"].ToString(),
                                Convert.ToInt32(reader["oda_id"]),
                                Convert.ToInt32(reader["fatura_id"]),
                                Convert.ToInt32(reader["musteri_id"])
                            ));
                        }
                    }
                }
            }
            return rezervasyonlar;

            //public bool Sil(int musteriKimlikNo)
            //{
            //    using (MySqlConnection conn = baglanti.baglantiGetir())
            //    {
            //        string query = "DELETE FROM Rezervasyon WHERE musteri_kimlik = @musteri_kimlik";
            //        using (MySqlCommand cmd = new MySqlCommand(query, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@musteri_kimlik", musteriKimlikNo);
            //            int etkilenenSatir = cmd.ExecuteNonQuery();
            //            return etkilenenSatir > 0; // Eğer etkilenen satır sayısı 0'dan büyükse silme başarılıdır
            //        }
            //    }
            //}
        }

       






    }
}

