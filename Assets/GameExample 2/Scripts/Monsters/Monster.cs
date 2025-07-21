#region

using GameExample_2.Scripts.Events;
using Scripts.Custom;
using Sirenix.OdinInspector;
using UnityEngine;

#endregion

namespace GameExample_2.Scripts.Monsters
{
    public class Monster : MonoBehaviour
    {
    #region Public Variables

        public int Hp    { get; private set; }
        public int MaxHp { get; private set; }

    #endregion

    #region Public Methods

        public void Init(int hp)
        {
            MaxHp = hp;
            Hp    = hp;
            EventBus.Raise<MonsterSpawnObserver>(_ => _.OnMonsterSpawned());
        }

    #endregion

    #region Private Methods

        [Button]
        private void TakeDamage(int damage)
        {
            Hp -= damage;
            Debug.Log($"Hp: {Hp}");
            EventBus.Raise<MonsterTakeDamageObserver>(_ => _.OnMonsterDamageTaken());
        }

    #endregion
    }
}