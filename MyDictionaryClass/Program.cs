using System;

namespace MyDictionaryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GameDictionary<int, string, string, int, int> games = new GameDictionary<int, string, string, int, int>();
            games.Add(1,"CyberPunk 2077", "10 December 2020",250,9);
            games.Add(2,"Counter Strike Global Offensive", "21 December 2012",80,7);
            games.Add(3,"FIFA 21", "5 October 2020", 80,7);
            games.Read();
        }
    }
}
