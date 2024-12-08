using System;
using System.Runtime.Remoting.Messaging;

namespace Parkeci
{
    internal class Kumarhane
    {
        private static string currentLocation;

        private static void DrawMinimap()
        {
            Console.WriteLine("Minimap:");
            Console.WriteLine(currentLocation == "Bar" ? "-> 1. Bar" : "   1. Bar");
            Console.WriteLine(currentLocation == "Kumarhane" ? "-> 2. Casino" : "   2. Casino");
            Console.WriteLine(currentLocation == "Dükkan" ? "-> 3. Shop" : "   3. Shop");
            Console.WriteLine(currentLocation == "Ev" ? "-> 4. Home" : "   4. Home");
            Console.WriteLine(currentLocation == "Taksi Durağı" ? "-> 5. Taxi Stand" : "   5. Taxi Stand");
            Console.WriteLine();
        }

        public static void KumarhaneGir(string oyuncu, ref int para, ref int bagimlilik)
        {
            currentLocation = "Kumarhane";
            while (true)
            {
                Console.Clear();
                DrawMinimap();
                Console.WriteLine($"Welcome {oyuncu}!");
                Console.WriteLine($"{oyuncu}, your current status:");
                Console.WriteLine($"Money: {para}");
                Console.WriteLine($"Gambling Addiction Level: {bagimlilik}\n");
                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine("1. Roll Dice\n2. Flip a Coin\n3. Exit the Casino");

                int secim = SayiGirisiAl(3);

                //case olayını CHATGPT'den aldım.
                //Kumar sistemi bana ait, yönetmesi CHATGPT'den.
                switch (secim)
                {
                    case 1:
                        ZarOyna(ref para, ref bagimlilik);
                        break;
                    case 2:
                        YaziTuraOyna(ref para, ref bagimlilik);
                        break;
                    case 3:
                        Console.WriteLine("Exit the casino...");
                        return;
                }
            }
        }

        private static void ZarOyna(ref int para, ref int bagimlilik)
        {
            Console.Clear();
            Console.WriteLine("You will roll the dice. If you roll a 1, 2, or 3, you lose. If you roll a 4, 5, or 6, you win.");
            int bahis = BahisGir(ref para);

            Random random = new Random();
            int zarSonucu = random.Next(1, 7);
            Console.WriteLine($"Dice Result: {zarSonucu}");

            if (zarSonucu >= 4)
            {
                Console.WriteLine($"Congratulations! You won {bahis}!");
                para += bahis;
            }
            else
            {
                Console.WriteLine($"Unfortunately, you lost {bahis}.");
                para -= bahis;
            }

            bagimlilik++;
            DevamEt();
        }

        private static void YaziTuraOyna(ref int para, ref int bagimlilik)
        {
            Console.Clear();
            Console.WriteLine("You are playing Heads or Tails.Please choose Heads(1) or Tails(2).");

            int secim = SayiGirisiAl(2);
            int bahis = BahisGir(ref para);

            Random random = new Random();
            int sonuc = random.Next(1, 3);
            Console.WriteLine($"Result: {(sonuc == 1 ? "Heads" : "Tails")}");

            if (secim == sonuc)
            {
                Console.WriteLine($"Congratulations! You won {bahis}!");
                para += bahis;
            }
            else
            {
                Console.WriteLine($"Unfortunately, you lost {bahis}.");
                para -= bahis;
            }

            bagimlilik++;
            DevamEt();
        }

        private static int BahisGir(ref int para)
        {
            while (true)
            {
                Console.WriteLine($"Your money is: {para} TL. How much would you like to bet?");
                if (int.TryParse(Console.ReadLine(), out int bahis) && bahis > 0 && bahis <= para)
                {
                    return bahis;
                }

                Console.WriteLine("Please enter a valid bet amount.");
            }
        }

        private static int SayiGirisiAl(int secenekSayisi)
        {
            while (true)
            {
                Console.Write("Make your choice: ");
                if (int.TryParse(Console.ReadLine(), out int secim) && secim >= 1 && secim <= secenekSayisi)
                {
                    return secim;
                }
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        private static void DevamEt()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
