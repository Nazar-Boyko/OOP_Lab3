using laba2.Accounts;
using laba2.Games;
using laba2.Games.States;
using laba3.DB;
using laba3.DB.Services;
using System.Net.NetworkInformation;

namespace laba2.Handlers
{
    public class ShowStats
    {
        public static string GetStats(List<GameStats> History)
        {
            string result = "*------------------------------------------------------------------------------------------------*\n" +
                            "| ID  |  GameType  | Winner   <->     Type |    Rating    | Loser    <->     Type |    Rating    |\n" +
                            "*------------------------------------------------------------------------------------------------*\n";
            foreach (var game in History)
            {
                result +=
                $"| {game.GameID,-3} | {game.GameType,-11}" +
                $"| {game.WinnerName,-10} {game.WinnerAccType,10} " +
                $"| {game.PrevWinnerRating,-4} -> {game.WinnerRating,4} " +
                $"| {game.LoserName,-10} {game.LoserAccType,10} " +
                $"| {game.PrevLoserRating,-4} -> {game.LoserRating,4} |\n";
            }
            result += "*------------------------------------------------------------------------------------------------*\n";
            return result;
        }


        public static string GetStatsForPlayers(string Username, List<GameStats> History)
        {

            string result = $"\t\t\t\t     Game History for {Username}\n";

            result +=  "*------------------------------------------------------------------------------------------------*\n"
                     + "| ID  |  GameType  | Winner   <->     Type |    Rating    | Loser    <->     Type |    Rating    |\n"
                     + "*------------------------------------------------------------------------------------------------*\n";

            foreach (var game in History)
            {
                if (game.WinnerName == Username || game.LoserName == Username)
                {
                    result +=
                    $"| {game.GameID,-3} | {game.GameType,-11}" +
                    $"| {game.WinnerName,-10} {game.WinnerAccType,10} " +
                    $"| {game.PrevWinnerRating,-4} -> {game.WinnerRating,4} " +
                    $"| {game.LoserName,-10} {game.LoserAccType,10} " +
                    $"| {game.PrevLoserRating,-4} -> {game.LoserRating,4} |\n";
                }
            }
            result += "*------------------------------------------------------------------------------------------------*\n";
            return result;
        }
    }

}
