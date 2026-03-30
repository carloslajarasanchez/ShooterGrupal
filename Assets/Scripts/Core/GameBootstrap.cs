using UnityEngine;

public class GameBootstrap : MonoBehaviour
{
    private void Awake()
    {
        // Events
        ServiceLocator.Register(new CustomEvents());

        // Config
        ServiceLocator.Register(new CustomConfiguration());

        // Localization
        ServiceLocator.Register(new I18n());

        // Player model / state
        ServiceLocator.Register(new Player());

        //Input
        ServiceLocator.Register(new PlayerInputManager());
        // Audio database
        var audioDb = Resources.Load<AudioDatabase>(
            "ScriptableObject/AudioDatabase"
        );

        if (audioDb != null)
            audioDb.Initialize();

        ServiceLocator.Register(audioDb);

        // Audio system
        var audioHost = new GameObject("AudioManager");
        DontDestroyOnLoad(audioHost);

        ServiceLocator.Register(new AudioManager(audioHost));
    }
}