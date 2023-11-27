using laba2.Games.States;
using laba2.Handlers;
using laba3.DB.Entity;
using laba3.DB.Repository;
using laba3.DB.Repository.Base;
using laba3.DB.Services.Base;
using laba3.Handlers.Bilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace laba3.DB.Services
{
    public class GameStatsService : IGameStatsService
    {
        private IGameStatsRepository gameStatsRepository;

        public GameStatsService(DbContext context)
        {
            gameStatsRepository = new GameStatsRepository(context);
        }
        public void CreateGame(GameStats gameStats)
        {
            GameStatsEntity gameStatsEntity = SetValues(gameStats);
            gameStatsRepository.Create(gameStatsEntity);
        }

        public List<GameStats> ReadGames()
        {
            return gameStatsRepository.Read().Select(game => Map(game)).ToList();
        }

        public List<GameStats> ReadGamesByPlayerName(string PlayerName)
        {
            var gameStatsEntities = gameStatsRepository
                                        .Read()
                                        .Where(game => game.WinnerName == PlayerName || game.LoserName == PlayerName)
                                        .ToList();

            return gameStatsEntities.Select(game => Map(game)).ToList();
        }

        public GameStats Map(GameStatsEntity stats)
        {
            StatsBilder bilder = new();
            bilder.SetUserName(stats.WinnerName, stats.LoserName);
            bilder.SetUserType(stats.WinnerAccType, stats.LoserAccType);
            bilder.SetCurRating(stats.WinnerRating, stats.LoserRating);
            bilder.SetPrevRating(stats.PrevWinnerRating, stats.PrevLoserRating);
            bilder.SetGeneralValues(stats.GameType, stats.GameID);
            return bilder.Bild();
        }

        private GameStatsEntity SetValues(GameStats gameStats)
        {
            return new()
            {
                WinnerName = gameStats.WinnerName,
                LoserName = gameStats.LoserName,
                WinnerAccType = gameStats.WinnerAccType,
                LoserAccType = gameStats.LoserAccType,
                WinnerRating = gameStats.WinnerRating,
                LoserRating = gameStats.LoserRating,
                PrevWinnerRating = gameStats.PrevWinnerRating,
                PrevLoserRating = gameStats.PrevLoserRating,
                GameID = gameStats.GameID,
                GameType = gameStats.GameType
            };

            
        }
    }
}
