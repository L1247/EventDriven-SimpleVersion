#region

using System.Collections.Generic;
using Sirenix.OdinInspector;

#endregion

namespace GameExample.Scripts.Rewards
{
    public class EventRewardSettings : SerializedScriptableObject
    {
    #region Public Variables

        [ListDrawerSettings(CustomAddFunction = nameof(AddNewData))]
        public List<EventRewardData> eventRewardDatas = new List<EventRewardData>();

    #endregion

    #region Private Methods

        private void AddNewData()
        {
            eventRewardDatas.Add(new EventRewardData());
        }

    #endregion
    }
}