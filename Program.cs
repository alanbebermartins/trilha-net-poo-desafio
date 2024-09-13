using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(45) 98472-7226", modelo: "Nokia G21", imei: "107973957231319", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

// Console.WriteLine("\n");

// Console.WriteLine("Smartphone IPhone:");
// Smartphone iphone = new Iphone(numero: "5678", modelo: "Modelo 16", imei: "263928492", memoria: 256);
// iphone.Ligar();
// iphone.ReceberLigacao();
// iphone.InstalarAplicativo("TikTok");