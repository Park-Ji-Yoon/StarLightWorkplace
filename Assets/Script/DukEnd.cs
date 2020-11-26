using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DukEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DukMoreInfo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(13);
    }

    public void GoToHome()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
