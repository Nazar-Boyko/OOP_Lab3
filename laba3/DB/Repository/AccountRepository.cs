using laba3.DB.Entity;
using laba3.DB.Repository.Base;

namespace laba3.DB.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private DbContext context;

        public AccountRepository(DbContext context)
        {
            this.context = context;
        }

        public void Create(AccountEntity account)
        {
            context.Accounts.Add(account);
        }

        public void Delete(string UserName)
        {
            AccountEntity account = context.Accounts.FirstOrDefault(acc => acc.Name == UserName);

            if (account != null)
            {
                context.Accounts.Remove(account);
            }
            else
            {
                Console.WriteLine("Користувача не знайдено");
            }
        }


        public IEnumerable<AccountEntity> Read()
        {
            return context.Accounts;
        }

        public AccountEntity Update(string playerName)
        {
            var account = context.Accounts.FirstOrDefault(account => account.Name == playerName);
            return account; 
        }   

    }
}
