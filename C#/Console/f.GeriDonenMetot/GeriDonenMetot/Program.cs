namespace GeriDonenMetot
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.Write("1. Sayıyı giriniz; ");
            sayi1=Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz; ");
            sayi2 =Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nToplam; " + Toplam(sayi1, sayi2));
            Console.Write("\nEnter basarsanız uygulama tekrardan başlar.");
            Console.ReadLine();
            Console.Clear();
            Main(args);
        }
        public static int Toplam(int sayi1,int sayi2)
        {
            return (sayi1 + sayi2);
        }
    }
}