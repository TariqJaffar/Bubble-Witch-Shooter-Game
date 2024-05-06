using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MApBanner : MonoBehaviour
{
    public Text txt;
    public void Start()
    {
		if (PlayerPrefs.GetString("Mode") == "f")
		{

			txt.text = "Shoot The bubbles !";

		}
		else
		{
			if (PlayerPrefs.GetInt("OpenLevel") == 3 || PlayerPrefs.GetInt("OpenLevel") == 6 || PlayerPrefs.GetInt("OpenLevel") == 9 || PlayerPrefs.GetInt("OpenLevel") == 10)
			{
				txt.text = "Save The owl's !";
			}
			else
			{
				txt.text = "Shoot The bubbles !";
			}
		}
	}



}
