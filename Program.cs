using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando nokia:");
Smartphone p1 = new Nokia(numero: "123456", modelo: "SL-1", imei: "0000000", memoria: 12);
p1.Ligar();
p1.InstalarAplicativo("Jogo da Cobrinha");

Console.WriteLine("\n");

Console.WriteLine("Testando iPhone:");
Smartphone p2 = new Iphone(numero: "987654", modelo: "iPhone 14", imei: "999999", memoria: 512);
p2.Ligar();
p2.ReceberLigacao();
p2.InstalarAplicativo("WhatsApp");
p2.InstalarAplicativo("Instagram");