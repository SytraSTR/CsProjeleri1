﻿namespace Diziler
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] sinav = new int[3];
            int toplam=0;
            for (int i = 0; i < sinav.Length ; i++) 
            {
                Console.Write(i + 1 + ". Sınav notu; ");
                sinav[i] = Convert.ToInt16(Console.ReadLine());
                toplam += sinav[i];
            }
            Console.WriteLine("Girilen 3 sınavın ortalaması; " + (toplam) / 3);
        }
    }
}