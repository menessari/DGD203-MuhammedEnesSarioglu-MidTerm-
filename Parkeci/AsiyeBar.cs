using System;

namespace Parkeci
{
    internal class AsiyeBar
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

        public static void Son(string oyuncu, ref int para, ref int bagimlilik)
        {
            string currentLocation = "Bar";
            Temizlik();
            DrawMinimap(currentLocation);
            Console.WriteLine($"{oyuncu}, your current status:");
            Console.WriteLine($"Money: {para}");
            Console.WriteLine($"Gambling Addiction Level: {bagimlilik}\n");

            Sohbet($"{oyuncu} enters the bar, sits down, and starts waiting.");
            Sohbet("After a while, Asiye arrives and sits next to them.");
            Sohbet($"Asiye: How are you, {oyuncu}?");
            Sohbet($"{oyuncu}: How do you think I am without you, Asiye? I'm obviously not well. How about you?");
            Sohbet("Asiye: I'm doing fine.");
            Sohbet("Asiye: What about your gambling issue? Have you done anything about it?");

            if (bagimlilik >= 35)
            {
                Temizlik();
                DrawMinimap(currentLocation);
                Console.WriteLine($"{oyuncu}, your current status:");
                Console.WriteLine($"Money: {para}");
                Console.WriteLine($"Gambling Addiction Level: {bagimlilik}\n");

                Sohbet($"{oyuncu}: I quit, I'm clean now. I've wised up.");
                Sohbet("Asiye: So you quit... You ruined our lives, and now you're lying too!");
                Sohbet($"{oyuncu}: What lie, Asiye? I've really quit! I can't live without you!");
                Sohbet("Asiye: Stop! Don't say another word! My brother saw you entering the casino the other day.");
                Sohbet($"{oyuncu}: I was there to pay off my debt.");
                Sohbet("Asiye: You're still lying! What a lowlife you are!");
                Sohbet($"Asiye: I never want to see you again, {oyuncu}!");

                Temizlik();

                Sohbet($"Asiye and {oyuncu} get divorced.");
                Sohbet($"{oyuncu} can no longer gamble even if they want to, as Asiye is always on their mind.");
                Sohbet("Not gambling doesn't change a thing, because Asiye is gone.");
                Sohbet($"{oyuncu} spends all their days drinking with Hasan.");
                Sohbet("Two years later, Asiye marries a dentist.");

                Environment.Exit(0);
            }
            else
            {
                Temizlik();
                DrawMinimap(currentLocation);
                Console.WriteLine($"{oyuncu}, your current status:");
                Console.WriteLine($"Money: {para}");
                Console.WriteLine($"Gambling Addiction Level: {bagimlilik}\n");

                Sohbet($"{oyuncu}: I quit, I'm clean now. I've wised up.");
                Sohbet("Asiye: Yes, it seems like that's true. No one I asked said you've been going.");
                Sohbet($"{oyuncu}: Are you having me followed?");
                Sohbet("Asiye: I don't need to. Your reputation precedes you.");
                Sohbet("Asiye: My brother asked a few people; they said you're not going anymore.");
                Sohbet($"{oyuncu}: Of course I'm not going. You asked me to stop. I'd do anything for you!");
                Sohbet($"{oyuncu}: Please cancel the divorce case, for heaven's sake. Let's live together again.");
                Sohbet("Asiye: Alright, we'll sort it out. I'll move in with you in a few days.");
                Temizlik();
                Sohbet($"{oyuncu} and Asiye reconcile. They talk long into the night.");
                Sohbet("Four days later, Asiye moves in.");
                Sohbet($"{oyuncu} and Asiye live happily ever after.");
                Environment.Exit(0);
            }
        }
    }
}
