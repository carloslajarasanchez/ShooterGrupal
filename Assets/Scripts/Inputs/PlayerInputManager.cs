using UnityEngine.InputSystem;

public sealed class PlayerInputManager
{
    public enum ControlMap
    {
        Player,
        UI
    }
    public PlayerInputActions Actions { get; }

    public PlayerInputManager()
    {
        Actions = new PlayerInputActions();
        Actions.Disable();
    }

    public void SwitchControlMap(ControlMap map)
    {
        Actions.Disable();

        switch (map)
        {
            case ControlMap.Player:
                Actions.Player.Enable();
                break;

            case ControlMap.UI:
                Actions.UI.Enable();
                break;
        }
    }

    public void EnablePlayer()
    {
        SwitchControlMap(ControlMap.Player);
    }

    public void EnableUI()
    {
        SwitchControlMap(ControlMap.UI);
    }

    public void DisableAll()
    {
        Actions.Disable();
    }
}