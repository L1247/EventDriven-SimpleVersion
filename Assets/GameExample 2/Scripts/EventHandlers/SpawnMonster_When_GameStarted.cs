#region

using GameExample_2.Scripts.Events;
using GameExample_2.Scripts.Monsters;

#endregion

namespace GameExample_2.Scripts.EventHandlers
{
    public class SpawnMonster_When_GameStarted : GameStartObserver
    {
    #region Public Methods

        public void OnGameStarted()
        {
            MonsterController.Instance.CreateMonster(100);
        }

    #endregion
    }
}