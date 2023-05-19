using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadsceneAll : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("ik ga eruit");
    }

    public void LoadSceneButton()
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("ik ga erheen");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("GOGOGOGO SCENE");
        SceneManager.LoadScene("Eind scene");
    }
}
