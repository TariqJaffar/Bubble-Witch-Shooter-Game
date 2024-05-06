using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundcontroller : MonoBehaviour
{
    public Transform audio;
    private void Start()
    {
        if (PlayerPrefs.GetInt("s") == 0)
        {
            audio.gameObject.SetActive(true);
        }
        else
        {
            audio.gameObject.SetActive(false);

        }
    }
    private void OnEnable()
    {
        if (PlayerPrefs.GetInt("s") == 0)
        {
            audio.gameObject.SetActive(true);
        }
        else
        {
            audio.gameObject.SetActive(false);

        }
    }
    public void soundon()
    {
        audio.gameObject.SetActive(true);
        PlayerPrefs.SetInt("s", 0);
        PlayerPrefs.SetFloat("Music", 1);
        PlayerPrefs.SetInt("Sound", 1);
    }
    public void soundoFF()
    {
        audio.gameObject.SetActive(false);
        PlayerPrefs.SetInt("s", 1);
        PlayerPrefs.SetFloat("Music", 0);
        PlayerPrefs.SetInt("Sound", 0);
    }
}
