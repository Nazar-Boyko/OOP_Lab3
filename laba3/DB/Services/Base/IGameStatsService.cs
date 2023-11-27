using laba2.Games.States;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.DB.Services.Base
{
    public interface IGameStatsService
    {
        public void CreateGame(GameStats gameStats);
        public List<GameStats> ReadGames();
        public List<GameStats> ReadGamesByPlayerName(string PlayerName);

    }
}
