using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Utils.API.CHatGPT {
    public class ChatGPT {
        private static readonly HttpClient client = new HttpClient();
        public string _responseContent;
        public async Task<string> GenerateResponse(string _apiKey, string inputText) {
            string apiKey = _apiKey;
            string model = "davinci";
            string prompt = inputText;
            int maxLength = 100;

            string url = $"https://api.openai.com/v1/engines/{model}/completions";

            string requestBody = $@"{{
            ""prompt"": ""{prompt}"",
            ""max_tokens"": {maxLength},
            ""temperature"": 0.7
        }}";

            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Add("Authorization", $"Bearer {apiKey}");
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode) {
                string responseContent = await response.Content.ReadAsStringAsync();
                _responseContent = responseContent;
                return _responseContent;
            } else {
                throw new Exception($"Failed to generate response: {response.StatusCode} {response.ReasonPhrase}");
            }
        }
    }

}
