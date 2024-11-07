using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum EvTuru
    {
        Daire,
        Bahceli,
        Dubleks,
        Mustakil
    }
    public enum EvDurumu
    {
        Satilik,
        Kiralik
    }
    public class Ev
    {
        // Fields
        private int odaSayisi;
        private int katNumarasi;
        private string semti;
        private double alani;
        private DateTime yapimTarihi;
        private EvTuru turu;
        private bool aktif;
        private static int emlakNumarasiCounter = 1;
        public int EmlakNumarasi { get; private set; }
        
        // Ev Durumu (Satılık/Kiralık) özelliği eklendi
        public EvDurumu Durumu { get; set; }

        // Properties
        public int OdaSayisi
        {
            get => odaSayisi;
            set
            {
                if (value < 0)
                {
                    odaSayisi = 0;
                    LogYaz($"Negatif oda sayısı değeri: {value}. OdaSayisi 0 olarak atandı.");
                }
                else
                {
                    odaSayisi = value;
                    LogYaz($"Geçerli oda sayısı değeri: {value}");
                }
            }
        }

        public int KatNumarasi
        {
            get => katNumarasi;
            set
            {
                if (value >= 0)
                    katNumarasi = value;
            }
        }

        public string Semti { get; set; }
        public string Il { get; set; } // İl bilgisi eklendi

        public double Alani
        {
            get => alani;
            set
            {
                if (value > 0)
                    alani = value;
            }
        }

        public DateTime YapimTarihi
        {
            get => yapimTarihi;
            set => yapimTarihi = value;
        }

        public EvTuru Turu { get; set; }
        public bool Aktif { get; set; }

        public int Yas => DateTime.Now.Year - yapimTarihi.Year;
        public double Fiyat { get; set; }
        // Constructors
        public Ev(int odaSayisi, int katNumarasi, string semti, double alani, DateTime yapimTarihi, EvTuru turu, bool aktif = true)
        {
            EmlakNumarasi = emlakNumarasiCounter++;
            OdaSayisi = odaSayisi;
            KatNumarasi = katNumarasi;
            Semti = semti;
            Alani = alani;
            YapimTarihi = yapimTarihi;
            Turu = turu;
            Aktif = aktif;

        }

        // Methods
        public virtual string EvBilgileri()
        {
            return $"Emlak No: {EmlakNumarasi}, İl: {Il}, Semt: {Semti}, Alan: {Alani} m², Oda Sayısı: {OdaSayisi}, Kat Numarası: {KatNumarasi}, Yaş: {Yas}, Tür: {Turu}, Durum: {Durumu}, Fiyat: {Fiyat} TL";
        }

        public double FiyatHesapla()
        {
            double katsayi = 200; // Varsayılan değer
            string filePath = "room_cost.txt";
            if (File.Exists(filePath))
            {
                string katsayiStr = File.ReadAllText(filePath);
                if (double.TryParse(katsayiStr, out double result))
                    katsayi = result;
            }
            return OdaSayisi * katsayi;
        }

        private void LogYaz(string mesaj)
        {
            string logDosyasi = "log.txt";
            using (StreamWriter sw = new StreamWriter(logDosyasi, true))
            {
                sw.WriteLine($"{DateTime.Now}: {mesaj}");
            }
        }

       
        public string Semt { get; set; }
        public string Tipi { get; set; } // Satılık veya Kiralık
      

        public string Formatla()
        {
            return $"{Il} - {Semt} - {Tipi} - {Fiyat} TL";
        }
    }
}
