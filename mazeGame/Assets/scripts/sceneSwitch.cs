using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string sceneName;
    public static int takenScore;
    private void Update()
    {
        //0 is left, 1 is right, 2 is middle
        if (Input.GetMouseButtonDown(0))
        {
            SwitchScene();
        }
    }
    public void SwitchScene()
    {
        //SceneManager.LoadScene(sceneName);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = 0;
        if(currentSceneIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = currentSceneIndex + 1;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
}
