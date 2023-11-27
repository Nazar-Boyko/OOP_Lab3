using laba2.Accounts;
using laba2.Games.States;
using laba2.Handlers;
using laba3.DB.Services;
using laba3.Handlers.Bilder;

namespace laba2.Games
{
    public abstract class Game
    {
        protected static int GameID = 1;
        public GameType Type { get; protected init; }
        public abstract int GetRating(BaseAccount player);
        public virtual void Play(BaseAccount player1, BaseAccount player2, GameStatsService Service)
        {
            Random random = new();
            int temp = random.Next(0,2);

            int PrevRating1 = player1.Rating;
            int PrevRating2 = player2.Rating;

            if (temp == 0)
            {
                player1.ChengeRanting(this, player2);
                var game_stats = 
                    SetValues(player1, player2, PrevRating1, PrevRating2);

                Service.CreateGame(game_stats);
                GameID++;
            }
            else
            {
                player2.ChengeRanting(this, player1);
                var game_stats = 
                    SetValues(player2, player1, PrevRating2, PrevRating1);

                Service.CreateGame(game_stats);
                GameID++;

            }
        }

        private GameStats SetValues(BaseAccount Winner, BaseAccount Loser, int WinnerPrevRating, int LoserPrevRating)
        {
            StatsBilder bilder = new();
            bilder.SetUserName(Winner.UserName, Loser.UserName);
            bilder.SetUserType(Winner.Type, Loser.Type);
            bilder.SetCurRating(Winner.Rating, Loser.Rating);
            bilder.SetPrevRating(WinnerPrevRating, LoserPrevRating);
            bilder.SetGeneralValues(Type, GameID);

            return bilder.Bild();
        }

    }
}
