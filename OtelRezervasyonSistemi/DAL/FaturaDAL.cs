using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DOMAİN;

namespace OtelRezervasyonSistemi.DAL
{
    
        public class FaturaDAL
        {
            private Baglanti baglanti = new Baglanti();

            public void Insert(Fatura fatura)
            {
                using (MySqlConnection conn = baglanti.baglantiGetir())
                {
                    string query = "INSERT INTO Fatura (rezervasyon_id, olusturulma_tarih, toplam_tutar) VALUES (@rezervasyonId, @olusturulmaTarih, @toplamTutar)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rezervasyonId", fatura.RezervasyonId);
                        cmd.Parameters.AddWithValue("@olusturulmaTarih", fatura.OlusturulmaTarih);
                        cmd.Parameters.AddWithValue("@toplamTutar", fatura.ToplamTutar);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public Fatura GetById(int faturaId)
            {
                using (MySqlConnection conn = baglanti.baglantiGetir())
                {
                    string query = "SELECT * FROM Fatura WHERE fatura_id = @faturaId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@faturaId", faturaId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Fatura(
                                    faturaId,
                                    Convert.ToInt32(reader["rezervasyon_id"]),
                                    Convert.ToDateTime(reader["olusturulma_tarih"]),
                                    Convert.ToDecimal(reader["toplam_tutar"])
                                );
                            }
                        }
                    }
                }
                return null;
            }
        }
}
