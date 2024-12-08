using System;

namespace Parkeci
{
    internal class HikayePart2
    {
        private static void Sohbet(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
        }

        private static void Temizlik()
        {
            Console.Clear();
        }

        private static void DrawMinimap(string currentLocation)
        {
            Console.WriteLine("Minimap:");
            Console.WriteLine(currentLocation == "Bar" ? "-> 1. Bar" : "   1. Bar");
            Console.WriteLine(currentLocation == "Kumarhane" ? "-> 2. Casino" : "   2. Casino");
            Console.WriteLine(currentLocation == "Dükkan" ? "-> 3. Shop" : "   3. Shop");
            Console.WriteLine(currentLocation == "Ev" ? "-> 4. Home" : "   4. Home");
            Console.WriteLine(currentLocation == "Taksi Durağı" ? "-> 5. Taxi Stand" : "   5. Taxi Stand");
            Console.WriteLine();
        }

        public static void Hikaye2(string oyuncu, ref int para, ref int bagimlilik)
        {
            string currentLocation = "Ev";
            Temizlik();
            DrawMinimap(currentLocation);
            bagimlilik -= 10;
            Console.WriteLine($"{oyuncu}, your current status:");
            Console.WriteLine($"Money: {para}");
            Console.WriteLine($"Gambling Addiction Level: {bagimlilik}\n");

            Sohbet($"{oyuncu}: Another stupid day begins.");
            Sohbet($"{oyuncu}: I'm too lazy to go to the shop, but Laz Ziya will beat me up.");
            Sohbet($"{oyuncu}: How am I supposed to sell anything in this state...");

            // Dükkan (For personal note)
            Temizlik();
            currentLocation = "Dükkan";
            DrawMinimap(currentLocation);
            Sohbet($"{oyuncu}: First sale done, may God bless it.");
            Sohbet($"{oyuncu}: Still, it's really hard to gather the necessary money in 3 days.");

            Sohbet("A blonde-haired, well-dressed customer enters. What will you do?");

            Console.WriteLine("1. Rip off the customer (earn 20,000 TL)");
            Console.WriteLine("2. Sell at normal price (earn 10,000 TL)");

            int secim = SayiGirisiAl(2);
            if (secim == 1)
            {
                Sohbet("You ripped off the customer and earned 20,000 TL.");
                para += 20000;
            }
            else
            {
                Sohbet("You sold the items at normal price and earned 10,000 TL.");
                para += 10000;
            }

            Temizlik();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Go Home");
            Console.WriteLine("2. Go to Casino");
            Console.WriteLine("3. Take a Taxi");

            secim = SayiGirisiAl(3);

            switch (secim)
            {
                case 1:
                    Temizlik();
                    currentLocation = "Ev";
                    bagimlilik -= 5;
                    DrawMinimap(currentLocation);
                    Sohbet($"{oyuncu}: Made some cash today.");
                    Sohbet($"{oyuncu}: Should I have taken a taxi?");
                    Sohbet($"{oyuncu}: At least I didn't gamble.");
                    Sohbet($"{oyuncu}: Everything is for you, my Asiye.");
                    HikayePart3.Hikaye3(oyuncu, ref para, ref bagimlilik);
                    break;
                case 2:
                    Temizlik();
                    Kumarhane.KumarhaneGir(oyuncu, ref para, ref bagimlilik);
                    currentLocation = "Ev";
                    Temizlik();
                    DrawMinimap(currentLocation);
                    Sohbet($"{oyuncu}: Should I have taken a taxi?");
                    Sohbet($"{oyuncu}: Stupidly lost the money to gambling again.");
                    Sohbet($"{oyuncu}: Oh my Asiye, ohh.");
                    HikayePart3.Hikaye3(oyuncu, ref para, ref bagimlilik);
                    break;
                case 3:
                    Temizlik();
                    currentLocation = "Taksi Durağı";
                    DrawMinimap(currentLocation);
                    Sohbet("You found a few customers with the taxi and earned 15,000 TL by the end of the night.");
                    para += 15000;
                    bagimlilik -= 5;
                    currentLocation = "Ev";
                    Temizlik();
                    DrawMinimap(currentLocation);
                    Sohbet($"{oyuncu}: Made some cash today.");
                    Sohbet($"{oyuncu}: Taking the taxi was a great decision.");
                    Sohbet($"{oyuncu}: And I didn't gamble.");
                    Sohbet($"{oyuncu}: Everything is for you, my Asiye.");
                    HikayePart3.Hikaye3(oyuncu, ref para, ref bagimlilik);
                    break;
            }
        }
        //Yine if else kullanmamak için bunu CHATGPT'den baktım.
        //Efsane değişik bir yöntem.
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
    }
}
