using DesafioPOO.Models;

Nokia nokia = new Nokia("111111111", "Nokia C20", "0000000000", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
nokia.ChamarAssistenteVirtual();

Console.WriteLine("-------------\n");

Iphone iphone = new Iphone("222222222", "Iphone 14", "333333333", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
iphone.ChamarAssistenteVirtual();