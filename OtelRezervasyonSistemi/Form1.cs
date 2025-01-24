using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelRezervasyonSistemi.SERVİCE;
using OtelRezervasyonSistemi.UI;

namespace OtelRezervasyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    AnaSayfa anaSayfa = new AnaSayfa();
        //    anaSayfa.Show();
        //    this.Hide();
            
            
            string kimlik = txtKimlik.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kimlik) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kimlik ve şifre alanları boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            YoneticiService yoneticiService = new YoneticiService();
            bool girisBasarili = yoneticiService.GirisYap(kimlik, sifre);

            if (girisBasarili)
            {
                // Giriş başarılı, ana sayfaya geçiş yap
                AnaSayfa anaSayfaForm = new AnaSayfa();
                anaSayfaForm.Show();
                this.Hide(); // Giriş ekranını gizle
            }
            else
            {
                MessageBox.Show("Kimlik veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
