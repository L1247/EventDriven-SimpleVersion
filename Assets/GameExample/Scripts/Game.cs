#region

using GameExample.Scripts.Cards;
using Scripts.Custom;
using UnityEngine;

#endregion

namespace GameExample.Scripts
{
    public class Game : Singleton<Game>
    {
    #region Private Variables

        private CardSettings cardSettings;

    #endregion

    #region Public Methods

        public void StartGame()
        {
            foreach (var cardData in cardSettings.cardDatas)
            {
                var cardId         = cardData.name;
                var damageAmount   = cardData.damageAmount;
                var criticalChance = cardData.criticalChance;
                CardController.Instance.CreateCard(cardId , damageAmount , criticalChance);
                CardController.Instance.ExecuteCardEffect(cardId);
            }
        }

    #endregion

    #region Protected Methods

        protected override void CustomInitialize()
        {
            // Debug.Log("Initialize");
            cardSettings = Resources.Load<CardSettings>(nameof(CardSettings));
        }

    #endregion
    }
}