#region

using GameExample_2.Scripts.Events;
using GameExample_2.Scripts.UIs;
using UnityEngine;

#endregion

namespace GameExample_2.Scripts.EventHandlers
{
    public class SpawnMonsterUI_When_MonsterSpawned : MonsterSpawnObserver
    {
    #region Public Methods

        public void OnMonsterSpawned()
        {
            var monsterUI = Resources.Load<MonsterUI>(nameof(MonsterUI));
            Object.Instantiate(monsterUI);
        }

    #endregion
    }
}