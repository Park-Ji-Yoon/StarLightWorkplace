using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMenu : MonoBehaviour
{
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(1);
            }
        }
    }

    public void FirstGame()
    {
        UnityEngine.Debug.Log("시작함");
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void SecondGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(11);
    }
    public void SecondGameStart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(7);
    }
    /*public void ThirdGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void FourthGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }*/
    public void back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
