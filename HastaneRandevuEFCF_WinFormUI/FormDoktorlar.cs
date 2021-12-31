using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneRandevuEFCF_Entities;
using HastaneRandevuEFCF_BLL;


namespace HastaneRandevuEFCF_WinFormUI
{
    public partial class FormDoktorlar : Form
    {
        public FormDoktorlar()
        {
            InitializeComponent();
        }
        //Global alan
        DoktorManager drManager = new DoktorManager();

        private void FormDoktorlar_Load(object sender, EventArgs e)
        {
            //datagrid
            DrGrideVerileriGetir();

            //comboBox
            comboBoxDrBranslar.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            //comboBoxDrBranslar.DisplayMember = "TheValue";
            //comboBoxDrBranslar.ValueMember = "TheKey";
            //comboBoxDrBranslar.DataSource = EnumManager.TumBranslariGetir();
            //comboBoxDrBranslar.SelectedValue = (int)Branslar.BransYok;

            comboBoxDrBranslar.DataSource = Enum.GetValues(typeof(Branslar));

            //maskedtextbox maske ayarlaması

            maskedTextBoxDrTel.Mask = @"\0\5##-###-##-##"; //11 hane
        }
        private void btnDrEkle_Click(object sender, EventArgs e)
        {
            try
            {
                //kontrol edilmesi gereken durumlar
                // ad soyad en az 2 karakterde olmalı
                if (txtDrAd.Text.Trim().Length < 2) // Doktor adı: Su gibi kısa bir isim olabilir ama daha kısasını kabul etmeyeceğiz.
                {
                    throw new Exception("Lütfen doktor adını düzgün giriniz!");
                }
                if (txtDrSoyad.Text.Trim().Length < 2) // Doktor soyadı: Su gibi kısa bir soyisim olabilir ama daha kısasını kabul etmeyeceğiz.
                {
                    throw new Exception("Lütfen doktor soyadını düzgün giriniz!");
                }
                // tc kimlik numarası

                if (txtDrTC.Text.Trim().Length != 11) //
                {
                    throw new Exception("TC Kimlik numarası 11 haneli olmalıdır!");
                }
                if (txtDrTC.Text.Any(x => !char.IsDigit(x)))
                {
                    throw new Exception("TC Kimlik numarası rakamlardan oluşacak şekilde 11 haneli olmalıdır!");
                }


                Branslar drBransi;
                Enum.TryParse(comboBoxDrBranslar.SelectedValue.ToString(), out drBransi);
                Doktor yeniDoktor = new Doktor()
                {
                    DoktorAdi = txtDrAd.Text.Trim(),
                    DoktorSoyadi = txtDrSoyad.Text.Trim(),
                    TCNumarasi = txtDrTC.Text,
                    Email = txtDrEmail.Text,
                    Telefon = maskedTextBoxDrTel.Text.Replace("-", ""),
                    Brans = drBransi,
                    //Eğer combonun datasource'unu EnumManager.TumBranslariGetir(); ile getirisek burada bransi aşağıdaki gibi almalıyız
                    //Brans = EnumManager.BransiBul((int)comboBoxDrBranslar.SelectedValue)
                };
                //veritabanına ekleme yapması gerekiyor.

                if (drManager.YeniDoktorEkle(yeniDoktor))
                {
                    MessageBox.Show($"{txtDrAd.Text.Trim()} {txtDrSoyad.Text.Trim()} sisteme yeni doktorumuz olarak eklenmiştir!");
                    //temizlik
                    DrEkleSayfasiTemizle();
                    DrGrideVerileriGetir();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA: " + ex.Message);
            }
        }
        private void DrGrideVerileriGetir()
        {
            dataGridViewDoktor.DataSource = drManager.TumAktifDoktorlariGetir();

        }

        private void DrEkleSayfasiTemizle()
        {
            txtDrAd.Clear();
            txtDrSoyad.Clear();
            txtDrTC.Clear();
            txtDrEmail.Clear();
            comboBoxDrBranslar.SelectedIndex = 0;
            maskedTextBoxDrTel.Clear();
        }

        private void comboBoxDrBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
