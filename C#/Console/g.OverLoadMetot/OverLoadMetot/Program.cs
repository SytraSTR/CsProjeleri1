namespace OverLoadMetot
{   
    class Program
    {
        static int ortalama(int sayi1, int sayi2)
        {
            int sonuc = (sayi1 + sayi2) / 2;
            return sonuc;
        }

        static int ortalama(int sayi1, int sayi2, int sayi3)
        {
            int sonuc = (sayi1 + sayi2 + sayi3) / 2;
            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ortalama(13, 5));
            Console.WriteLine(ortalama(13, 8, 7));
            Console.ReadKey();
        }
    }
}