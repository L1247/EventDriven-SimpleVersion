#region

using GameExample.Scripts.Damage;
using GameExample.Scripts.Rewards;
using UnityEngine;

#endregion

namespace GameExample.Scripts.EventHandlers
{
    public class GainReward_When_DamageDealed : DamageObserver
    {
    #region Public Methods

        public void OnDamageDealed(bool isCriticalDamage , int finalDamage)
        {
            Debug.Log($"OnDamageDealed - isCriticalDamage: {isCriticalDamage} , finalDamage: {finalDamage}");
            EventRewardHandler.Instance.HandleDamageReward(isCriticalDamage , finalDamage);
        }

    #endregion
    }
}