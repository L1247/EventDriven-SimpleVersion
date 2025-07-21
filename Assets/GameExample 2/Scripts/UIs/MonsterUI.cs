#region

using UnityEngine;
using UnityEngine.UI;

#endregion

namespace GameExample_2.Scripts.UIs
{
    public class MonsterUI : MonoBehaviour
    {
    #region Private Variables

        [SerializeField]
        private Image front;

    #endregion

    #region Public Methods

        public void UpdateHp(int hp , int maxHp)
        {
            front.fillAmount = (float)hp / maxHp;
        }

    #endregion
    }
}