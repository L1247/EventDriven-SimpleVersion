#region

using GameExample_2.Scripts.EventHandlers;
using Scripts.Custom;
using UnityEngine;

#endregion

namespace GameExample_2.Scripts
{
    public class Application_GameExample2 : MonoBehaviour
    {
    #region Unity events

        private void Awake()
        {
            Bind_EventHandlers();
            Game.Instance.StartGame();
        }

    #endregion

    #region Private Methods

        private void Bind_EventHandlers()
        {
            EventBus.Subscribe<SpawnMonster_When_GameStarted>();
            EventBus.Subscribe<SpawnMonsterUI_When_MonsterSpawned>();
            EventBus.Subscribe<UpdateHpUI_When_MonsterDamageTaken>();
        }

    #endregion
    }
}