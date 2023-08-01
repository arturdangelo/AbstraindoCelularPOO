
using Celular.Models;

namespace Celular;
public class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");
        
        Console.WriteLine();

        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "222", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");

    }
}