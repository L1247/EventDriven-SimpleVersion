#region

using System;
using UnityEngine;

#endregion

namespace GameExample.Scripts.Rewards
{
    public class GivenPlayerRewardService
    {
    #region Public Methods

        public static void GivenPlayerReward(RewardData rewardData)
        {
            Debug.Log($"獲得獎勵：{rewardData.GetType()}");
            switch (rewardData)
            {
                case Exp exp :
                    PlayerController.Instance.GainExp(exp.amount);
                    break;
                case ExpAndMoney expAndMoney :
                    PlayerController.Instance.GainMoney(expAndMoney.money);
                    PlayerController.Instance.GainExp(expAndMoney.exp);
                    break;
                case Money money :
                    PlayerController.Instance.GainMoney(money.amount);
                    break;
                default : throw new ArgumentOutOfRangeException();
            }
        }

    #endregion
    }
}