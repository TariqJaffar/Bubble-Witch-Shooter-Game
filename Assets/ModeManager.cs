using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ModeManager : MonoBehaviour
{
    public GameObject LoadingPanel;
    public void freeMode(string name)
    {
        PlayerPrefs.SetString("Mode", name);
        LoadingPanel.gameObject.SetActive(true);
        StartCoroutine(wait());
    }
    public void backbutton()
    {
        SceneManager.LoadScene("menu");
    }

IEnumerator wait()
    {
        yield return new WaitForSeconds(1.50f);
        if (PlayerPrefs.GetString("Mode") == "f")
        {
           
            SceneManager.LoadScene("game");
        }
        else
        {
           
            if (PlayerPrefs.GetInt("introduction") == 0)
            {
                PlayerPrefs.SetInt("introduction", 1);
                SceneManager.LoadScene("CatVideo");
            }
            else
            {
                SceneManager.LoadScene("map");
            }
        }
    }

}
