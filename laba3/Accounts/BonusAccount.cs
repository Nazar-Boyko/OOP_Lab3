using laba2.Accounts.States;
using laba2.Games;
using laba2.Games.States;

namespace laba2.Accounts
{
    public class BonusAccount : BaseAccount
    {
        private readonly int MIN_STREAK = 3;
        public int Bonus
        {
            get
            {
                return Streak > MIN_STREAK ? Streak * 2 : 0;
            }
        }
        private int Streak { get; set; } = 0;
        public BonusAccount(string UserName, int rating) : base(UserName, rating)
        {
            Type = AccountType.Bonus;
        }

        public override void WinGame(Game game)
        {
            if (game.Type != GameType.Training) Streak++;
            Rating += Bonus;
            base.WinGame(game);
        }

        public override void LoseGame(Game game)
        {
            if (game.Type != GameType.Training) Streak = 0;
            base.LoseGame(game);
        }
    }
}
