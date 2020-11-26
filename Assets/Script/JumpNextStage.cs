using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpNextStage : MonoBehaviour
{
    public void NextLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GoToHome()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
    public void LastInfo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(12);
    }
}
