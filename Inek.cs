using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

namespace Melikenin_Çiftligi
{
    class Inek:Hayvan
    {
        public override bool SesCiktiMi { get; set; }

        public override void CanAzalma()//can azalır
        {
            Can -= 8;
        }
        public override void YasamKontrol()//yasam boolu kontrol edilir
        {
            if (Can <= 8)
            {
                Can = 0;
                Yasam = false;
            }
        }
        public override int UrunSatılması()//urun sıfırlanıp temp ile satılır
        {
            int TempUrun = Urun;
            Urun = 0;
            return TempUrun * 5;
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
