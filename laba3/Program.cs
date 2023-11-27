using laba2.Accounts;
using laba2.Games.States;
using laba2.Handlers;
using laba3.DB;
using laba3.DB.Services;

namespace laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbContext context = new();

            GameStatsService gameStatsService = new(context);
            AccountService accountService = new(context);
            var players = accountService.ReadAccounts();


            GameFactory factory = new();
            var rand = new Random();
            for (int i = 0; i < 25; i++)
            {
                var player1 = players[rand.Next(players.Count)];
                var player2 = players.Where(x => x != player1)
                    .ToList()[rand.Next(players.Count - 1)];

                var RandomGame = (GameType)rand.Next(Enum.GetValues(typeof(GameType)).Length);
                var game = factory.CreateGame(RandomGame);

                game.Play(player1, player2, gameStatsService);

            }
            Console.WriteLine("\t\t\t\t\tAll game history");

            Console.WriteLine(ShowStats.GetStats(gameStatsService.ReadGames()));

            var player = players[rand.Next(players.Count)];
            Console.WriteLine(ShowStats.GetStatsForPlayers(player.UserName, gameStatsService.ReadGames()));

        }
    }
}