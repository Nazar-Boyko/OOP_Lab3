using laba2.Accounts.States;

namespace laba2.Games.States
{
    public class GameStats
    {

        public string WinnerName { get; set; }
        public string LoserName { get; set; }
        public AccountType WinnerAccType { get; set; }
        public AccountType LoserAccType { get; set; }
        public int WinnerRating { get; set; }
        public int LoserRating { get; set; }
        public int PrevWinnerRating { get; set; }
        public int PrevLoserRating { get; set; }
        public int GameID { get; set; }
        public GameType GameType { get; set; }
    }
}
