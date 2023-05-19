namespace DoWhile
{
    class Program
    {
        public static void Main(string[] args)
        {
			try
			{
                int i = 0, sayac = 0, yas;
                do
                {
                    Console.Write(i + 1 + ". kişinin yaşı; ");
                    yas = Convert.ToInt16(Console.ReadLine());
                    if (yas >= 20 && yas <= 25)
                    {
                        sayac++;
                    }
                    i++;
                } while (i < 10);
                Console.WriteLine("\n" + sayac + " Kişi askere gidebilir.");
                Console.WriteLine((i - sayac) + " Kişi askere gidemez.");
                Console.Write("\nEnter basarsanız uygulama tekrardan başlar.");
                Console.ReadLine();
                Console.Clear();
                Main(args);
            }
			catch (global::System.Exception hata)
			{
				Console.WriteLine("Bir hata oluştu; " + hata);
                Console.Write("\nEnter basarsanız uygulama tekrardan başlar.");
                Console.ReadLine();
                Console.Clear();
                Main(args);
            }
        }
    }
}