using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DOMAİN;

namespace OtelRezervasyonSistemi.DAL
{
    
        public class YoneticiDAL
        {
            private Baglanti baglanti = new Baglanti();

            public bool ValidateLogin(string kimlik, string sifre)
            {
                using (MySqlConnection conn = baglanti.baglantiGetir())
                {
                    string query = "SELECT COUNT(*) FROM Yonetici WHERE yonetici_kimlik = @kimlik AND yonetici_sifre = @sifre";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kimlik", kimlik);
                        cmd.Parameters.AddWithValue("@sifre", sifre);
                        long count = (long)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }

            public Yonetici GetById(int yoneticiId)
            {
                using (MySqlConnection conn = baglanti.baglantiGetir())
                {
                    string query = "SELECT * FROM Yonetici WHERE yonetici_id = @yoneticiId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@yoneticiId", yoneticiId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Yonetici(
                                    yoneticiId,
                                    reader["yonetici_isim"].ToString(),
                                    reader["yonetici_soyisim"].ToString(),
                                    reader["yonetici_kimlik"].ToString(),
                                    reader["yonetici_telefon"].ToString(),
                                    reader["yonetici_sifre"].ToString()
                                );
                            }
                        }
                    }
                }
                return null;
            }
       
        }
    
    }

 
