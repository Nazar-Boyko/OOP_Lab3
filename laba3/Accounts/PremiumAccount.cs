using laba2.Accounts.States;
using laba2.Games;

namespace laba2.Accounts
{
    class PremiumAccount : BaseAccount
    {
        public PremiumAccount(string UserName, int rating) : base(UserName, rating)
        {
            Type = AccountType.Premium;
        }

        public override void LoseGame(Game game)
        {
            Rating -= game.GetRating(this)/2;
        }
    }
}
