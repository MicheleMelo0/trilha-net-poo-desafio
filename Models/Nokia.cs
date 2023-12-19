namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia");
        }

        public override void ChamarAssistenteVirtual()
        {
            Console.WriteLine("Olá, sou o Google Assistente. Me faça uma pergunta.");
            string perguntaUsuario = Console.ReadLine();
            FalarComChatGPT(perguntaUsuario);
            Console.ReadLine();
        }
    }
}