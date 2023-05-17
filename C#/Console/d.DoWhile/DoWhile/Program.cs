namespace DoWhile
{
    class Program
    {
        public static void Main(string[] args) 
        {
            int i = 0, sayac = 0, yas;
            do
            {
                Console.Write(i + 1 + ". kişinin yaşı; ");
                yas = Convert.ToInt16(Console.ReadLine());
                if (yas>=20&&yas<=25)
                {
                    sayac++;
                }
                i++;
            } while (i<10);
            Console.WriteLine(sayac + " Kişi askere gidebilir.");
            Console.WriteLine(i - sayac + " Kişi askere gidemez.");
        }
    }
}