#region

using System;
using Sirenix.OdinInspector;

#endregion

namespace GameExample.Scripts.Cards
{
    [Serializable]
    public class CardData
    {
    #region Public Variables

        [MinValue(0)]
        [LabelText("暴擊機率")]
        public int criticalChance;

        [MinValue(0)]
        [LabelText("傷害值")]
        public int damageAmount;

        [LabelText("Id")]
        public string name;

    #endregion
    }
}