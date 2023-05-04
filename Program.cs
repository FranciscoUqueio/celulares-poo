using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("iPhone: ");
var iphone = new Iphone("258 842033098", 128, "15654658451", "6s");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("FaceTime");

System.Console.WriteLine();

System.Console.WriteLine("Nokia");
var nokia = new Nokia("258 879147914", 32, "32154498798", "Lumia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Waptrick");