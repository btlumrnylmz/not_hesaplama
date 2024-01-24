using System;

class Islemler
{
    // ORT_Hesapla metodu
    public static double OrtalamaHesapla(double vize, double final)
    {
        double ortalama = (vize * 0.4) + (final * 0.6);
        return ortalama;
    }

    // Donustur metodu
    public static int NotuDonustur(double not)
    {
        double karsilik = not / 20;
        return (int)karsilik;
    }
}

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Öğrenci {i} için Vize Notunu Giriniz: ");
            double vize = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Öğrenci {i} için Final Notunu Giriniz: ");
            double final = Convert.ToDouble(Console.ReadLine());

            double ortalama = Islemler.OrtalamaHesapla(vize, final);

            int karsilik = Islemler.NotuDonustur(ortalama);

            Console.WriteLine($"Öğrenci {i} için Not Ortalaması: {ortalama}");
            Console.WriteLine($"Öğrenci {i} için 5'lik Not Karşılığı: {karsilik}\n");
        }
    }
}
