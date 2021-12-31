using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneRandevuEFCF_BLL;
using HastaneRandevuEFCF_Entities;

namespace HastaneRandevuEFCF_WinFormUI
{
    public partial class FormHastaCagir : Form
    {
        public FormHastaCagir()
        {
            InitializeComponent();
        }

        // GLOBAL ALAN
        DoktorManager drManager = new DoktorManager();
        RandevuManager rndManager = new RandevuManager();
        Doktor secilenDoktor { get; set; }
        public bool FormLoadBittiMi { get; set; }

        private void FormHastaCagir_Load(object sender, EventArgs e)
        {
            FormLoadBittiMi = false;
            // comboBox
            ComboyaDoktorlariGetir();

            // btnDurdur
            btnDurdur.Enabled = false;
            btnBasla.Enabled = true;

            // label
            labelHasta.Text = "---------";

            // Doktor
            secilenDoktor = null;
            FormLoadBittiMi = true;
        }

        private void ComboyaDoktorlariGetir()
        {
            comboBoxDoktor.DisplayMember = "DoktorAdi" + "DoktorSoyadi";
            comboBoxDoktor.ValueMember = "DoktorId";
            comboBoxDoktor.DataSource = drManager.TumAktifDoktorlariGetir();
            comboBoxDoktor.SelectedIndex = -1;
        }

        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelHasta.Text = "---";
            if (comboBoxDoktor.SelectedIndex >= 0)
            {
                secilenDoktor = drManager.DoktoruIdyeGoreBul(
                    (int)comboBoxDoktor.SelectedValue);

                // secilen doktorun  bugüne ait randevusu yoksa burada bir messagebox ile randevusu yoktur diye mesaj verilmelidir ve timer stop edilmelidir.

                if (rndManager.DoktorunRandevulariniTariheGoreGetir(secilenDoktor, DateTime.Now).Count == 0 && FormLoadBittiMi)

                {
                    MessageBox.Show($"{secilenDoktor.ToString()} adlı doktorun bugün hiç randevusu bulunmuyor!");
                    timer1.Stop();
                    btnBasla.Enabled = true;
                    btnDurdur.Enabled = false;
                }

            }

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 sanie verdik.
            timer1.Start(); // ya da timer1.Enabled=true;

            btnDurdur.Enabled = true;
            btnBasla.Enabled = false;


        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // ya da timer1.Enabled=false;
            btnDurdur.Enabled = false;
            btnBasla.Enabled = true;
            labelHasta.Font = new Font("Arial", 35);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Font BuyukFont = new Font("Arial", 45);
            Font NormalFont = new Font("Arial", 40);

            if (DateTime.Now.Second % 2 == 0)
            {
                labelHasta.Font = BuyukFont;
                labelHasta.ForeColor = Color.Red;
            }
            else
            {
                labelHasta.Font = NormalFont;
                labelHasta.ForeColor = Color.Blue;
            }

            if (secilenDoktor != null)
            {
                // Doktorun seçilen bugüne ait randevularını bulalım:

                List<RandevuBilgileri> drRandevulari = rndManager.DoktorunRandevulariniTariheGoreGetir(secilenDoktor, DateTime.Now);

                if (drRandevulari.Count > 0)
                {
                    RandevuBilgileri bulunanRandevu = drRandevulari.FirstOrDefault(x => x.RandevuTarihi.ToString("HH") == DateTime.Now.Hour.ToString() && x.RandevuTarihi.Minute < DateTime.Now.Minute + 2 && x.RandevuTarihi.Minute > DateTime.Now.Minute - 2);

                    if (bulunanRandevu != null)
                    {
                        labelHasta.Text = $"{bulunanRandevu.Hasta.HastaAdi} {bulunanRandevu.Hasta.HastaSoyadi}";
                    }

                }
            }
            
        }
    }
}
