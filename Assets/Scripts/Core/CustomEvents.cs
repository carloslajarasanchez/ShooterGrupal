using UnityEngine.Events;

public class CustomEvents
{
    public UnityEvent OnLanguageChanged = new UnityEvent();

    public UnityEvent OnResumeGame = new UnityEvent();
    public UnityEvent OnPauseGame = new UnityEvent();
    public UnityEvent OnPointsChanged = new UnityEvent();
    public UnityEvent OnLivesChanged = new UnityEvent();
    public UnityEvent OnGameOver = new UnityEvent();
    public UnityEvent OnDamageTaken = new UnityEvent();
    public UnityEvent OnPowerUpTaken = new UnityEvent();
    public UnityEvent OnLevelFinished = new UnityEvent();
    public UnityEvent OnSceneLoaded = new UnityEvent();
    public UnityEvent OnShooted = new UnityEvent();
    public UnityEvent OnInventoryChanged = new UnityEvent();
    public UnityEvent OnCatchableDetected = new UnityEvent();
    public UnityEvent OnCatchableLost = new UnityEvent();

    public UnityEvent OnPlayerCrouch = new UnityEvent();
    public UnityEvent OnPlayerStand = new UnityEvent();
}
