using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    public void NextLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GoToHome()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
    public void CafeURL()
    {
        Application.OpenURL("https://m.place.naver.com/restaurant/31318071/home?entry=plt");
    }
    public void CaffeBeneSite()
    {
        Application.OpenURL("http://www.caffebene.co.kr/");
    }
}
