using DesafioPOO.Models;
using Microsoft.Win32.SafeHandles;


//criando IPhone
Console.WriteLine("Smartphone Iphone:");

        Iphone iphone = new Iphone("123456789", "iPhone X", "IMEI123", 64);

        iphone.Ligar();
        iphone.ReceberLigacao();

        iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

        Console.WriteLine("Smartphone Nokia:");
        Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI456", 16);

        nokia.Ligar();
        nokia.ReceberLigacao();

        nokia.InstalarAplicativo("PLants Vs Zombies");