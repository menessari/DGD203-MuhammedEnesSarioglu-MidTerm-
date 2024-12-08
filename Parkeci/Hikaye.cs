using System;

namespace Parkeci
{
    internal class Hikaye
    {
        //Sohbet olayını böyle yapmayı CHATGPT'den öğrendim. 
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

        // Minimap için CHATGPT yardım aldım.
        // Daha güzel bir şey bulabilirdim ama zaten CHATGPT ile yaptım o yüzden bu yeterli diye düşündüm.
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

        public static void HikayeAnlat(string oyuncu, ref int para, ref int bagimlilik)
        {
            string currentLocation = "Bar";
            Temizlik();
            DrawMinimap(currentLocation);
            Console.WriteLine($"{oyuncu}, the story begins. Your current status:");
            Console.WriteLine($"Money: {para}");
            Console.WriteLine($"Gambling Addiction Level: {bagimlilik}");

           
            Sohbet($"\nHasan: {oyuncu}, you really deserve a good beating.");
            Sohbet($"{oyuncu}: I'm not happy being stuck in this hellhole either.");
            Sohbet($"Hasan: You’re saying you need to pay off your debt to the loan shark, which is 200,000 TL. You only have {para} TL, what a joke.");
            Sohbet("Hasan: And you need to quit gambling because that’s the only way your wife will drop the divorce case.");
            Sohbet("Hasan: How do you plan to do all of this?");
            Sohbet($"{oyuncu}: If I had a plan, we wouldn’t be sitting here talking about it, Hasan.");
            Sohbet($"{oyuncu}: If you had like 100,000–150,000 TL, that’d be great.");
            Sohbet("Hasan: Even if I had it, I doubt I’d give it to you. You’d just blow it on gambling.");
            Sohbet($"{oyuncu}: Gambling’s not the problem. If I make the money gambling, my wife will leave. If my wife doesn’t leave, the loan shark will kill me.");
            Sohbet("Hasan: It may not help much, but our friend Muammer owns a taxi stand. You know the Akasya Stand in the next neighborhood? That’s his.");
            Sohbet("Hasan: If you want, I can call him and explain your situation. He might let you work nights and only charge for gas.");
            Sohbet($"{oyuncu}: That’d be amazing, Hasan. Would you do that for me?");
            Sohbet("Hasan: Stop quoting cheesy movie lines. At least you might pay off your debt, and maybe next time I won’t be coming to your funeral.");
            Sohbet($"{oyuncu}: So, will you give him a call?");
            Sohbet("Hasan: Alright, hang on a sec.");

            Temizlik();
            DrawMinimap(currentLocation);
            Sohbet("Hasan: Done. He says you can start driving tonight, but I wouldn’t go drunk. The car’s 34 TUT 61 and is available from 9 PM to 9 AM.");
            Sohbet($"{oyuncu}: Thanks a lot, Hasan. I don’t know how I’ll repay you.");
            Sohbet("Hasan: Just don’t die. I gotta go; the wife’s waiting at home.");
            Sohbet($"{oyuncu}: Wish I had someone waiting for me at home.");
            Sohbet("Hasan: Don’t worry. Once you get through this, there’s a solution to everything. See you.");
            Sohbet($"{oyuncu}: See you.");

            Temizlik();

            while (true)
            {
                DrawMinimap(currentLocation);
                Console.WriteLine("Options:");
                Console.WriteLine("1. Go Home");
                Console.WriteLine("2. Start Taxi Work");
                Console.WriteLine("3. Go to the Casino");

                Console.Write("Make your choice: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Temizlik();
                    currentLocation = "Ev";
                    DrawMinimap(currentLocation);
                    bagimlilik -= 5;
                    Sohbet($"{oyuncu}: Another stupid day is over.");
                    Sohbet($"{oyuncu}: Will my wife, my Asiye, forgive me?");
                    Sohbet($"{oyuncu}: How am I going to pay off Laz Ziya?");
                    HikayePart2.Hikaye2(oyuncu, ref para, ref bagimlilik);
                    break;
                }
                else if (input == "2")
                {
                    Temizlik();
                    currentLocation = "Taxi Stand";
                    DrawMinimap(currentLocation);
                    Sohbet($"{oyuncu}: Hello, I’m {oyuncu}. Is Mr. Muammer here?");
                    Sohbet($"Selim: Hi, I’m Selim. Muammer’s not here, what do you need?");
                    Sohbet($"{oyuncu}: I’m supposed to start working tonight with the 34 TUT 61 car for the first time.");
                    Sohbet($"Selim: Ah, right, I remember now. Muammer called me, I know about it.");
                    Sohbet($"Selim: Here’s the key, the car’s over there.");
                    Sohbet($"{oyuncu}: Thanks a lot, brother.");
                    Temizlik();
                    currentLocation = "Taxi Stand";
                    Sohbet($"{oyuncu}: Nobody’s coming at this hour. Guess I’ll just drive around.");
                    Sohbet($"{oyuncu}: How am I going to get my wife back? Asiye, forgive me.");
                    Temizlik();
                    currentLocation = "Taxi Stand";
                    Sohbet("The car's headlights were dim, and the road lighting was poor. Nothing was visible in the dark of night.");
                    Sohbet($"{oyuncu}, while driving his taxi sadly and drunk, hit an electric pole due to poor visibility.");
                    Sohbet($"{oyuncu} lost his life.");
                    Sohbet($"Two years later, {oyuncu}'s ex-wife Asiye married a dentist.");
                    Environment.Exit(0);
                }
                else if (input == "3")
                {
                    Temizlik();
                    Kumarhane.KumarhaneGir(oyuncu, ref para, ref bagimlilik);
                    currentLocation = "Ev";
                    Temizlik();
                    DrawMinimap(currentLocation);
                    Sohbet($"{oyuncu}: Another stupid day is over.");
                    Sohbet($"{oyuncu}: Will my wife, my Asiye, forgive me?");
                    Sohbet($"{oyuncu}: If I keep gambling like this, she definitely won’t.");
                    Sohbet($"{oyuncu}: How am I going to pay off Laz Ziya?");
                    HikayePart2.Hikaye2(oyuncu, ref para, ref bagimlilik);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}
