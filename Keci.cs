using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Melikenin_Çiftligi
{
    class Keci:Hayvan
    {
        public override bool SesCiktiMi { get; set; }

        public override void CanAzalma()//can azalır
        {
            Can -= 6;
        }
        public override void YasamKontrol()//yasam boolu kontrol edilir
        {
            if (Can <= 6)
            {
                Can = 0;
                Yasam = false;
            }
        }
        public override int UrunSatılması()//urun sıfırlanıp temp ile satılır
        {
            int TempUrun = Urun;
            Urun = 0;
            return TempUrun * 8;
        }
        public override void Ses(string yol)//sesin bir kez çalması için if ile bool kontrol edilir
        {
            if (SesCiktiMi == false)
            {
                SoundPlayer ses = new SoundPlayer();
                ses.SoundLocation = yol;
                ses.Play();
                SesCiktiMi = true;
            }
        }
    }
}
