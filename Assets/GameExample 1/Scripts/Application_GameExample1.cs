#region

using GameExample.Scripts.EventHandlers;
using Scripts.Custom;
using UnityEngine;

#endregion

namespace GameExample.Scripts
{
    public class Application_GameExample1 : MonoBehaviour
    {
    #region Unity events

        private void Awake()
        {
            BindEventHandlers();
            Game.Instance.StartGame();
        }

    #endregion

    #region Private Methods

        private void BindEventHandlers()
        {
            EventBus.Subscribe<SpawnCharacter_When_GameStarted_EventHandler>();
            EventBus.Subscribe<GainReward_When_DamageDealed>();
        }

    #endregion
    }
}