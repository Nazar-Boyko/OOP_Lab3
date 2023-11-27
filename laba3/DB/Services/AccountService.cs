using laba2.Accounts;
using laba3.DB.Entity;
using laba3.DB.Repository;
using laba3.DB.Repository.Base;
using laba3.DB.Services.Base;
using laba3.Handlers;
using System.Data;

namespace laba3.DB.Services
{
    public class AccountService : IAccountService
    {
        private IAccountRepository accountRepository;

        public AccountService(DbContext context)
        {
            accountRepository = new AccountRepository(context);
        }
        public void CreateAccount(BaseAccount account)
        {
            AccountEntity player = new();
            player.Name = account.UserName;
            player.Type = account.Type;
            player.Rating = account.Rating;
            accountRepository.Create(player);
        }

        public void DeleteAccountByUserName(string UserName)
        {
            accountRepository.Delete(UserName);
        }

        public List<BaseAccount> ReadAccountByUserName(string UserName)
        {
            List<AccountEntity> accountsEntites = accountRepository
                                                    .Read()
                                                    .Where(account => account.Name == UserName)
                                                    .ToList();
            return accountsEntites.Select(account => Map(account)).ToList();
        }


        public List<BaseAccount> ReadAccounts()
        {
            return accountRepository.Read().Select(account => Map(account)).ToList();

        }

        public void UpdatePlayerName(string PlayerName, string NewName)
        {
            var account = accountRepository.Update(PlayerName);
            account.Name = NewName;
            
        }

        private BaseAccount Map(AccountEntity account)
        {
            AccountFactory factory = new();
            var Account = factory.CreateAccount(account.Type, account.Name, account.Rating);

            return Account;
        }


        

    }
}
