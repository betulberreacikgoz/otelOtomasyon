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
    public partial class RezervasyonIslemleri : Form
    {
        private readonly MusteriService musteriService;
        private readonly RezervasyonService _rezervasyonService;
        private readonly OdaDAL _odaDAL;
        private readonly MusteriDAL _musteriDAL;
        public RezervasyonIslemleri()
        {
            InitializeComponent();
            // musteriService = new MusteriService();
            RezervasyonService _rezervasyonService = new RezervasyonService();
            RezervasyonDAL _rezervasyonDAL = new RezervasyonDAL();
            pictureBox2.Click += pictureBox2_Click;
            _odaDAL = new OdaDAL();
            _musteriDAL = new MusteriDAL();
        }


        private void GridDoldur()
        {
            try
            {
                using (MySqlConnection conn = new Baglanti().baglantiGetir())
                {
                    string query = "SELECT * FROM Rezervasyon";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    RezervasyondataGrid.DataSource = dt;

                    // Kolon başlıklarını düzenle
                    RezervasyondataGrid.Columns["oda_id"].HeaderText = "Oda ID";
                    RezervasyondataGrid.Columns["musteri_kimlik"].HeaderText = "Müşteri Kimlik";
                    RezervasyondataGrid.Columns["giris_tarihi"].HeaderText = "Giriş Tarihi";
                    RezervasyondataGrid.Columns["cikis_tarihi"].HeaderText = "Çıkış Tarihi";

                    // GridView özelliklerini ayarla
                    RezervasyondataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    RezervasyondataGrid.AllowUserToAddRows = false;
                    RezervasyondataGrid.ReadOnly = true;
                    RezervasyondataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon tablosuna veri yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MusteriEkle()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                RezervasyonService _rezervasyonService = new RezervasyonService();

                _rezervasyonService.RezervasyonOlustur(
                    girisTarihi: giristarDTP.Value,
                    cikisTarihi: cikistarDTP.Value,
                    odaId: Convert.ToInt32(comboBoxOdaid.SelectedValue),
                    musteriId: Convert.ToInt32(comboBoxMusteritc.SelectedValue),
                    musteri_kimlik: Convert.ToInt64((comboBoxMusteritc.SelectedValue))
                );

                MessageBox.Show("Rezervasyon başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle(); // TextBox'ları temizle
                GridDoldur(); // GridView'i yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RezervasyondataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = RezervasyondataGrid.Rows[e.RowIndex];

                // Seçilen satırın verilerini textboxlara doldur
                //odaIDtxt.Text = row.Cells["oda_id"].Value.ToString();
              //  musteritcTxt.Text = row.Cells["musteri_kimlik"].Value.ToString();
                giristarDTP.Value = Convert.ToDateTime(row.Cells["giris_tarihi"].Value);
                cikistarDTP.Value = Convert.ToDateTime(row.Cells["cikis_tarihi"].Value);
            }
        }

        private void musteritcTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private AnaSayfa anaSayfa;
        public RezervasyonIslemleri(AnaSayfa form)
        {
            InitializeComponent();
            anaSayfa = anaSayfa;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();
            this.Hide();
            anaForm.Show();
        }

        private void RezervasyonIslemleri_Load(object sender, EventArgs e)
        {
            GridDoldur();
            LoadOdaIds();
            LoadMusteriTc();
        }


        private void LoadMusteriTc()
        {
            try
            {
                var musteriTcList = _musteriDAL.GetMusteriTcList(); // Müşteri TC'lerini al
                comboBoxMusteritc.DataSource = musteriTcList; // ComboBox'a ata
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri TC'leri yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void silBtn_Click(object sender, EventArgs e)
        {
            RezervasyonService _rezervasyonService = new RezervasyonService();
            RezervasyonDAL _rezervasyonDAL = new RezervasyonDAL();

            try
            {
                if (RezervasyondataGrid.CurrentRow != null)
                {
                    int musteriKimlikNo = Convert.ToInt32(RezervasyondataGrid.CurrentRow.Cells["musteri_kimlik"].Value);
                    var silindimi = _rezervasyonService.RezervasyonSil(musteriKimlikNo);
                    if (silindimi)
                    {
                        MessageBox.Show("Rezervasyon başarıyla silindi.");
                        Temizle(); // TextBox'ları temizle
                        GridDoldur(); // GridView'i yenile
                    }
                    else
                    {
                        MessageBox.Show("Rezervasyon silinemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek için bir rezervasyon seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            //odaIDtxt.Clear();
            //musteritcTxt.Clear();
            giristarDTP.Value = DateTime.Now;
            cikistarDTP.Value = DateTime.Now;
        }

        //public RezervasyonIslemleri()
        //{
        //    InitializeComponent();
        //    pictureBox2.Click += pictureBox2_Click;
        //}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RezervasyonListele rezervasyonListele = new RezervasyonListele();
            rezervasyonListele.Show();
            this.Hide();
        }


        private Baglanti baglanti = new Baglanti();

      


        private void LoadOdaIds()
        {

            //try
            //{
            //    var odaIds = _odaDAL.GetOdaIds(); // Oda ID'lerini al
            //    comboBoxOdaid.DataSource = odaIds; // ComboBox'a ata
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Oda ID'leri yüklenirken bir hata oluştu: " + ex.Message);
            //}

            try
            {
                if (_odaDAL == null)
                {
                    MessageBox.Show("OdaDAL nesnesi başlatılmamış.");
                    return;
                }

                var odaIds = _odaDAL.GetOdaIds(); // Oda ID'lerini al
                comboBoxOdaid.DataSource = odaIds; // ComboBox'a ata
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda ID'leri yüklenirken bir hata oluştu: " + ex.Message);
            }
        }




       

       
    }
}
