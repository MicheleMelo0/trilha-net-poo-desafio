namespace DesafioCelular.Models
{
    public class Choice
    {
        public Message message { get; set; }
    }

    public class Message
    {
        public string role { get; set; }
        public string content { get; set; }
    }

    public class RespostaChatGPT
    {
        public List<Choice> choices { get; set; }
    }

}