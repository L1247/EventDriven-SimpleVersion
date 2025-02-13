#region

using Scripts.Custom;

#endregion

namespace GameExample.Scripts.Damage
{
    public class DamageDealer : Singleton<DamageDealer>
    {
    #region Public Methods

        public void DealDamage(int damageAmount , int criticalChance)
        {
            var isCritical = CriticalDamageCalculator.CalculateCritical(criticalChance);
            // 暴擊 兩倍傷害
            var finalDamage = isCritical ? damageAmount * 2 : damageAmount;
            // Debug.Log($"DealDamage: finalDamage: {finalDamage} , isCritical: {isCritical} , damageAmount: {damageAmount}");
            EventBus.Raise<DamageObserver>(_ => _.OnDamageDealed(isCritical , finalDamage));
        }

    #endregion
    }
}