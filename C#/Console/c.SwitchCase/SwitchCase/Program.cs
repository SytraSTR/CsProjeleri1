namespace SwitchCase
{
    class Program
    {
        public static void Main(string[] args)
        {
			try
			{
                Double sayi1, sayi2;
                string islem = " ";
                Console.Write("İşlem Seçiniz; ");
                islem = Console.ReadLine();
                Console.Write("1. Sayıyı giriniz; ");
                sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("2. Sayıyı giriniz; ");
                sayi2 = Convert.ToDouble(Console.ReadLine());
                switch (islem)
                {
                    case "+":
                        Console.WriteLine("\nSonucunuz(+); " + (sayi1 + sayi2));
                        break;
                    case "-":
                        Console.WriteLine("\nSonucunuz(-); " + (sayi1 - sayi2));
                        break;
                    case "*":
                        Console.WriteLine("\nSonucunuz(*); " + (sayi1 * sayi2));
                        break;
                    case "/":
                        Console.WriteLine("\nSonucunuz(/); " + (sayi1 / sayi2));
                        break;
                }
                Console.Write("\nEnter basarsanız uygulama tekrardan başlar.");
                Console.ReadLine();
                Console.Clear();
                Main(args);
            }
			catch (Exception hata)
			{
				Console.WriteLine("Bir hata gerçekleşti; " + hata);
                Console.Write("\nEnter basarsanız uygulama tekrardan başlar.");
                Console.ReadLine();
                Console.Clear();
                Main(args);
            }
        }
    }
}