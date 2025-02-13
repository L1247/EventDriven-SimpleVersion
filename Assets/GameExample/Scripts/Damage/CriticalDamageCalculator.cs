#region

using UnityEngine;

#endregion

namespace GameExample.Scripts.Damage
{
    public class CriticalDamageCalculator
    {
    #region Public Methods

        public static bool CalculateCritical(int criticalChance)
        {
            if (criticalChance == 0) return false;
            var randomValue = Random.Range(0 , 100);
            return criticalChance > randomValue;
        }

    #endregion
    }
}