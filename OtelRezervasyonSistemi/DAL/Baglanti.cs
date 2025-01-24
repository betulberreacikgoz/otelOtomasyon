using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OtelRezervasyonSistemi.DAL
{
    public class Baglanti
    {

        public MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330058; User=25_132330058; Password=deneme123");
            try
            {
                baglanti.Open();
                Console.WriteLine("Bağlantı Başarılı.");
                return baglanti;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bağlantı Kurulamadı." + ex.Message);
                return null;
            }

           
        }
    }
}