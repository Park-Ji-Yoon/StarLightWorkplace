using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectEatingFood : MonoBehaviour
{
    public void FirstLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }
    public void SecondLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
    }
    public void ThirdLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }
    public void FourthLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }
}
