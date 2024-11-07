using ClassLibrary;
using System;
using System.IO;
using System.Windows.Forms;

namespace Windows_Forms_Application
{
    public partial class KayitForm : Form
    {
        private const int MAX_EV_SAYISI = 1000;
        private Ev[] evler = new Ev[MAX_EV_SAYISI];
        private int evSayisi = 0;

        public KayitForm()
        {
            InitializeComponent();
            LoadCities(); // Şehirleri yükle
            comboBoxİl.SelectedIndexChanged += comboBoxIl_SelectedIndexChanged;
            radioButtonSatilik.Checked = true; // Varsayılan olarak Satılık seçili
            dtpYapimTarihi.Value = DateTime.Now; // Tarih seçimini güncel yap
        }

        // Şehir seçeneklerini ComboBox'a yükle
        private void LoadCities()
        {
            string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya", "Adana", "Konya", "Gaziantep", "Samsun", "Kayseri" };
            comboBoxİl.Items.AddRange(cities);
        }

        // Seçilen şehir değiştiğinde semtleri yükle
        private void comboBoxIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBoxİl.SelectedItem.ToString();
            LoadSemtOptions(selectedCity);
        }

        // Seçilen şehre göre semt bilgilerini yükle
        private void LoadSemtOptions(string city)
        {
            comboBoxSemt.Items.Clear();
            string filePath = $"Data/Semtler/{city}_Semtler.txt";

            if (File.Exists(filePath))
            {
                string[] semtList = File.ReadAllLines(filePath);
                comboBoxSemt.Items.AddRange(semtList);
            }
            else
            {
                MessageBox.Show($"{city} için semt listesi dosyası bulunamadı.");
            }
        }

        // Yeni bir ev kaydını ekle ve dosyaya yaz
        private void KaydetEv(Ev ev)
        {
            if (evSayisi < MAX_EV_SAYISI)
            {
                evler[evSayisi++] = ev; // Diziye ekle
                string filePath = ev.Tipi == "Satılık" ? "satilik.txt" : "kiralik.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true)) // Dosyaya ekle
                {
                    writer.WriteLine(ev.Formatla()); // Ev bilgisini formatlı yaz
                }
            }
            else
            {
                MessageBox.Show("Maksimum ev sayısına ulaşıldı.");
            }
        }

        // Tüm ev kayıtlarını diziden dosyaya yükle
        private void KaydetEvlerDosyaya()
        {
            foreach (var ev in evler)
            {
                if (ev != null)
                {
                    KaydetEv(ev); // Her ev kaydını ilgili dosyaya kaydet
                }
            }
        }

        // Dosyadan ev bilgilerini oku ve diziye yükle
        private void EvleriDosyadanOku()
        {
            evSayisi = 0; // Mevcut diziye baştan yüklemek için sıfırla

            string[] satilikEvler = File.Exists("satilik.txt") ? File.ReadAllLines("satilik.txt") : Array.Empty<string>();
            string[] kiralikEvler = File.Exists("kiralik.txt") ? File.ReadAllLines("kiralik.txt") : Array.Empty<string>();

            foreach (var satilikEv in satilikEvler)
            {
                evler[evSayisi++] = ParseEv(satilikEv, "Satılık");
            }

            foreach (var kiralikEv in kiralikEvler)
            {
                evler[evSayisi++] = ParseEv(kiralikEv, "Kiralık");
            }
        }

        // Satır formatından Ev nesnesini çıkarır
        private Ev ParseEv(string satir, string tipi)
        {
            var parts = satir.Split('-');
            return new Ev
            {
                Il = parts[0].Trim(),
                Semt = parts[1].Trim(),
                Tipi = tipi,
                Fiyat = double.Parse(parts[3].Replace(" TL", "").Trim())
            };
        }
        // Ev sınıfı ve formatlama metodu
        public class Ev
        {
            public string Il { get; set; }
            public string Semt { get; set; }
            public string Tipi { get; set; } // Satılık veya Kiralık
            public double Fiyat { get; set; }
            public int OdaSayisi { get; set; }
            public double EvAlani { get; set; }
            public DateTime KayitTarihi { get; set; }

            public string Formatla()
            {
                return $"{Il} - {Semt} - {Tipi} - {Fiyat} TL - {OdaSayisi} Oda - {EvAlani} m² - {KayitTarihi.ToString("dd/MM/yyyy")}";
            }
        }
    }

}

