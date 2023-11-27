using laba2.Accounts;
using laba2.Accounts.States;

namespace laba3.Handlers
{
    public class AccountFactory
    {
        public BaseAccount CreateAccount(AccountType type, string UserName, int Rating)
        {
            if (type == AccountType.Basic)
            {
                return new BaseAccount(UserName, Rating);
            }
            else if (type == AccountType.Bonus)
            {
                return new BonusAccount(UserName, Rating);
            }
            else if (type == AccountType.Premium)
            {
                return new PremiumAccount(UserName, Rating);
            }
            else
            {
                throw new ArgumentException("Непідтримуваний тип гри");
            }
        }
    }
}
