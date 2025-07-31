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
            // 找到指定怪物資料的血量
            MonsterController.Instance.CreateMonster(100);
        }

    #endregion
    }
}