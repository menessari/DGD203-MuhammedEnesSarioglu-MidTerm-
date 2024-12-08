using System;

namespace Parkeci
{
    internal class Baslangic
    {
        public static void Basla()
        {
            Console.WriteLine("Please enter your name:");
            string oyuncu = Console.ReadLine();

            int para = 50000;
            int bagimlilik = 35;
            // I would have used if-else here, but I asked ChatGPT for a shorter solution and got this suggestion.
            Console.WriteLine($"{oyuncu}, welcome to the game! Please answer a few questions before starting. The course of the game will change based on your choices.\n");

            Console.WriteLine("While walking, you see a beggar. Would you financially help him?");
            Console.WriteLine("1. Yes, I would help.\n2. No, I wouldn’t help.\n3. It depends on my situation that day.");
            para += SoruyaCevapAl(3, new int[] { 10000, 20000, 15000 });

            Console.WriteLine("Do you value material wealth?");
            Console.WriteLine("1. Yes\n2. No\n3. Health and faith come before everything.");
            para += SoruyaCevapAl(3, new int[] { 30000, 15000, 35000 });

            Console.WriteLine("Do you think flooring sellers make good money?");
            Console.WriteLine("1. Yes, after all, money is in trade.\n2. No, business owners are struggling.");
            para += SoruyaCevapAl(2, new int[] { 35000, 10000 });

            Console.WriteLine("Have you ever gambled?");
            Console.WriteLine("1. No, I haven’t.\n2. Yes, I have.");
            bagimlilik += SoruyaCevapAl(2, new int[] { 10, 20 });

            Console.WriteLine("If you had extra money right now, would you gamble it?");
            Console.WriteLine("1. Yes, I would.\n2. No, I wouldn’t.");
            bagimlilik += SoruyaCevapAl(2, new int[] { 10, 0 });

            Console.WriteLine("Do you have any addictions? (Gambling, internet, phone, etc.)");
            Console.WriteLine("1. Yes, I do.\n2. No, I don’t.");
            bagimlilik += SoruyaCevapAl(2, new int[] { 10, 0 });

            Hikaye.HikayeAnlat(oyuncu, ref para, ref bagimlilik);
        }
        // Bu olayı CHATGPT'den öğrendim.
        // Ben yapsam if else ile yapacaktım ve çok uzun olurdu.
        private static int SoruyaCevapAl(int secenekSayisi, int[] etkiler)
        {
            int cevap;
            while (true)
            {
                Console.Write("Enter your answer: ");
                if (int.TryParse(Console.ReadLine(), out cevap) && cevap >= 1 && cevap <= secenekSayisi)
                {
                    return etkiler[cevap - 1];
                }
                Console.WriteLine("Invalid option entered. Please try again.");
            }
        }
    }
}
