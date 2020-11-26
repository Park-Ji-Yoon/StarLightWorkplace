using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL : MonoBehaviour
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
                UnityEngine.SceneManagement.SceneManager.LoadScene(11);
            }
        }
    }
    public void DukURL()
    {
        Application.OpenURL("https://m.place.naver.com/place/1100586279/home");
    }
    public void GoToHome()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
