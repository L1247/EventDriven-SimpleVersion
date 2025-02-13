#region

using System.Collections.Generic;
using UnityEngine;

#endregion

namespace GameExample.Scripts.Cards
{
    public class CardSettings : ScriptableObject
    {
    #region Public Variables

        public List<CardData> cardDatas = new List<CardData>();

    #endregion
    }
}