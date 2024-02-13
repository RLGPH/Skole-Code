using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json.Linq;

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
            string SteamID = TB_SteamID.Text;
            string apiKey = TB_API_KEY.Text;
            string url = $"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={apiKey}&steamid={SteamID}&format=json";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Parse the JSON response
                        JObject json = JObject.Parse(responseBody);
                        JArray gamesArray = (JArray)json["response"]["games"];

                        SteamApiClient steamApiClient = new SteamApiClient();

                        // Display the games and playtime in a MessageBox
                        string message = "Games and Playtime:\n\n";
                        foreach (JObject game in gamesArray)
                        {
                            int appId = game["appid"].ToObject<int>();
                            int playtimeMinutes = game["playtime_forever"].ToObject<int>();
                            int playtimeHours = playtimeMinutes / 60;

                            // Fetch the game name using the provided appID
                            string gameName = await steamApiClient.GetGameNameAsync(appId);
                            if (gameName != null)
                            {
                                Game_S games = new(1, gameName, "none", playtimeHours, 1);
                                database.ChecksSteamAndDatabase(games);
                            }
                        }

                        MessageBox.Show("sync complete");
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

        public async Task<string> GetGameNameAsync(int appId)
        {
            // Make a request to the GetAppDetails endpoint with the provided appID
            string url = $"https://store.steampowered.com/api/appdetails?appids={appId}";
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                // Read the response content
                string responseBody = await response.Content.ReadAsStringAsync();

                // Parse the JSON response to extract the game name
                // Note: You'll need to implement proper JSON parsing logic here
                // This is just a simplified example
                dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);

                // Check for null references before accessing properties
                if (jsonResponse != null && jsonResponse[appId.ToString()] != null && jsonResponse[appId.ToString()]["data"] != null && jsonResponse[appId.ToString()]["data"]["name"] != null)
                {
                    string gameName = jsonResponse[appId.ToString()]["data"]["name"];
                    return gameName;
                }
                else
                {
                    // Handle the case where the jsonResponse doesn't contain the expected data
                    Console.WriteLine($"Unable to retrieve game name for appId: {appId}");
                    return null;
                }
            }
            else
            {
                // Request failed, handle the error
                Console.WriteLine($"Failed to fetch game details for appId: {appId}. Status code: {response.StatusCode}");
                return null;
            }
        }

        public async Task<string> GetGameNameByAppIdAsync(int appId)
        {
            try
            {
                // Immediately fetch the game name using the provided appID
                string gameName = await GetGameNameAsync(appId);
                return gameName;
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error fetching game name: {ex.Message}");
                return null;
            }
        }
    }
}
