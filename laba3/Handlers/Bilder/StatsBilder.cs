using laba2.Accounts.States;
using laba2.Games.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.Handlers.Bilder
{
    public class StatsBilder : IStatsBilder
    {
        private GameStats GameStats;

        public StatsBilder()
        {
            GameStats = new();
        }
        public void SetUserName(string WinnerName, string LoserName)
        {
            GameStats.WinnerName = WinnerName;
            GameStats.LoserName = LoserName;
        }
        public void SetUserType(AccountType WinnerAccType, AccountType LoserAccType)
        {
            GameStats.WinnerAccType = WinnerAccType;
            GameStats.LoserAccType = LoserAccType;
        }

        public void SetCurRating(int WinnerRating, int LoserRating)
        {
            GameStats.WinnerRating = WinnerRating;
            GameStats.LoserRating = LoserRating;
        }
        public void SetPrevRating(int PrevWinnerRating, int PrevLoserRating)
        {
            GameStats.PrevWinnerRating = PrevWinnerRating;
            GameStats.PrevLoserRating = PrevLoserRating;
        }

        public void SetGeneralValues(GameType gameType, int GameID)
        {
            GameStats.GameType = gameType;
            GameStats.GameID = GameID;
        }

        public GameStats Bild()
        {
            return GameStats;
        }
    }
}
