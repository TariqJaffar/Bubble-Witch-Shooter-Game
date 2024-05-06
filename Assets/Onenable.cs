using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Onenable : MonoBehaviour
{
    public Transform lamps;
    public TextMeshProUGUI text;
    public Transform pausecanvas;
    public string Level;
    public Transform[] tooff;
    private void OnEnable()
    {
        lamps.gameObject.SetActive(false);
        pausecanvas.gameObject.SetActive(false);
        for (int i = 0; i < tooff.Length; i++)
        {
            tooff[i].gameObject.SetActive(false);
        }
        if (text != null)
        {
            if (Level == "w")
            {
                if (PlayerPrefs.GetString("Mode") == "f")
                {

                    text.text = "Congratulation You Win !";

                }
                else
                {
                    if (mainscript.Instance.currentLevel == 3 || mainscript.Instance.currentLevel == 6 || mainscript.Instance.currentLevel == 9 || mainscript.Instance.currentLevel == 10)
                    {
                        text.text = "All Owls are saved !";
                    }
                    else
                    {
                        text.text = "Congratulation You Win !";
                    }
                }
            }
            else
            {

            }
        }
    }


    public void Restart()
    {
        SceneManager.LoadScene("game");
    }
}
