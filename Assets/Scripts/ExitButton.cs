using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public static ExitButton Instance { get; private set; }

    [SerializeField] GameObject exitButton;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ShowExitButton()
    {
        exitButton.SetActive(true);
    }

<<<<<<< Updated upstream
    // M�todo para salir de la aplicaci�n    
=======
    // M�todo para mover la aplicaci�n a segundo plano en Android
    public void ExitApplication()
    {
        MoveAndroidApplicationToBack();
    }

>>>>>>> Stashed changes
    public static void MoveAndroidApplicationToBack()
    {
        AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        activity.Call<bool>("moveTaskToBack", true);
    }
}
