using laba2.Accounts.States;
using laba2.Games.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.Handlers.Bilder
{
    internal interface IStatsBilder
    {

        void SetUserName(string WinnerName, string LoserName);

        void SetUserType(AccountType WinnerType, AccountType LoserType);

        void SetCurRating(int CurWinnerRating, int CurLoserRating);

        void SetPrevRating(int PrevWinnerRating, int PrevLoserRating);

        void SetGeneralValues(GameType gameType, int GameID);
    }
}
