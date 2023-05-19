namespace OverLoadMetot
{   
    class Program
    {
        static int Ortalama(int sayi1, int sayi2)
        {
            int sonuc = (sayi1 + sayi2) / 2;
            return sonuc;
        }

        static int Ortalama(int sayi1, int sayi2, int sayi3)
        {
            int sonuc = (sayi1 + sayi2 + sayi3) / 2;
            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Ortalama(13, 5));
            Console.WriteLine(Ortalama(13, 8, 7));
            Console.ReadKey();
        }
    }
}