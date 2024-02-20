using Newtonsoft.Json.Linq;
using System;
using System.Linq;
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
        readonly Database database;
        public SyncDataFromProfile()
        {
            InitializeComponent();
            database = new Database();
        }

        private async void BTN_Updated_steam_Click(object sender, RoutedEventArgs e)
        {
            string UserID = TB_UserID.Text;
            string apiKey = TB_API_KEY.Text;
            //steam api url using APIKey gotten from a text box and userID from Textbox
            string url = $"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={apiKey}&steamid={UserID}&format=json";

            //recives http response
            using (HttpClient client = new())
            {
                try
                {
                    //http response message
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        //
                        string responseBody = await response.Content.ReadAsStringAsync();

                        JObject json = JObject.Parse(responseBody);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        JArray gamesArray = (JArray)json["response"]["games"];



                        SteamApiClient steamApiClient = new();

#pragma warning disable CS8604 // Possible null reference argument.
                        foreach (JObject game in gamesArray.Cast<JObject>())
                        {
                            //holds appid
                            int appId = game["appid"].ToObject<int>();
                            //converts playtime from minuts to hours
                            int playtimeMinutes = game["playtime_forever"].ToObject<int>();
                            int playtimeHours = playtimeMinutes / 60;

                            //uses appid to get gamename and a semi description
                            string gameName = await steamApiClient.GetGameNameAsync(appId);
                            string gameDescription = await steamApiClient.GetGameDescriptionAsync(appId);

                            if (gameName != null)
                            {
                                //sends every thing to the database class to send it to the SQL database
                                //also if it couldnt get a description it will just say None
                                Game_S games = new(1, gameName, gameDescription ?? "None", playtimeHours, 1);
                                database.ChecksSteamAndDatabase(games);
                            }
                        }
                              //tells you its done
                        MessageBox.Show("Sync complete");
                    }
                }
                catch (HttpRequestException ex)
                {
                    //if an error were to occoure it would give the last message
                    MessageBox.Show($"HTTP error: {ex.Message}", "Error");
                }
            }
            // it does what its name states
            Close(); 
        }
    }
    public class SteamApiClient
    {
        private readonly HttpClient _httpClient;
        
        public SteamApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string?> GetGameDescriptionAsync(int appId)
        {
            //url for steam store page to get info from it usin AppID
            string url = $"https://store.steampowered.com/api/appdetails?appids={appId}";
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);

                
                if (jsonResponse != null && jsonResponse[appId.ToString()] != null && jsonResponse[appId.ToString()]["data"] != null && jsonResponse[appId.ToString()]["data"]["genres"] != null)
                {
                    //gets some info from the store page that could be fx action or MMO or some russian text that means the same as the engilsh version 
                    string gameGenre = jsonResponse[appId.ToString()]["data"]["genres"][0]["description"];
                    return gameGenre;
                }
                else
                { 
                    //if it fails
                    return null;
                }
            }
            else
            {
                MessageBox.Show($"Failed to fetch game details for appId: {appId}. Status code: {response.StatusCode}");
                return null;
            }
        }

        public async Task<string?> GetGameNameAsync(int appId)
        {
            //once again the URL to the steam store but to get the Game name this time
            string url = $"https://store.steampowered.com/api/appdetails?appids={appId}";
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);

                if (jsonResponse != null && jsonResponse[appId.ToString()] != null && jsonResponse[appId.ToString()]["data"] != null && jsonResponse[appId.ToString()]["data"]["name"] != null)
                {
                    //gets game name and returns it to the rest of the code
                    string gameName = jsonResponse[appId.ToString()]["data"]["name"];
                    return gameName;
                }
                else
                {
                    //if it couldnt get a the gamename using appID and writs none instead
                    MessageBox.Show($"will write gamename as NONE, it couldnt find {appId}");
                    string gamename = "NONE"; 
                    return gamename;
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