internal class Program
{
    private static void Main(string[] args)
    {
        // While
        // 1 den başlayarak console dan girilien sayıya kadar sayı dahil ortalama hesaplayıp console a yazdıran program.

        Console.Write("Lütfen bir sayı giriniz");
        int sayı = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;
        while (sayac <= sayı)
        {
            toplam += sayac;
            sayac ++;
        }
        Console.WriteLine(toplam/sayı);

        // 'a' dan 'z' ye kadar tüm harfleri cnsole a yazdırtmak.
        char karakter = 'a';
        while (karakter <'z')
        {
            Console.WriteLine(karakter);
            karakter ++;
        }

        Console.WriteLine("***** Foreach *****");
        string[] arabalar = {"TOGG","Ford","Toyota","Nissan"};

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }

    }
}