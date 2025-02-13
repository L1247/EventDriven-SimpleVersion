#region

using Scripts.Custom;
using UnityEngine;

#endregion

namespace GameExample.Scripts
{
    public class PlayerController : Singleton<PlayerController>
    {
    #region Private Variables

        private int exp;
        private int money;

    #endregion

    #region Public Methods

        public void GainExp(int amount)
        {
            var lastExp = exp;
            exp += amount;
            Debug.Log($"last: {lastExp} , amount {amount} , current exp: {exp} ");
        }

        public void GainMoney(int amount)
        {
            var lastMoney = money;
            money += amount;
            Debug.Log($"last: {lastMoney} , amount {amount} , current money: {money} ");
        }

    #endregion
    }
}