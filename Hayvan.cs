using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melikenin_Çiftligi
{
   abstract class Hayvan
    {
        public int Süre { get; set; }
        public int Can { get; set; }

        public abstract void CanAzalma();
        public void CanFulleme()//hepsinde aynı olduğu için abstract değil
        {
            Can = 100;
        }

        public int Urun { get; set; }
        public void UrunSayaci()//urun artar
        {
            Urun++;
        }
        public abstract int UrunSatılması();
        public int UrunKazanc { get; set; }
        public bool Yasam { get; set; }

        public abstract bool SesCiktiMi { get; set; }
        public abstract void Ses(string yol);
        public abstract void YasamKontrol();
        public Hayvan()// ilk atamalar kurucunun içinde yazılır
        {
            Süre = 0;
            Can = 100;
            Yasam = true;
            Urun = 0;
            UrunKazanc = 0;
            SesCiktiMi = false;
        }

    }
}
