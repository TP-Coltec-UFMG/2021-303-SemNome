using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
