using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("=== Basit Hesap Makinası ===");

        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = double.Parse(Console.ReadLine());

        Console.Write("Işlemi seçin (+, -, *, /): ");
        string islemi = Console.ReadLine();

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = double.Parse(Console.ReadLine());

        double sonuc = 0;
        bool isValid = true;

        switch (islemi)
        {
            case "+":
                sonuc = sayi1 + sayi2;
                break;
            case "-":
                sonuc = sayi1 - sayi2;
                break;
            case "*":
                sonuc = sayi1 * sayi2;
                break;
            case "/":
                if (sayi2 == 0)
                {
                    Console.WriteLine("Hata: Sıfıra bölme yapılamaz!");
                    isValid = false;
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                }
                break;
            default:
                Console.WriteLine("Hata: Geçersiz işlem!");
                isValid = false;
                break;
        }

        if (isValid)
        {
            Console.WriteLine($"\nSonuç: {sayi1} {islemi} {sayi2} = {sonuc}");
        }
    }
}
