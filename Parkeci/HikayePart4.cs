using System;

namespace Parkeci
{
    internal class HikayePart4
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

        public static void Hikaye4(string oyuncu, ref int para, ref int bagimlilik)
        {
            string currentLocation = "Ev";
            Temizlik();
            DrawMinimap(currentLocation);
            bagimlilik -= 10;
            Console.WriteLine($"{oyuncu}, your current status:");
            Console.WriteLine($"Money: {para}");
            Console.WriteLine($"Gambling Addiction Level: {bagimlilik}\n");

            Sohbet($"{oyuncu}: Yesterday was a very tiring day.");
            Sohbet($"{oyuncu}: The day before that was also tiring.");
            Sohbet($"{oyuncu}: I feel like I wake up to tougher days every passing day.");
            Sohbet($"{oyuncu}: I don't know what to do.");

            currentLocation = "Dükkan";
            Temizlik();
            DrawMinimap(currentLocation);
            Console.WriteLine("An SUV parks right in front of the shop.");
            Sohbet("Five men in suits walk inside.");

            if (ElemanClass.Eleman)
            {
                Temizlik();
                DrawMinimap(currentLocation);
                Console.WriteLine($"{oyuncu}, your current status:");
                Console.WriteLine($"Money: {para}");
                Console.WriteLine($"Gambling Addiction Level: {bagimlilik}\n");

                Sohbet($"Orhan: Are you {oyuncu}?");
                Sohbet($"{oyuncu}: Yes, that's me.");
                Sohbet("Orhan: I've never seen you before, but you must know who I am.");
                Sohbet($"{oyuncu}: Yes, I do. You're Laz Ziya's right-hand man.");
                Sohbet("Orhan: Exactly. I'm here on his behalf.");
                Sohbet($"{oyuncu}: I still have time; I'll pay my debt!");
                Sohbet("Orhan: That's settled. Laz Ziya sends his regards.");
                Sohbet($"{oyuncu}: What do you mean?");
                Sohbet("Orhan: The man you gave a ride to last night is Laz Ziya's son.");
                Sohbet("Orhan: You've done the greatest favor you could for Laz Ziya. Remember that.");
                Sohbet("Orhan: Your debt is cleared. If you have any trouble, Laz Ziya is ready to lend a hand unconditionally. Keep that in mind.");
                Sohbet($"{oyuncu}: I don't know what to say. Really, thank you so much. I'm shocked.");
                Sohbet("Orhan: Alright then, take care.");

                Temizlik();
                DrawMinimap(currentLocation);
                Console.WriteLine($"{oyuncu}, your current status:");
                Console.WriteLine($"Money: {para}");
                Console.WriteLine($"Gambling Addiction Level: {bagimlilik}\n");

                Sohbet($"{oyuncu} jumps with joy and closes the shop to meet Asiye at the bar.");

                AsiyeBar.Son(oyuncu, ref para, ref bagimlilik);
            }
            else if (para >= 225000)
            {
                Temizlik();
                DrawMinimap(currentLocation);
                Console.WriteLine($"{oyuncu}, your current status:");
                Console.WriteLine($"Money: {para}");
                Console.WriteLine($"Gambling Addiction Level: {bagimlilik}\n");

                Sohbet($"Orhan: Are you {oyuncu}?");
                Sohbet($"{oyuncu}: Yes, that's me.");
                Sohbet("Orhan: I've never seen you before, but you must know who I am.");
                Sohbet($"{oyuncu}: Yes, I do. You're Laz Ziya's right-hand man.");
                Sohbet("Orhan: Exactly. I'm here on his behalf.");
                Sohbet($"{oyuncu}: I still have time; I'll pay my debt!");
                Sohbet("Orhan: Laz Ziya's son died last night. He's furious. He wants his debts paid with interest.");
                Sohbet($"{oyuncu}: I'm deeply sorry for your loss, but I was going to pay with interest anyway. I still had time.");
                Sohbet("Orhan: There's more interest now. And time's up. We need 225,000TL. Do you have it or not?");
                Sohbet($"{oyuncu}: Yes, yes. Wait, some of it is in the shop, some in the bank. I need to withdraw it.");
                Sohbet("Orhan: Mesut, Bilal. You accompany the friend. We'll wait in the shop.");

                para -= 225000;

                Temizlik();
                DrawMinimap(currentLocation);
                Console.WriteLine($"{oyuncu}, your current status:");
                Console.WriteLine($"Money: {para}");
                Console.WriteLine($"Gambling Addiction Level: {bagimlilik}\n");

                Sohbet($"{oyuncu} pays off his debt to Laz Ziya. He closes the shop to meet Asiye at the bar.");

                AsiyeBar.Son(oyuncu, ref para, ref bagimlilik);
            }
            else
            {
                Temizlik();
                DrawMinimap(currentLocation);
                Console.WriteLine($"{oyuncu}, your current status:");
                Console.WriteLine($"Money: {para}");
                Console.WriteLine($"Gambling Addiction Level: {bagimlilik}\n");

                Sohbet($"Orhan: Are you {oyuncu}?");
                Sohbet($"{oyuncu}: Yes, that's me.");
                Sohbet("Orhan: I've never seen you before, but you must know who I am.");
                Sohbet($"{oyuncu}: Yes, I do. You're Laz Ziya's right-hand man.");
                Sohbet("Orhan: Exactly. I'm here on his behalf.");
                Sohbet($"{oyuncu}: I still have time; I'll pay my debt!");
                Sohbet("Orhan: Laz Ziya's son died last night. He's furious. He wants his debts paid with interest.");
                Sohbet($"{oyuncu}: I'm deeply sorry for your loss, but I was going to pay with interest anyway. I still had time.");
                Sohbet("Orhan: There's more interest now. And time's up. We need 225,000TL. Do you have it or not?");
                Sohbet($"{oyuncu} No, I don't have that kind of money. If you give me a day or two, I'll find it.");
                Sohbet($"Orhan: Laz Ziya doesn't give an extra day or two. This is the end of the road for you, {oyuncu}.");
                Sohbet($"{oyuncu}: I'll find it by tonight.");

                Temizlik();

                Sohbet($"{oyuncu} couldn't pay off the debt.");
                Sohbet("Laz Ziya's men took all the money from the shop and handed it over to someone else.");
                Sohbet($"{oyuncu} lost his life.");
                Sohbet($"Two years later, {oyuncu}'s ex-wife Asiye married a dentist.");

                Environment.Exit(0);
            }
        }
    }
}
