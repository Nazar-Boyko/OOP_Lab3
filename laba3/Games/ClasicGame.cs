using laba2.Accounts;
using laba2.Games.States;

namespace laba2.Games
{
    class ClasicGame : Game
    {
        public ClasicGame()
        {
            Type = GameType.Clasic;
        }
        public override int GetRating(BaseAccount player)
        {
            var rand = new Random();
            return rand.Next(20,30);
        }
    }
}
