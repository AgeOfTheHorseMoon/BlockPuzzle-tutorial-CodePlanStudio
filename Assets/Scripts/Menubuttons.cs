using UnityEngine;
using UnityEngine.SceneManagement;

public class Menubuttons : MonoBehaviour
{
    private void Awake()
    {
        if (Application.isEditor == false)
            Debug.unityLogger.logEnabled = false;
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
