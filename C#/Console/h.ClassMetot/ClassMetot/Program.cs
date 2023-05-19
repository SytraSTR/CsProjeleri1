namespace ClassMetot
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] sayi = new int[3];
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.Write((i + 1) + ". Sayıyı giriniz; ");
                sayi[i] = Convert.ToInt16(Console.ReadLine());
            }
            Hesapla hesapla = new Hesapla(sayi[0], sayi[1], sayi[2]);
            hesapla.Yazdir();
            Console.Write("\nEnter basarsanız uygulama tekrardan başlar.");
            Console.ReadLine();
            Console.Clear();
            Main(args);
        }
    }
    class Hesapla
    {
        public int Sayi1, Sayi2, Sayi3;
        public Hesapla(int sayi1, int sayi2, int sayi3)
        {
            this.Sayi1 = sayi1;
            this.Sayi2 = sayi2;
            this.Sayi3 = sayi3;
        }
        public void Yazdir()
        {
            Console.Write("\nOrtalama; " + (Sayi1 + Sayi2 + Sayi3)/3);
        }
    }
}