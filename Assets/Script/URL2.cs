using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL2 : MonoBehaviour
{
    public void DukURL()
    {
        Application.OpenURL("https://m.place.naver.com/place/1100586279/home");
    }
    public void GoToHome()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
