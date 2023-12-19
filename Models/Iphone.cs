namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone (string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o {nomeApp} no Iphone");
        }

        public override void ChamarAssistenteVirtual()
        {
            Console.WriteLine("Olá, sou a Siri. Me faça uma pergunta.");
            string perguntaUsuario = Console.ReadLine();
            FalarComChatGPT(perguntaUsuario);
            Console.ReadLine();
        }
    }
}