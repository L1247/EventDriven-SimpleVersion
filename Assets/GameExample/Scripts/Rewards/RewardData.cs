#region

using Sirenix.OdinInspector;

#endregion

namespace GameExample.Scripts.Rewards
{
    public abstract class RewardData
    {
        // public int baseField;
    }

    public class Money : RewardData
    {
    #region Public Variables

        [MinValue(0)]
        public int amount;

    #endregion
    }

    public class Exp : RewardData
    {
    #region Public Variables

        [MinValue(0)]
        public int amount;

    #endregion
    }

    public class ExpAndMoney : RewardData /*: Exp , Money*/ /*不要用繼承實現*/
    {
    #region Public Variables

        [MinValue(0)]
        public int exp;

        [MinValue(0)]
        public int money;

    #endregion
    }
}