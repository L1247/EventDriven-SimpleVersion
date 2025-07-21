#region

using System.Collections.Generic;
using GameExample.Scripts.Damage;
using Scripts.Custom;
using UnityEngine;

#endregion

namespace GameExample.Scripts.Cards
{
    public class CardController : Singleton<CardController>
    {
    #region Private Variables

        private readonly List<Card> cards = new List<Card>();

    #endregion

    #region Public Methods

        public void CreateCard(string cardId , int damageAmount , int criticalChance)
        {
            // 相同ID卡片無法重複建立
            if (IsCardExist(cardId)) return;
            // Debug.Log($"CreateCard: {cardId} , {damageAmount} , {criticalChance}");
            var card = new Card(cardId , damageAmount , criticalChance);
            cards.Add(card);
        }

        public void ExecuteCardEffect(string cardId)
        {
            var isCardExist = IsCardExist(cardId);
            if (isCardExist == false)
            {
                Debug.LogError($"卡片不存在，Card's id [{cardId}]");
                return;
            }

            var card = GetCard(cardId);
            DamageDealer.Instance.DealDamage(card.DamageAmount , card.CriticalChance);
        }

    #endregion

    #region Private Methods

        private Card GetCard(string cardId)
        {
            var getCard = cards.Find(_ => _.Id == cardId);
            return getCard;
        }

        private bool IsCardExist(string cardId)
        {
            return GetCard(cardId) != null;
        }

    #endregion
    }
}