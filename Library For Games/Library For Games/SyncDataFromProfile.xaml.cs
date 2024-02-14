using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace Library_For_Games
{
    /// <summary>
    /// Interaction logic for SyncDataFromProfile.xaml
    /// </summary>
    public partial class SyncDataFromProfile : Window
    {
        Database database;
        public SyncDataFromProfile()
        {
            InitializeComponent();
            database = new Database();
        }

        private async void BTN_Updated_steam_Click(object sender, RoutedEventArgs e)
        {
            string UserID = TB_UserID.Text;
            string apiKey = TB_API_KEY.Text;
            string url = $"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={apiKey}&steamid={UserID}&format=json";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        JObject json = JObject.Parse(responseBody);
                        JArray gamesArray = (JArray)json["response"]["games"];

                        SteamApiClient steamApiClient = new SteamApiClient();

                        string message = "Games and Playtime:\n\n";
                        foreach (JObject game in gamesArray)
                        {
                            int appId = game["appid"].ToObject<int>();
                            int playtimeMinutes = game["playtime_forever"].ToObject<int>();
                            int playtimeHours = playtimeMinutes / 60;

                            string gameName = await steamApiClient.GetGameNameAsync(appId);
                            string gameDescription = await steamApiClient.GetGameDescriptionAsync(appId);

                            if (gameName != null)
                            {
                                Game_S games = new(1, gameName, gameDescription ?? "None", playtimeHours, 1);
                                database.ChecksSteamAndDatabase(games);
                            }
                        }

                        MessageBox.Show("Sync complete");
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"HTTP error: {ex.Message}", "Error");
                }
            }
            Close(); 
        }
    }
    public class SteamApiClient
    {
        private HttpClient _httpClient;

        public SteamApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetGameDescriptionAsync(int appId)
        {
            string url = $"https://store.steampowered.com/api/appdetails?appids={appId}";
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);

                
                if (jsonResponse != null && jsonResponse[appId.ToString()] != null && jsonResponse[appId.ToString()]["data"] != null && jsonResponse[appId.ToString()]["data"]["genres"] != null)
                {
                    string gameGenre = jsonResponse[appId.ToString()]["data"]["genres"][0]["description"];
                    return gameGenre;
                }
                else
                {
                    Console.WriteLine($"Unable to retrieve game genre for appId: {appId}");
                    return null;
                }
            }
            else
            {
                Console.WriteLine($"Failed to fetch game details for appId: {appId}. Status code: {response.StatusCode}");
                return null;
            }
        }

        public async Task<string> GetGameNameAsync(int appId)
        {
            string url = $"https://store.steampowered.com/api/appdetails?appids={appId}";
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);

                if (jsonResponse != null && jsonResponse[appId.ToString()] != null && jsonResponse[appId.ToString()]["data"] != null && jsonResponse[appId.ToString()]["data"]["name"] != null)
                {
                    string gameName = jsonResponse[appId.ToString()]["data"]["name"];
                    return gameName;
                }
                else
                {
                    Console.WriteLine($"Unable to retrieve game name for appId: {appId}");
                    return null;
                }
            }
            else
            {
                Console.WriteLine($"Failed to fetch game details for appId: {appId}. Status code: {response.StatusCode}");
                return null;
            }

        }
    }
}