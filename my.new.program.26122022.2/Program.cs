  //Puan Ortalaması Hesaplama
internal class Program
{
    static void Main(string[] args)
    {
        int vize1, vize2, final;

        Console.Write("Vize Puanı : ");
        vize1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Vize Puanı : ");
        vize2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Final Puanı : ");
        final = Convert.ToInt32(Console.ReadLine());

        double ortalama = (vize1 * 0.2) + (vize2 * 0.3) + (final * 0.5);
        Console.WriteLine("Ortalama Puanınız : " + " " + (double)ortalama);

        if (ortalama >= 50)
        {
            Console.WriteLine("Geçtiniz.");
        }
        else if (ortalama >= 50)
        {
            Console.WriteLine("Kaldınız.");
        }

        Console.ReadKey();
    }
}
