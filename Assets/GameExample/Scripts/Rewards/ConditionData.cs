#region

using Sirenix.OdinInspector;

#endregion

namespace GameExample.Scripts.Rewards
{
    public abstract class ConditionData { }

    public class EmptyConditionData : ConditionData { }

    public class DamageConditionData : ConditionData
    {
    #region Public Variables

        [MinValue(0)]
        public int amount;

    #endregion
    }

    public class CriticalDamageConditionData : ConditionData
    {
    #region Public Variables

        [MinValue(0)]
        public int amount;

    #endregion
    }
}