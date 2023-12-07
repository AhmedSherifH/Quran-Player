using Newtonsoft.Json;
using System.Diagnostics;

namespace Quran_Player
{
    public partial class SurahPlayer : Form
    {
        public int? SurahNumber { get; set; }

        public SurahPlayer()
        {
            InitializeComponent();
        }

        private async void SurahPlayer_Load(object sender, EventArgs e)
        {

            using (var httpClient = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://api.alquran.cloud/v1/surah/" + SurahNumber),
                };

                using (var response = await httpClient.SendAsync(request))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    dynamic? json = JsonConvert.DeserializeObject(apiResponse);
                    string? surahName = json?.data.name;
                    surahNameLabel.Text = surahName;
                    Debug.WriteLine(surahName);
                }
            }




        }
    }
}
