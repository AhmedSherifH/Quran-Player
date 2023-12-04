using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Quran_Player
{
    public partial class SplashScreen : Form
    {


        public SplashScreen()
        {
            InitializeComponent();
        }

        public string[] surahs = { "Al-Fatihah", "Al-Baqarah", "Ali'Imran",
                                   "An-Nisa", "Al-Ma'idah", "Al-An'am", "Al-Araf",
                                   "Al-Anfal", "At-Tawbah", "Yunus", "Hud"," Yusuf",
                                   "Ar-Ra'd", "Ibrahim", "Al-Hijr", "An-Nahl", "Al-Isra",
                                   "Al-Kahf", "Maryam", "Taha", "Al-Anbya", "Al-Hajj", "Al-Mu'minun",
                                   "An-Nur", "Al-Furqan", "Ash-Shu'ara", "An-Naml", "Al-Qasas", "Al-'Ankabut",
                                   "Ar-Rum", "Luqman", "As-Sajdah", "Al-Ahzab", "Saba", "Fatir", "Ya-Sin", "As-Saffat",
                                   "Sad", "Az-Zumar", "Ghafir", "Fussilat", "Ash-Shuraa", "Az-Zukhruf", "Ad-Dukhan",
                                   "Al-Jathiyah", "Al-Ahqaf", "Muhammed", "Al-Fath", "Al-Hujurat", "Qaf", "Adh-Dhariyat",
                                   "At-Tur", "An-Najm", "Al-Qamar", "Ar-Rahman", "Al-Waqi'ah", "Al-Hadid", "Al-Mujadila",
                                   "Al-Hashr", "Al-Mumtahanah", "As-Saf", "Al-Jumu'ah", "Al-Munafiqun", "At-Taghabun",
                                   "At-Talaq", "At-Tahrim", "Al-Mulk", "Al-Qalam", "Al-Haqqah", "Al-Ma'arij", "Nuh",
                                   "Al-Jinn", "Al-Muzzumammil", "Al-Muddaththir", "Al-Qiyamah", "Al-Insan", "Al-Mursalat",
                                   "An-Naba", "An-Nazi'at", "'Abasa", "At-Takwir", "Al-Infitar", "Al-Mutaffifin", "Al-Inshiqaq",
                                   "Al-Buruj", "At-Tariq", "Al-A'la", "Al-Ghashiyah", "Al-Fajr", "Al-Balad", "Ash-Shams", "Al-Layl",
                                   "Ad-Duhaa", "Ash-Sharh", "At-Tin", "Al-'Alaq", "Al-Qadr", "Al-Bayyinah", "Az-Zalzalah", "Al-'Adiyat",
                                   "Al-Qari'ah", "At-Takathur", "Al-'Asr", "Al-Humazah", "Al-Fil", "Quraysh", "Al-Ma'un", "Al-Kawthar",
                                   "Al-Kafirun", "An-Nasr", "Al-Masad", "Al-Ikhlas", "Al-Falaq", "An-Nas" };
        public string pickedSurah = string.Empty;
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            AddButtons();
        }




        private void EnterButton_Click(object sender, EventArgs e)
        {

            string search = "";
            surahPicker.Controls.Clear();
            if (string.IsNullOrEmpty(searchbar.Text))
            {
                // Pass
            }
            else { search = char.ToUpper(searchbar.Text[0]) + searchbar.Text[1..]; }
            bool emptySearch = string.IsNullOrWhiteSpace(search);

            if (emptySearch)
            {

                AddButtons();

            }
            else
            {

                foreach (string surah in surahs)
                {
                    if (surah.StartsWith(search))
                    {

                        Button button = new()
                        {
                            Width = 140,
                            Text = surah,
                            BackgroundImage = Properties.Resources._343a40,
                            ForeColor = Color.White
                        };
                        button.Font = new Font(button.Font.FontFamily, 10, FontStyle.Bold);
                        button.UseCompatibleTextRendering = true;
                        button.Click += SurahClick;
                        surahPicker.Controls.Add(button);
                    }
                }
            }

        }





        public void AddButtons()
        {

            foreach (string surah in surahs)
            {

                Button button = new()
                {
                    Width = 140,
                    Text = surah,
                    BackgroundImage = Properties.Resources._343a40,
                    ForeColor = Color.White
                };
                button.Font = new Font(button.Font.FontFamily, 10, FontStyle.Bold);
                button.UseCompatibleTextRendering = true;
                button.Click += SurahClick;
                surahPicker.Controls.Add(button);
            }

        }

        private void SurahClick(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                pickedSurah = button.Text;
                int ayah = 1;
                foreach (string i in surahs)
                {
                    if (i == pickedSurah)
                    {
                        Debug.WriteLine("Surah: " + pickedSurah + ". Ayah: " + ayah);
                    }
                    else
                    {
                        ayah++;
                    }
                }

               // SurahPlayer surahPlayer = new();
               // surahPlayer.Show();
               // this.Hide();
            }
        }

    }
}