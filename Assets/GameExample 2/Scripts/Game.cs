#region

using GameExample_2.Scripts.Events;
using Scripts.Custom;

#endregion

namespace GameExample_2.Scripts
{
    public class Game : Singleton<Game>
    {
    #region Public Methods

        public void StartGame()
        {
            EventBus.Raise<GameStartObserver>(_ => _.OnGameStarted());
        }

    #endregion
    }
}