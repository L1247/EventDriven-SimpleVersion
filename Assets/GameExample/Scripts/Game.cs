#region

using GameExample.Scripts.Cards;
using Scripts.Custom;
using UnityEngine;

#endregion

namespace GameExample.Scripts
{
    public class Game : Singleton<Game>
    {
        public void StartGame()
        {
            EventBus.Raise<GameStartObserver>(_ => _.OnGameStarted());
        }
    }
}