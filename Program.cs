using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "123456", modelo: "Modelo 1", imei:"1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone (numero: "4987", modelo: "Modelo 2", imei:"2222222222", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");