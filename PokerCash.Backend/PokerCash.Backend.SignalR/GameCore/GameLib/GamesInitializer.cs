namespace PokerCash.Backend.SignalR.GameCore.GameLib;

public static class GamesInitializer
{
    public static IEnumerable<Game> GetGames() => new[]
    {
        new Game("Fun Table 1 - Lvl 1"),
        new Game("Fun Table 2 - Lvl 1"),
        new Game("Fun Table 3 - Lvl 1"),
        new Game("Fun Table 1 - Lvl 2", 500),
        new Game("Fun Table 2 - Lvl 2", 500),
        new Game("Fun Table 3 - Lvl 2", 500),
        new Game("Fun Table 1 - Lvl 3", 1000),
        new Game("Fun Table 2 - Lvl 3", 1000),
        new Game("Fun Table 3 - Lvl 3", 1000),
        new Game("Fun Table 1 - Lvl 4", 5000),
        new Game("Fun Table 2 - Lvl 4", 5000),
        new Game("Fun Table 3 - Lvl 4", 5000),
        new Game("Fun Table 1 - Lvl 5", 10000),
        new Game("Fun Table 2 - Lvl 5", 10000),
        new Game("Fun Table 3 - Lvl 5", 10000),
    };
}