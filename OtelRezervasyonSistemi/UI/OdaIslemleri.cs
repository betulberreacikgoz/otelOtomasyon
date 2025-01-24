using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.SERVİCE;

namespace OtelRezervasyonSistemi.UI
{
    public partial class OdaIslemleri : Form
    {
        public OdaDAL odaDAL;
        public OdaService odaService;
        //public OdaIslemleri()
        //{
        //    InitializeComponent();
        //    odaDAL = new OdaDAL();
        //}


        public OdaIslemleri()
        {
            InitializeComponent();
            odaService = new OdaService(); // OdaService nesnesini oluştur
        }




        private void OdaIslemleri_Load(object sender, EventArgs e)
        {
            odaService.IdyeGoreGetir(dataGridViewoda);
            dataGridViewoda.SelectionChanged += dataGridViewoda_SelectionChanged; // Olayı bağla
        }

        private void odasilbtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewoda.SelectedRows.Count > 0)
            {
                // Seçili satırdan oda ID'sini al
                int odaId = Convert.ToInt32(dataGridViewoda.SelectedRows[0].Cells["oda_id"].Value);

                // Silme işlemi için onay iste
                var result = MessageBox.Show("Seçili odayı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        odaService.OdaSil(odaId); // OdaService üzerinden sil
                        MessageBox.Show("Oda başarıyla silindi.");
                        odaService.IdyeGoreGetir(dataGridViewoda); // Oda listesini güncelle

                        // TextBox'ları boşalt
                        odaisimtxt.Clear();
                        odafiyattxt.Clear();
                        odatiptxt.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir oda seçin.");
            }
        }

        private void odakaydetbtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    odaService.OdaEkle(
            //        odaisimtxt.Text,
            //        odafiyattxt.Text,
            //        odatiptxt.Text

            //    );

            //    MessageBox.Show("Oda başarıyla eklendi.", "Başarılı.",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    // Textboxları temizle
            //    odaisimtxt.Clear();
            //    odafiyattxt.Clear();
            //    odatiptxt.Clear();


            //    // GridView'i yenile
            //    odaDAL.IdyeGoreGetir(dataGridViewoda);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}











            //string isim = odaisimtxt.Text.Trim(); // Kullanıcıdan alınan ismi temizle
            //string fiyatText = odafiyattxt.Text.Trim(); // Fiyatı temizle
            //decimal fiyat;

            //// Fiyatın boş olup olmadığını kontrol et
            //if (string.IsNullOrWhiteSpace(fiyatText))
            //{
            //    MessageBox.Show("Fiyat alanı boş olamaz.");
            //    return; // Hatalı giriş varsa işlemi durdur
            //}

            //// Fiyatın geçerli bir decimal olup olmadığını kontrol et
            //if (!decimal.TryParse(fiyatText, out fiyat))
            //{
            //    MessageBox.Show("Lütfen geçerli bir fiyat girin. Örneğin: 100.00");
            //    return; // Hatalı giriş varsa işlemi durdur
            //}

            //string tip = odatiptxt.Text.Trim(); // Oda tipini temizle

            //try
            //{
            //    odaService.OdaEkle(isim, fiyat, tip);
            //    MessageBox.Show("Oda başarıyla eklendi.");
            //    IdyeGoreGetir(dataGridViewoda); // Oda listesini güncelle
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            //}






            string isim = odaisimtxt.Text.Trim(); // Kullanıcıdan alınan ismi temizle
            string fiyatText = odafiyattxt.Text.Trim(); // Fiyatı temizle
            decimal fiyat;

            // Fiyatın boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(fiyatText))
            {
                MessageBox.Show("Fiyat alanı boş olamaz.");
                return; // Hatalı giriş varsa işlemi durdur
            }

            // Fiyatın geçerli bir decimal olup olmadığını kontrol et
            if (!decimal.TryParse(fiyatText, out fiyat))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin. Örneğin: 100.00");
                return; // Hatalı giriş varsa işlemi durdur
            }

            string tip = odatiptxt.Text.Trim(); // Oda tipini temizle

            try
            {
                odaService.OdaEkle(isim, fiyat, tip);
                MessageBox.Show("Oda başarıyla eklendi.");
                odaService.IdyeGoreGetir(dataGridViewoda); // Oda listesini güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void odaguncellebtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewoda.SelectedRows.Count > 0)
            {
                // Seçili satırdan oda ID'sini al
                int odaId = Convert.ToInt32(dataGridViewoda.SelectedRows[0].Cells["oda_id"].Value);
                string isim = odaisimtxt.Text.Trim();
                string fiyatText = odafiyattxt.Text.Trim();
                decimal fiyat;

                // Fiyatın boş olup olmadığını kontrol et
                if (string.IsNullOrWhiteSpace(fiyatText))
                {
                    MessageBox.Show("Fiyat alanı boş olamaz.");
                    return; // Hatalı giriş varsa işlemi durdur
                }

                // Fiyatın geçerli bir decimal olup olmadığını kontrol et
                if (!decimal.TryParse(fiyatText, out fiyat))
                {
                    MessageBox.Show("Lütfen geçerli bir fiyat girin. Örneğin: 100.00");
                    return; // Hatalı giriş varsa işlemi durdur
                }

                string durum = "Müsait"; // Durumu varsayılan olarak "Müsait" ayarlayabilirsiniz
                string tip = odatiptxt.Text.Trim();

                try
                {
                    odaService.OdaGuncelle(odaId, isim, fiyat, durum, tip);
                    MessageBox.Show("Oda başarıyla güncellendi.");
                    odaService.IdyeGoreGetir(dataGridViewoda); // Oda listesini güncelle

                    odaisimtxt.Clear();
                    odafiyattxt.Clear();
                    odatiptxt.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir oda seçin.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridViewoda.SelectionChanged += dataGridViewoda_SelectionChanged;
        }
        private void dataGridViewoda_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewoda.SelectedRows.Count > 0)
            {
                // Seçili satırdan değerleri al
                DataGridViewRow selectedRow = dataGridViewoda.SelectedRows[0];
                odaisimtxt.Text = selectedRow.Cells["oda_isim"].Value.ToString();
                odafiyattxt.Text = selectedRow.Cells["oda_fiyat"].Value.ToString();
                odatiptxt.Text = selectedRow.Cells["oda_tip"].Value.ToString();
                // Durum gibi diğer alanları da doldurabilirsiniz
            }
        }

        private AnaSayfa anaSayfa;

        public OdaIslemleri(AnaSayfa form)
        {
            InitializeComponent();
            anaSayfa = anaSayfa; // Ana formu al
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();

            // Mevcut formu kapat
            this.Hide();

            // Ana formu göster
            anaForm.Show();
        }
    }
    
}
