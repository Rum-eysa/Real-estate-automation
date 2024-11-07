using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class SatilikEv : Ev
    {
        public double Fiyat { get; set; }

        // Satılık ev için uygun kurucu metod
        public SatilikEv(int odaSayisi, int katNumarasi, string semti, double alani, DateTime yapimTarihi, EvTuru turu, double fiyat)
            : base(odaSayisi, katNumarasi, semti, alani, yapimTarihi, turu)
        {
            Fiyat = fiyat;
        }

        // EvBilgileri metodunu override ediyoruz, satılık ev bilgilerini geri döndürecek şekilde özelleştiriyoruz.
        public override string EvBilgileri()
        {
            return string.Format("Emlak No: {0}, Tür: {1}, Oda Sayısı: {2}, Kat: {3}, Semt: {4}, Alan: {5} m², Yapım Tarihi: {6}, Fiyat: {7} TL, Aktif: {8}",
                                 EmlakNumarasi, Turu, OdaSayisi, KatNumarasi, Semti, Alani, YapimTarihi.ToShortDateString(), Fiyat, Aktif ? "Evet" : "Hayır");
        }
    }
}
