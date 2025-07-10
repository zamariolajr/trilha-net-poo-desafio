using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia!!!");
Smartphone cel1 = new Nokia(numero: "32518188", modelo: "tijorola", imei: "123456789", memoria: 12);
cel1.Ligar();
cel1.InstalarAplicativo("X");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone!!!");
Smartphone cel2 = new Iphone(numero: "32519877", modelo: "xv", imei: "178923456", memoria: 128);
cel2.Ligar();
cel2.InstalarAplicativo("Tradingview");