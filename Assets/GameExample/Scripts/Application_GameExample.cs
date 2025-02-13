#region

using GameExample.Scripts.EventHandlers;
using Scripts.Custom;
using UnityEngine;

#endregion

namespace GameExample.Scripts
{
    public class Application_GameExample : MonoBehaviour
    {
    #region Unity events

        private void Awake()
        {
            NewEventHandlers();
            Game.Instance.StartGame();
        }

    #endregion

    #region Private Methods

        private void NewEventHandlers()
        {
            EventBus.Subscribe<GainReward_When_DamageDealed>();
        }

    #endregion
    }
}