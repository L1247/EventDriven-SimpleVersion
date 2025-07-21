namespace GameExample.Scripts.Cards
{
    public class Card
    {
    #region Public Variables

        public int    CriticalChance { get; }
        public int    DamageAmount   { get; }
        public string Id             { get; }

    #endregion

    #region Constructor

        public Card(string id , int damageAmount , int criticalChance)
        {
            Id             = id;
            DamageAmount   = damageAmount;
            CriticalChance = criticalChance;
        }

    #endregion
    }
}