using laba3.DB.Entity;
using laba3.DB.Repository.Base;

namespace laba3.DB.Repository
{
    public class GameStatsRepository : IGameStatsRepository
    {
        private DbContext context;

        public GameStatsRepository(DbContext context)
        {
            this.context = context;
        }
        public void Create(GameStatsEntity game)
        {
            context.Games.Add(game);
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GameStatsEntity> Read()
        {
            return context.Games;
        }

        public void Update(GameStatsEntity game)
        {
            throw new NotImplementedException();
        }
    }
}
