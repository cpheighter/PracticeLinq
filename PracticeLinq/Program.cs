using System.Linq;

List<string> videoGames = new List<string>() { "NBA2k", "Minecraft", "Mario Kart", "FIFA", "Madden" };
videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
