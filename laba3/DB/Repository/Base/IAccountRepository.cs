using laba3.DB.Entity;

namespace laba3.DB.Repository.Base
{
    public interface IAccountRepository
    {
        public void Create(AccountEntity account);
        public IEnumerable<AccountEntity> Read();

        public AccountEntity Update(string PlayerName);

        public void Delete(string UserName);

    }
}
