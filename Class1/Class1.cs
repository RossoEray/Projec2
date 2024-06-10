using System;

namespace Ev.Libs
{

    public class Ev
    {
        public byte oda_sayisi { get; set; }
        public byte kat_sayisi { get; set; }
        public string semt { get; set; }
        public byte tuvalet_sayisi { get; set; }
        public float depozito { get; set; }
        public virtual string EvBilgileriGetir()
        {
            return $"Evin Oda Sayısı:{oda_sayisi}\nEvin Kat Sayısı:{kat_sayisi}\nEvin Semti:{semt}\n" +
                $"Tuvalet Sayısı:{tuvalet_sayisi}\nDepozito:{depozito}";
        }
    }
    public class SatilikEv : Ev
    {
        public int ev_fiyati { get; set; }
        public override string EvBilgileriGetir()
        {
            return $"{base.EvBilgileriGetir()}\nEvin Fiyatı:{ev_fiyati}\n*******";
        }

    }
    public class KiralikEv : Ev
    {
        public int kira { get; set; }
        public override string EvBilgileriGetir()
        {
            return $"{base.EvBilgileriGetir()}\nEvin Kirası:{kira}\n*******";
        }


    }
}