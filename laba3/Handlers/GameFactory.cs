using laba2.Games;
using laba2.Games.States;

namespace laba2.Handlers
{
    public class GameFactory
    {
        public Game CreateGame(GameType type)
        {
            if (type == GameType.Clasic)
            {
                return new ClasicGame();
            }
            else if (type == GameType.Training)
            {
                return new TrainingGame();
            }
            else if (type == GameType.Crazy)
            {
                return new CrazyGame();
            }
            else
            {
                throw new ArgumentException("Непідтримуваний тип гри"); 
            }
        }
    }

}
