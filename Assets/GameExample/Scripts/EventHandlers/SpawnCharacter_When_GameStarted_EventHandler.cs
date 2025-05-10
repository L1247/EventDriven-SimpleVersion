namespace GameExample.Scripts.EventHandlers
{
    public class SpawnCharacter_When_GameStarted_EventHandler : GameStartObserver
    {
        public void OnGameStarted()
        {
            CharacterController.Instance.CreateCharacter(100);
        }
    }
}