namespace GameExample.Scripts.Damage
{
    public interface DamageObserver
    {
    #region Public Methods

        void OnDamageDealed(bool isCriticalDamage , int finalDamage);

    #endregion
    }
}