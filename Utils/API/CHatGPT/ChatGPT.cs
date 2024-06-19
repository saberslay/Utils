using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Utils.API.ChatGPT {

    public class ChatGPT {
        private static HttpClient Http = new HttpClient();
        public string ChatGPT_Respons;
        public async Task<dynamic> ChatGPTAsync(string Qustion, string API_KEY) {
            Http.DefaultRequestHeaders.Add("Authorization", $"Bearer {API_KEY}");

            // JSON content for the API call
            var jsonContent = new {
                prompt = $"{Qustion}",
                model = "text-davinci-003",
                max_tokens = 1000
            };

            // Make the API call
            var responseContent = await Http.PostAsync("https://api.openai.com/v1/completions", new StringContent(JsonConvert.SerializeObject(jsonContent), Encoding.UTF8, "application/json"));

            // Read the response as a string
            var resContext = await responseContent.Content.ReadAsStringAsync();

            // Deserialize the response into a dynamic object
            var data = JsonConvert.DeserializeObject<dynamic>(resContext);
            ChatGPT_Respons = data.choices[0].text;
            return data.choices[0].text;
        }
    }
}
