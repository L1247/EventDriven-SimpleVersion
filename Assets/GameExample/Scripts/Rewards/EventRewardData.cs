#region

using System;
using System.Collections.Generic;
using System.Linq;
using GameExample.Scripts.Damage;
using Sirenix.OdinInspector;

#endregion

namespace GameExample.Scripts.Rewards
{
    [HideReferenceObjectPicker]
    public class EventRewardData
    {
    #region Public Variables

        [TypeFilter(nameof(GetConditionDataTypes))]
        public ConditionData conditionData = new EmptyConditionData();

        public DamageType damageType = DamageType.noneCritical;

        [TypeFilter(nameof(GetRewardDataTypes))]
        public RewardData rewardData = new Money();

    #endregion

    #region Private Methods

        private IEnumerable<Type> GetConditionDataTypes()
        {
            var q = typeof(ConditionData).Assembly.GetTypes()
                                         .Where(x => !x.IsAbstract)              // Excludes ConditionData
                                         .Where(x => !x.IsGenericTypeDefinition) // Excludes C1<>
                                         .Where(x => typeof(ConditionData)
                                                       .IsAssignableFrom(x)); // Excludes classes not inheriting from BaseClass

            return q;
        }

        // public IEnumerable<ValueDropdownItem<Type>> GetAllStepDataTypeList()
        // {
        //     return new List<ValueDropdownItem<Type>>()
        //     {
        //         new ValueDropdownItem<Type>("延遲" ,   typeof(StepDelayData)) ,
        //         new ValueDropdownItem<Type>("動作資料" , typeof(StepActionData))
        //     };
        // }
        private IEnumerable<Type> GetRewardDataTypes()
        {
            var q = typeof(RewardData).Assembly.GetTypes()
                                      .Where(x => !x.IsAbstract)              // Excludes RewardData
                                      .Where(x => !x.IsGenericTypeDefinition) // Excludes C1<>
                                      .Where(x => typeof(RewardData)
                                                    .IsAssignableFrom(x)); // Excludes classes not inheriting from BaseClass

            return q;
        }

    #endregion
    }
}