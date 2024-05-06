using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MapBackground : MonoBehaviour
{
    public Sprite[] s;
    private void OnEnable()
    {
        if (PlayerPrefs.GetInt("OpenLevel") >=  5) 
        { 
            GetComponent<SpriteRenderer>().sprite = s[0];
        }
    }
}
