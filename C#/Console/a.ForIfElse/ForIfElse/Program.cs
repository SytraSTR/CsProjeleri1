namespace ForIfElse
{
    class Program
    {
        public static void Main(string[] args)
        {
            int baslangicDegeri = 0, bitisDegeri = 0;
            Console.Write("Başlangıç değerini giriniz; ");
            baslangicDegeri=Int16.Parse(Console.ReadLine());
            Console.Write("Bitiş değerini giriniz; ");
            bitisDegeri = Int16.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = baslangicDegeri; i <= bitisDegeri ; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Write("\nEnter basarsanız uygulama tekrardan başlar.");
            Console.ReadLine();
            Console.Clear();
            Main(args);
        }
    }
}