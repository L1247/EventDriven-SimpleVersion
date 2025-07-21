namespace GameExample.Scripts.EventHandlers
{
    public class SpawnCharacter_When_GameStarted_EventHandler : GameStartObserver
    {
    #region Public Methods

        public void OnGameStarted()
        {
            CharacterController.Instance.CreateCharacter(100);
        }

    #endregion
    }
}