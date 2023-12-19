using DesafioCelular.Models;
using System.Text;
using System.Text.Json;
using KeyChatGPT;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo {get; set;}
        private string IMEI {get; set;}
        private int Memoria {get; set;}
        
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    
        public abstract void ChamarAssistenteVirtual();

        protected async void FalarComChatGPT(string mensagem)
        {
            Key key = new Key();

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.openai.com");
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {key.API_KEY}");

            Dictionary<string, string> messagesRequest = new Dictionary<string, string>();
            messagesRequest.Add("role", "user");
            messagesRequest.Add("content", mensagem);

            Dictionary<string, string>[] messagesArray = new Dictionary<string, string>[]
            {
                messagesRequest
            };

            using StringContent json = new(
                    JsonSerializer.Serialize(new
                    {
                        model = "gpt-3.5-turbo",
                        messages = messagesArray,
                    }),
                    Encoding.UTF8,
                    "application/json");

            var responseRequest = await httpClient.PostAsync("v1/chat/completions", json);
            var contentRequest = await responseRequest.Content.ReadAsStringAsync();

            RespostaChatGPT respostaChat = JsonSerializer.Deserialize<RespostaChatGPT>(contentRequest);
            Console.WriteLine(respostaChat.choices[0].message.content);
        }
    }
}