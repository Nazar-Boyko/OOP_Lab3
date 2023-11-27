using laba2.Accounts.States;
using laba2.Games.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.DB.Entity
{
    public class GameStatsEntity
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
