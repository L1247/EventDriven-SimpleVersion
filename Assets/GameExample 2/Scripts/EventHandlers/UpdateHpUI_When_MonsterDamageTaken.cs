#region

using GameExample_2.Scripts.Events;
using GameExample_2.Scripts.Monsters;
using GameExample_2.Scripts.UIs;
using UnityEngine;

#endregion

namespace GameExample_2.Scripts.EventHandlers
{
    public class UpdateHpUI_When_MonsterDamageTaken : MonsterTakeDamageObserver
    {
    #region Public Methods

        public void OnMonsterDamageTaken()
        {
            var monsterHpInfo = MonsterController.Instance.GetHpInfo();
            var monsterUI     = Object.FindObjectOfType<MonsterUI>();
            monsterUI.UpdateHp(monsterHpInfo.Hp , monsterHpInfo.maxHp);
        }

    #endregion
    }
}