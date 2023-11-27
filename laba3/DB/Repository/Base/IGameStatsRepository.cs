using laba3.DB.Entity;

namespace laba3.DB.Repository.Base
{
    public interface IGameStatsRepository
    {
        public void Create(GameStatsEntity game);
        public IEnumerable<GameStatsEntity> Read();

        public void Update(GameStatsEntity game);

        public void Delete(int ID);

    }
}
