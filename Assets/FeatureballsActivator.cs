using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FeatureballsActivator : MonoBehaviour
{
    public Image Mimage;
    public Sprite[] Simg;
    public Text text;

    private void Start()
    {
        if (PlayerPrefs.GetInt("OpenLevel") == 1) 
        {
            Mimage.sprite = Simg[0];
            text.text = "You have open the FireBall" ;
        }

        if (PlayerPrefs.GetInt("OpenLevel") == 3)
        {
            Mimage.sprite = Simg[0];
            text.text = "You have open the LeafBall";
        }

    }


}
