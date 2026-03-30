using UnityEngine;

public class InitializeGame : MonoBehaviour
{
    private void Awake()
    {
        ServiceLocator.Get<PlayerInputManager>().SwitchControlMap(PlayerInputManager.ControlMap.Player);
    }
}
