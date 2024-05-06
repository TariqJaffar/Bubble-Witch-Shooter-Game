using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Sceneload",2.5f);
    }

  public void Sceneload()
    {
        SceneManager.LoadScene("menu");
    }
}
