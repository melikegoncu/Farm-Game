/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:
**				ÖĞRENCİ ADI............:Melike göncü
**				ÖĞRENCİ NUMARASI.......:b181210396
**                         DERSİN ALINDIĞI GRUP...:
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melikenin_Çiftligi
{
    public partial class Form1 : Form
    {
        public int Zaman = 0;
        public int KasaToplam = 0;
        //global değişkenler atadık

        public Form1()
        {
            InitializeComponent();
            timer1.Start();//timer başlattık
        }
        Tavuk tavuk1 = new Tavuk(); //nesneleri oluşturduk
        Ordek ordek1 = new Ordek();
        Inek inek1 = new Inek();
        Keci keci1 = new Keci();

        private void timer1_Tick(object sender, EventArgs e)
        {
            Zaman++;
            lbl_Süre.Text = Convert.ToString(Zaman);
            tavuk1.YasamKontrol();
            if (tavuk1.Yasam)// eğer tavuk yaşıyorsa 
            {
                tavuk1.CanAzalma();
                if (Zaman % 3 == 0)
                {
                    tavuk1.UrunSayaci();
                    lbl_Tav_Yum.Text = Convert.ToString(tavuk1.Urun) + " tane";
                }
            }
            else//tavuk yaşamıyorsa
            {
                lbl_ÖlüTavuk.Text = "ÖLÜ";
                tavuk1.Ses(Application.StartupPath + "\\tavuk.wav");
            }
            Progress_TavukCan.Value = tavuk1.Can;

            ordek1.YasamKontrol();
            if (ordek1.Yasam)// eğer ördek yaşıyorsa 
            {
                ordek1.CanAzalma();
                if (Zaman % 5 == 0)
                {
                    ordek1.UrunSayaci();
                    lbl_Ord_Yum.Text = Convert.ToString(ordek1.Urun) + " tane";
                }
            }
            else//yaşamıyorsa
            {
                lbl_ÖlüÖrdek.Text = "ÖLÜ";
                ordek1.Ses(Application.StartupPath + "\\ordek.wav");
            }
            Progress_ÖrdekCan.Value = ordek1.Can;

            inek1.YasamKontrol();
            if (inek1.Yasam)// eğer inek yaşıyorsa 
            {
                inek1.CanAzalma();
                if (Zaman % 8 == 0)
                {
                    inek1.UrunSayaci();
                    lbl_Inek_Süt.Text = Convert.ToString(inek1.Urun) + " litre";
                }
            }
            else//yaşamıyorsa
            {
                lbl_Ölüİnek.Text = "ÖLÜ";
                inek1.Ses(Application.StartupPath + "\\inek.wav");
            }
            Progress_İnekCan.Value = inek1.Can;

            keci1.YasamKontrol();
            if (keci1.Yasam)// eğer keçi yaşıyorsa 
            {
                keci1.CanAzalma();
                if (Zaman % 7 == 0)
                {
                    keci1.UrunSayaci();
                    lbl_Keci_Sut.Text = Convert.ToString(keci1.Urun) + " litre";
                }
            }
            else//yaşamıyorsa
            {
                lbl_ÖlüKeçi.Text = "ÖLÜ";
                keci1.Ses(Application.StartupPath + "\\keci.wav");
            }
            Progress_KeçiCan.Value = keci1.Can;

            KasaToplam = (tavuk1.UrunKazanc + ordek1.UrunKazanc + inek1.UrunKazanc + keci1.UrunKazanc);//toplam para
            lbl_Kasa.Text = Convert.ToString(KasaToplam) + " TL";
        }

        private void btn_Tavuk_Yem_Click(object sender, EventArgs e)//butona tıklandığında yaşam kontrol edilir
        {
            if (tavuk1.Yasam)
                tavuk1.CanFulleme();
        }

        private void Btn_Ordek_Yem_Click(object sender, EventArgs e)//butona tıklandığında yaşam kontrol edilir
        {
            if (ordek1.Yasam)
                ordek1.CanFulleme();
        }

        private void btn_Inek_Yem_Click(object sender, EventArgs e)//butona tıklandığında yaşam kontrol edilir
        {
            if (inek1.Yasam)
                inek1.CanFulleme();
        }

        private void btn_Keçi_Yem_Click(object sender, EventArgs e)//butona tıklandığında yaşam kontrol edilir
        {
            if (keci1.Yasam)
                keci1.CanFulleme();
        }

        private void btn_TavukYum_Sat_Click(object sender, EventArgs e)//urun sayısı kadar satılır
        {
            tavuk1.UrunKazanc += tavuk1.UrunSatılması();
            lbl_Tav_Yum.Text = Convert.ToString(tavuk1.Urun) + " tane";
        }

        private void btn_OrdekYum_Sat_Click(object sender, EventArgs e)//urun sayısı kadar satılır
        {
            ordek1.UrunKazanc += ordek1.UrunSatılması();
            lbl_Ord_Yum.Text = Convert.ToString(ordek1.Urun) + " tane";
        }

        private void btn_InekSüt_Sat_Click(object sender, EventArgs e)//urun sayısı kadar satılır
        {
            inek1.UrunKazanc += inek1.UrunSatılması();
            lbl_Inek_Süt.Text = Convert.ToString(inek1.Urun) + " litre";
        }

        private void btn_KeçiSüt_Sat_Click(object sender, EventArgs e)//urun sayısı kadar satılır
        {
            keci1.UrunKazanc += keci1.UrunSatılması();
            lbl_Keci_Sut.Text = Convert.ToString(keci1.Urun) + " litre";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
