using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaffebeneInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(2);
            }
        }
    }
    public void CaffebeneInstargram()
    {
        Application.OpenURL("https://www.instagram.com/caffebene_official/");
    }
    public void CaffebeneNaver()
    {
        Application.OpenURL("https://m.place.naver.com/restaurant/31318071/home?entry=plt");
    }
    public void FirsthandGameStart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
    public void GoToCaffebeneInfo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(14);
    }
}
