#region

using System.Collections.Generic;
using System.Linq;
using GameExample.Scripts.Damage;
using Scripts.Custom;
using UnityEngine;

#endregion

namespace GameExample.Scripts.Rewards
{
    public class EventRewardHandler : Singleton<EventRewardHandler>
    {
    #region Private Variables

        private readonly EventRewardSettings          eventRewardSettings;
        private readonly IEnumerable<EventRewardData> eventRewardDatas;

    #endregion

    #region Constructor

        public EventRewardHandler()
        {
            eventRewardSettings = Resources.Load<EventRewardSettings>(nameof(EventRewardSettings));
            eventRewardDatas    = eventRewardSettings.eventRewardDatas;
        }

    #endregion

    #region Public Methods

        public void HandleDamageReward(bool isCriticalDamage , int finalDamage)
        {
            var damageType = isCriticalDamage ? DamageType.Critical : DamageType.noneCritical;
            var conditionMatchRewardData =
                    eventRewardDatas.Where(data => data.damageType == damageType)
                                    .Where(data => ConditionMatcher.IsConditionMatch(finalDamage , data));
            foreach (var eventRewardData in conditionMatchRewardData)
                GivenPlayerRewardService.GivenPlayerReward(eventRewardData.rewardData);
        }

    #endregion
    }
}