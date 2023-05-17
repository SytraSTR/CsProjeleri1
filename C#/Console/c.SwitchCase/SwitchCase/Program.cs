namespace SwitchCase
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sayi1, sayi2;
            string islem=" ";
            Console.Write("İşlem Seçiniz; ");
            islem = Console.ReadLine();
            Console.Write("1. Sayıyı giriniz; ");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz; ");
            sayi2 =Convert.ToInt16(Console.ReadLine());
            switch (islem)
            {
                case "+":
                    Console.WriteLine("Sonucunuz(+); " + (sayi1 + sayi2));
                break;
                case"-":
                    Console.WriteLine("Sonucunuz(-); " + (sayi1 - sayi2));
                break;
                case "*":
                    Console.WriteLine("Sonucunuz(*); " + (sayi1 * sayi2));
                break;
                case "/":
                    Console.WriteLine("Sonucunuz(/); " + (sayi1 / sayi2));
                break;
            }
        }
    }
}