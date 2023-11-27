using laba2.Accounts;
using laba2.Games.States;

namespace laba2.Games
{
    public class CrazyGame : Game
    {
        public CrazyGame()
        {
            Type = GameType.Crazy;
        }
        public override int GetRating(BaseAccount player)
        {
            return player.Rating;
        }
    }
}
