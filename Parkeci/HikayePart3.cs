using System;

namespace Parkeci
{
    internal static class ElemanClass
    {
        public static bool Eleman = false;
    }
    internal class HikayePart3
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

        public static void Hikaye3(string oyuncu, ref int para, ref int bagimlilik)
        {
            string currentLocation = "Ev";
            Temizlik();
            DrawMinimap(currentLocation);
            bagimlilik -= 10;
            Console.WriteLine($"{oyuncu}, your current status:");
            Console.WriteLine($"Money: {para}");
            Console.WriteLine($"Gambling Addiction Level: {bagimlilik}\n");

            Sohbet($"{oyuncu}: Oh God, oh.");
            Sohbet($"{oyuncu}: These days are driving me crazy.");
            Sohbet($"{oyuncu}: Feels like I'm living the same thing every day.");
            Sohbet($"{oyuncu}: God, show me a way out.");

            //Dükkan (kendim için not)
            Temizlik();
            currentLocation = "Dükkan";
            DrawMinimap(currentLocation);
            Console.WriteLine($"{oyuncu}, your current status:");
            Console.WriteLine($"Money: {para}");
            Console.WriteLine($"Gambling Addiction Level: {bagimlilik}\n");

            Sohbet($"{oyuncu}: That customer is coming today.");
            Sohbet($"{oyuncu}: He kept me on the phone for hours. Asked about the price of everything.");
            Sohbet($"{oyuncu}: Said price was important. Look at this guy!");
            Sohbet($"{oyuncu}: Claims he'll buy in bulk, we'll see.");

            Sohbet("A man in a suit, well-groomed, enters the shop.");

            Temizlik();
            DrawMinimap(currentLocation);

            Console.WriteLine("Abdülhey: Hello, we talked on the phone the other day. I'm Abdülhey.");
            Sohbet($"{oyuncu}: Hello sir, welcome. Yes, I remember.");
            Sohbet("Abdülhey: We decided with my wife for our villa. We'll take the cream-colored parquet.");
            Sohbet($"{oyuncu}: As you wish, sir.");

            Sohbet("1. Rip off the customer (earn 150,000 TL)");
            Sohbet("2. Sell at normal price (earn 75,000 TL)");

            int secim1 = SayiGirisiAl(2);
            if (secim1 == 1)
            {
                Sohbet("Abdülhey: Are you kidding me? This wasn't the price you told me over the phone.");
                Sohbet($"{oyuncu}: Prices have increased since then, everything's changed.");
                Sohbet("Abdülhey: It's been at most a week! This much difference doesn't make sense.");
                Console.WriteLine("You couldn't rip off the customer, and he left the shop.");
            }
            else
            {
                Sohbet("You sold the items at normal price and earned 75,000 TL.");
                para += 75000;
            }

            Temizlik();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Go Home");
            Console.WriteLine("2. Go to Casino");
            Console.WriteLine("3. Take a Taxi");

            secim1 = SayiGirisiAl(3);

            switch (secim1)
            {
                case 1:
                    Temizlik();
                    currentLocation = "Ev";
                    bagimlilik -= 5;
                    DrawMinimap(currentLocation);
                    Sohbet($"{oyuncu}: What a hard day. I hope tomorrow will be better.");
                    Sohbet($"{oyuncu}: I miss my Asiye, I miss her so much.");
                    Sohbet($"{oyuncu}: This bed feels so empty without her.");
                    Sohbet($"{oyuncu}: Everything is for you, my Asiye.");
                    HikayePart4.Hikaye4(oyuncu, ref para, ref bagimlilik);
                    break;
                case 2:
                    Temizlik();
                    Kumarhane.KumarhaneGir(oyuncu, ref para, ref bagimlilik);
                    currentLocation = "Ev";
                    Temizlik();
                    DrawMinimap(currentLocation);
                    Sohbet($"{oyuncu}: I didn't take the taxi, but I was so tired.");
                    Sohbet($"{oyuncu}: Lost the money to gambling again like an idiot.");
                    Sohbet($"{oyuncu}: Oh my Asiye, oh.");
                    Sohbet($"{oyuncu}: This bed feels so empty without her.");
                    HikayePart4.Hikaye4(oyuncu, ref para, ref bagimlilik);
                    break;
                case 3:
                    Temizlik();
                    currentLocation = "Taksi Durağı";
                    DrawMinimap(currentLocation);
                    Console.WriteLine("You earned some money and are waiting at the lights.");
                    Console.WriteLine("Suddenly, someone starts knocking on your window.");

                    Sohbet("Stranger: Please, open the door! We need to leave right away.");
                    Sohbet($"{oyuncu}: Wait, what’s going on?");
                    Sohbet("Stranger: They are after me, I’ll explain. Just open the door.");

                    int secim2;
                    while (true)
                    {
                        Console.WriteLine("\nWhat do you want to do?");
                        Console.WriteLine("1. Open the door");
                        Console.WriteLine("2. Step on the gas and leave");

                        if (int.TryParse(Console.ReadLine(), out secim2) && (secim2 == 1 || secim2 == 2))
                        {
                            break;
                        }
                        Console.WriteLine("Invalid choice! Please type 1 or 2.");
                    }

                    if (secim2 == 1)
                    {
                        Sohbet("Stranger: Thank you so much. You saved me.");
                        Sohbet($"{oyuncu}: What are you talking about? Who are you running from?");
                        Sohbet("Stranger: I got involved in things I shouldn't have.");
                        Sohbet("Stranger: Rival gang members were chasing me.");
                        Sohbet($"{oyuncu}: This is crazy, man.");
                        Sohbet("Çakır: You saved a life, don't say that. My name is Çakır.");
                        Sohbet($"{oyuncu}: I'm {oyuncu}. So, where to?");
                        Sohbet("Çakır: Just drop me off at Cadde Bakery.");
                        Sohbet("Çakır: Do you have a card? I won’t forget this favor.");
                        Sohbet($"{oyuncu}: Yes, I do. I'm usually a parquet seller, don't judge.");
                        Sohbet("Çakır: Here's my card too. Call me if you have any trouble.");
                        Sohbet($"{oyuncu}: Thanks.");
                        ElemanClass.Eleman = true;
                    }
                    else if (secim2 == 2)
                    {
                        Sohbet("Stranger: Wait! Stop! Please, stop!");
                        Sohbet($"{oyuncu}: I can't risk getting into trouble this late at night!");
                    }

                    para += 15000;
                    bagimlilik -= 5;
                    currentLocation = "Ev";
                    Temizlik();
                    DrawMinimap(currentLocation);
                    Sohbet($"{oyuncu}: Made some money today.");
                    Sohbet($"{oyuncu}: I'm exhausted, but it was worth it.");
                    Sohbet($"{oyuncu}: That guy was weird, though, almost broke my window.");
                    Sohbet($"{oyuncu}: And I didn’t gamble.");
                    Sohbet($"{oyuncu}: This bed feels so empty without her.");
                    Sohbet($"{oyuncu}: Wait for me, my Asiye.");
                    HikayePart4.Hikaye4(oyuncu, ref para, ref bagimlilik);
                    break;

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
    }
}
