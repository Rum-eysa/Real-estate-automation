using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class KiralikEv :Ev
    {
    
        public double Depozito { get; set; }
        public double Kira { get; set; }

        // Kiralık ev için uygun kurucu metod
        public KiralikEv(int odaSayisi, int katNumarasi, string semti, double alani, DateTime yapimTarihi, EvTuru turu, double depozito, double kira)
            : base(odaSayisi, katNumarasi, semti, alani, yapimTarihi, turu)
        {
            Depozito = depozito;
            Kira = kira;
        }

        // EvBilgileri metodunu override ediyoruz, kiralık ev bilgilerini geri döndürecek şekilde özelleştiriyoruz.
        public override string EvBilgileri()
        {
            return string.Format("Emlak No: {0}, Tür: {1}, Oda Sayısı: {2}, Kat: {3}, Semt: {4}, Alan: {5} m², Yapım Tarihi: {6}, Depozito: {7} TL, Kira: {8} TL, Aktif: {9}",
                                 EmlakNumarasi, Turu, OdaSayisi, KatNumarasi, Semti, Alani, YapimTarihi.ToShortDateString(), Depozito, Kira, Aktif ? "Evet" : "Hayır");
        }
    }
}
