using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DOMAİN;

namespace OtelRezervasyonSistemi.DAL
{

    using System;
    using System.Collections.Generic;
    using System.Data;
    using MySql.Data.MySqlClient;
    using OtelRezervasyonSistemi.DOMAİN;

    
        public class OdaDAL
        {
            private Baglanti baglanti = new Baglanti();

            public void Insert(Oda oda)
            {
                using (MySqlConnection conn = baglanti.baglantiGetir())
                {
                    if (conn == null) return; // Bağlantı başarısızsa çık

                    string query = "INSERT INTO Oda (oda_isim, oda_fiyat, oda_durum, oda_tip) VALUES (@odaIsim, @odaFiyat, @odaDurum, @odaTip)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@odaIsim", oda.OdaIsim);
                        cmd.Parameters.AddWithValue("@odaFiyat", oda.OdaFiyat);
                        cmd.Parameters.AddWithValue("@odaDurum", oda.OdaDurum);
                        cmd.Parameters.AddWithValue("@odaTip", oda.OdaTip);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public List<Oda> GetAvailableRooms()
            {
                List<Oda> odalar = new List<Oda>();
                using (MySqlConnection conn = baglanti.baglantiGetir())
                {
                    if (conn == null) return odalar; // Bağlantı başarısızsa boş liste döndür

                    string query = "SELECT * FROM Oda WHERE oda_durum = 'Müsait'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                odalar.Add(new Oda(
                                    Convert.ToInt32(reader["oda_id"]),
                                    reader["oda_isim"].ToString(),
                                    Convert.ToDecimal(reader["oda_fiyat"]),
                                    reader["oda_durum"].ToString(),
                                    reader["oda_tip"].ToString()
                                ));
                            }
                        }
                    }
                }
                return odalar;
            }

        public Oda IdyeGoreGetir(int oda_id)
        {
            using (MySqlConnection conn = baglanti.baglantiGetir())
            {
                if (conn == null) return null; // Bağlantı başarısızsa null döndür

                string query = "SELECT * FROM Oda WHERE oda_id = @odaId"; // Tablo adı "Oda" olmalı
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@odaId", oda_id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Oda(
                                Convert.ToInt32(reader["oda_id"]),
                                reader["oda_isim"].ToString(),
                                Convert.ToDecimal(reader["oda_fiyat"]),
                                reader["oda_durum"].ToString(),
                                reader["oda_tip"].ToString()
                            );
                        }
                    }
                }
                return null; // Oda bulunamazsa null döndür
            }
        }


        public void IdyeGoreGetir(DataGridView dgv)
        {
            using (MySqlConnection conn = baglanti.baglantiGetir())
            {
                if (conn == null) return;

                string query = "SELECT * FROM Oda";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
        }


        public void Update(Oda oda)
        {
            using (MySqlConnection conn = baglanti.baglantiGetir())
            {
                if (conn == null) return;

                string query = "UPDATE Oda SET oda_isim = @odaIsim, oda_fiyat = @odaFiyat, oda_durum = @odaDurum, oda_tip = @odaTip WHERE oda_id = @odaId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@odaId", oda.OdaId);
                    cmd.Parameters.AddWithValue("@odaIsim", oda.OdaIsim);
                    cmd.Parameters.AddWithValue("@odaFiyat", oda.OdaFiyat);
                    cmd.Parameters.AddWithValue("@odaDurum", oda.OdaDurum);
                    cmd.Parameters.AddWithValue("@odaTip", oda.OdaTip);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int odaId)
        {
            using (MySqlConnection conn = baglanti.baglantiGetir())
            {
                if (conn == null) return;

                string query = "DELETE FROM Oda WHERE oda_id = @odaId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@odaId", odaId);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public List<int> GetOdaIds()
        {
            List<int> odaIds = new List<int>();
            using (MySqlConnection conn = baglanti.baglantiGetir())
            {
                string query = "SELECT oda_id FROM Oda"; // Oda tablosundaki oda_id'leri al
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            odaIds.Add(reader.GetInt32("oda_id")); // oda_id'yi listeye ekle
                        }
                    }
                }
            }
            return odaIds;
        }





    }
    
}

