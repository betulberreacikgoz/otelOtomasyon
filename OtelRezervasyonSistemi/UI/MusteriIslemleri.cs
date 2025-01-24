using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.SERVİCE;

namespace OtelRezervasyonSistemi.UI
{
    public partial class MusteriIslemleri : Form
    {
        private readonly MusteriService _musteriService;
        private readonly MusteriDAL _musteriDAL;

        public MusteriIslemleri()
        {
            InitializeComponent();
            _musteriService = new MusteriService();
            _musteriDAL = new MusteriDAL();
        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        private void GridDoldur()
        {
            try
            {
                // Bağlantıyı oluştur
                Baglanti baglanti = new Baglanti();
                using (MySqlConnection conn = baglanti.baglantiGetir())
                {
                    string query = "SELECT * FROM Musteri";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    musteriGridView.DataSource = dt;

                    // Kolon başlıklarını düzenle
                    musteriGridView.Columns["musteri_id"].HeaderText = "Müşteri ID";
                    musteriGridView.Columns["musteri_isim"].HeaderText = "İsim";
                    musteriGridView.Columns["musteri_soyisim"].HeaderText = "Soyisim";
                    musteriGridView.Columns["musteri_kimlik"].HeaderText = "TC Kimlik";
                    musteriGridView.Columns["musteri_telefon"].HeaderText = "Telefon";

                    // GridView özelliklerini ayarla
                    musteriGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    musteriGridView.AllowUserToAddRows = false;
                    musteriGridView.ReadOnly = true;
                    musteriGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void musteriTeltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void musteriIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void musteriIsimtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void musteriSoyisimtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void musteriTCtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void musteriGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = musteriGridView.Rows[e.RowIndex];

                // Seçilen satırın verilerini textboxlara doldur
                //musteriIDtxt.Text = row.Cells["musteri_id"].Value.ToString();
                musteriIsimtxt.Text = row.Cells["musteri_isim"].Value.ToString();
                musteriSoyisimtxt.Text = row.Cells["musteri_soyisim"].Value.ToString();
                musteriTCtxt.Text = row.Cells["musteri_kimlik"].Value.ToString();
                musteriTeltxt.Text = row.Cells["musteri_telefon"].Value.ToString();
            }
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _musteriService.MusteriEkle(
                    musteriIsimtxt.Text,
                    musteriSoyisimtxt.Text,
                    musteriTCtxt.Text,
                    musteriTeltxt.Text
                );

                MessageBox.Show("Müşteri başarıyla eklendi.", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Textboxları temizle
                //musteriIDtxt.Clear();
                musteriIsimtxt.Clear();
                musteriSoyisimtxt.Clear();
                musteriTCtxt.Clear();
                musteriTeltxt.Clear();

                // GridView'i yenile
                GridDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(musteriGridView.CurrentRow != null)
                {
                    int musteriid = Convert.ToInt32(musteriGridView.CurrentRow.Cells["musteri_id"].Value);
                    var silindimi= _musteriService.MusteriSil(musteriid);
                    if (silindimi)
                    {
                        MessageBox.Show("Müşteri silindi.");
                        //musteriIDtxt.Clear();
                        musteriIsimtxt.Clear();
                        musteriSoyisimtxt.Clear();
                        musteriTCtxt.Clear();
                        musteriTeltxt.Clear();
                        GridDoldur();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri silinemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen müşteri seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
          
                try
                {
                    if (musteriGridView.CurrentRow != null)
                    {
                        int musteriId = Convert.ToInt32(musteriGridView.CurrentRow.Cells["musteri_id"].Value);

                        // Müşteri bilgilerini güncelle
                        bool guncellendi = _musteriService.MusteriGuncelle(
                            musteriId,
                            musteriIsimtxt.Text,
                            musteriSoyisimtxt.Text,
                            musteriTCtxt.Text,
                            musteriTeltxt.Text
                        );

                        if (guncellendi)
                        {
                            MessageBox.Show("Müşteri başarıyla güncellendi.", "Başarılı",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            musteriIsimtxt.Clear();
                            musteriSoyisimtxt.Clear();
                            musteriTCtxt.Clear();
                            musteriTeltxt.Clear();

                            // GridView'i yenile
                            GridDoldur();
                        }
                        else
                        {
                            MessageBox.Show("Müşteri güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen güncellenecek bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        private AnaSayfa anaSayfa;

        public MusteriIslemleri(AnaSayfa form)
        {
            InitializeComponent();
            anaSayfa = anaSayfa;
        }

        private void pictureBoxGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();
            this.Hide();
            anaForm.Show();
        }
    }
}
