#region

using Scripts.Custom;
using UnityEngine;

#endregion

namespace GameExample_2.Scripts.Monsters
{
    public class MonsterController : Singleton<MonsterController>
    {
    #region Private Variables

        private Monster monsterPrefab;
        private Monster monster;

    #endregion

    #region Public Methods

        public void CreateMonster(int hp)
        {
            monster = Object.Instantiate(monsterPrefab);
            monster.Init(hp);
        }

        public MonsterHpInfo GetHpInfo()
        {
            return new MonsterHpInfo() { Hp = monster.Hp , maxHp = monster.MaxHp };
        }

    #endregion

    #region Protected Methods

        protected override void CustomInitialize()
        {
            monsterPrefab = Resources.Load<Monster>(nameof(Monster));
        }

    #endregion
    }
}