using laba2.Accounts.States;
using laba2.Games;

namespace laba2.Accounts
{
    public class BaseAccount
    {
        public string UserName { get; set; }
        public AccountType Type { get; set; } = AccountType.Basic;

        private int rating;
        public int Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value < 1 ? 1 : value;
            }
        }

        public BaseAccount(string UserName, int rating)
        {
            this.UserName = UserName;
            this.rating = rating;
        }

        public void ChengeRanting(Game game, BaseAccount loser)
        {
            WinGame(game);
            loser.LoseGame(game);
        }
        public virtual void WinGame(Game game)
        {
            Rating += game.GetRating(this);
        }

        public virtual void LoseGame(Game game)
        {
            Rating -= game.GetRating(this);
        }

        
    }
}
