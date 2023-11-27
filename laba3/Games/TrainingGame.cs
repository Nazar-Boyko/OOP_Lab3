using laba2.Accounts;
using laba2.Games.States;

namespace laba2.Games
{
    class TrainingGame : Game
    {
        public TrainingGame()
        {
            Type = GameType.Training;
        }

        public override int GetRating(BaseAccount player)
        {
            return 0;
        }

    }
}
