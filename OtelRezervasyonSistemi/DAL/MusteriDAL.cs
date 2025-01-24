using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DOMAİN;

namespace OtelRezervasyonSistemi.DAL
{

    public class MusteriDAL
    {
        private Baglanti _baglanti = new Baglanti();
        private MySqlConnection _connection;
        public MusteriDAL()
        {
            _baglanti = new Baglanti();
            _connection = _baglanti.baglantiGetir();
        }

        public void Ekle(Musteri musteri)
        {
            try
            {
                if (_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open(); // Bağlantıyı açık hale getiriyoruz
                }

                string query = @"INSERT INTO Musteri 
                       (musteri_isim, musteri_soyisim, musteri_kimlik, musteri_telefon) 
                       VALUES 
                       (@musteriIsim, @musteriSoyisim, @musteriKimlik, @musteriTelefon);
                       SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@musteriIsim", musteri.MusteriIsim);
                    cmd.Parameters.AddWithValue("@musteriSoyisim", musteri.MusteriSoyisim);
                    cmd.Parameters.AddWithValue("@musteriKimlik", musteri.MusteriKimlik);
                    cmd.Parameters.AddWithValue("@musteriTelefon", musteri.MusteriTelefon);

                    // var eklenenId = Convert.ToInt32(cmd.ExecuteScalar());
                    // musteri.MusteriId = eklenenId;
                    var eklenenId = cmd.ExecuteScalar();
                    if (eklenenId == null)
                    {
                        throw new Exception("Eklenen kaydın ID'si alınamadı.");
                    }
                    musteri.MusteriId = Convert.ToInt32(eklenenId);

                }
            }
            /* catch (Exception ex)
             {
                 throw new Exception("Müşteri eklenirken bir hata oluştu: " + ex.Message);
             }*/
            catch (Exception ex)
            {
                throw new Exception("Müşteri eklenirken bir hata oluştu: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
            }

        }

        public bool Sil(int musteriId)
        {
            try
            {
                if (_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open(); // Bağlantıyı açık hale getiriyoruz
                }

                string query = "DELETE FROM Musteri WHERE musteri_id = @musteriId";
                using (MySqlCommand cmd = new MySqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@musteriId", musteriId);
                    int etkilenenSatir = cmd.ExecuteNonQuery();
                    return etkilenenSatir > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Müşteri silinirken bir hata oluştu: " + ex.Message);
            }
        }
        public List<Musteri> TumMusterileriGetir()
        {
            List<Musteri> musteriler = new List<Musteri>();
            try
            {
                string query = "SELECT * FROM musteri";
                using (MySqlCommand cmd = new MySqlCommand(query, _connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            musteriler.Add(new Musteri(
                                Convert.ToInt32(row["musteri_id"]),
                                row["musteri_isim"].ToString(),
                                row["musteri_soyisim"].ToString(),
                                row["musteri_kimlik"].ToString(),
                                row["musteri_telefon"].ToString()
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteriler getirilirken bir hata oluştu: " + ex.Message);
            }
            return musteriler;
        }

        public Musteri IdyeGoreGetir(int musteriId)
        {
            using (MySqlConnection conn = _baglanti.baglantiGetir())
            {
                string query = "SELECT * FROM Musteri WHERE musteri_id = @musteriId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@musteriId", musteriId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Musteri(
                                musteriId,
                                reader["musteri_isim"].ToString(),
                                reader["musteri_soyisim"].ToString(),
                                reader["musteri_kimlik"].ToString(),
                                reader["musteri_telefon"].ToString()
                            );
                        }
                    }
                }
                return null;
            }
        }

        public bool MusteriVarMi(int musteriId)
        {
            using (MySqlConnection conn = _baglanti.baglantiGetir())
            {
                string query = "SELECT COUNT(1) FROM Musteri WHERE musteri_id = @musteriId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@musteriId", musteriId);
                    long sayi = Convert.ToInt64(cmd.ExecuteScalar());
                    return sayi > 0;
                }
            }
        }

        public bool KimlikNoVarMi(string kimlikNo)
        {
            using (MySqlConnection conn = _baglanti.baglantiGetir())
            {
                string query = "SELECT COUNT(1) FROM Musteri WHERE musteri_kimlik = @kimlikNo";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kimlikNo", kimlikNo);
                    double sayi = Convert.ToDouble(cmd.ExecuteScalar());
                    return sayi > 0;
                }
            }
        }
        public bool Guncelle(int musteriId, string isim, string soyisim, string tcKimlik, string telefon)
        {
            using (MySqlConnection conn = new Baglanti().baglantiGetir())
            {
                if (conn == null) return false;

                string query = "UPDATE Musteri SET musteri_isim = @isim, musteri_soyisim = @soyisim, musteri_kimlik = @tcKimlik, musteri_telefon = @telefon WHERE musteri_id = @musteriId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@isim", isim);
                cmd.Parameters.AddWithValue("@soyisim", soyisim);
                cmd.Parameters.AddWithValue("@tcKimlik", tcKimlik);
                cmd.Parameters.AddWithValue("@telefon", telefon);
                cmd.Parameters.AddWithValue("@musteriId", musteriId);

                int result = cmd.ExecuteNonQuery();
                return result > 0; // Eğer güncelleme başarılıysa true döner
            }
        }
        
        
        private Baglanti baglanti = new Baglanti();
        public List<string> GetMusteriTcList()
        {
            List<string> musteriTcList = new List<string>();
            using (MySqlConnection conn = baglanti.baglantiGetir())
            {
                string query = "SELECT musteri_kimlik FROM Musteri"; // Müşteri tablosundaki musteri_tc'leri al
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            musteriTcList.Add(reader.GetString("musteri_kimlik")); // musteri_tc'yi listeye ekle
                        }
                    }
                }
            }
            return musteriTcList;
        }
    }
}
    

