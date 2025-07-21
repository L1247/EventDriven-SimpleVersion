#region

using System;

#endregion

namespace GameExample.Scripts.Rewards
{
    public class ConditionMatcher
    {
    #region Public Methods

        public static bool IsConditionMatch(int finalDamage , EventRewardData eventRewardData)
        {
            var conditionMatch = eventRewardData.conditionData switch
            {
                EmptyConditionData                                      => true ,
                CriticalDamageConditionData criticalDamageConditionData => finalDamage >= criticalDamageConditionData.amount ,
                DamageConditionData damageConditionData                 => finalDamage >= damageConditionData.amount ,
                _                                                       => throw new ArgumentOutOfRangeException()
            };
            return conditionMatch;
        }

    #endregion
    }
}