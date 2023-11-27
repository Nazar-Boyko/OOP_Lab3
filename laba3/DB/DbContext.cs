using laba2.Accounts.States;
using laba3.DB.Entity;

namespace laba3.DB
{
    public class DbContext
    {
        public List<AccountEntity> Accounts { get; set; }
        public List<GameStatsEntity> Games {get; set;}

        public DbContext()
        {
            Accounts = new()
            {
                new AccountEntity {Name = "Sam", Rating = 100, Type = AccountType.Basic},
                new AccountEntity {Name = "Cody", Rating = 150, Type = AccountType.Basic},
                new AccountEntity {Name = "Denial", Rating = 100, Type = AccountType.Bonus},
                new AccountEntity {Name = "Emily", Rating = 150, Type = AccountType.Bonus},
                new AccountEntity {Name = "Sara", Rating = 100, Type = AccountType.Premium},
                new AccountEntity {Name = "Stacy", Rating = 100, Type = AccountType.Premium}

            };
            Games = new();
        }


    }
}
