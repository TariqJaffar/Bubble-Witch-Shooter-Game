using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LampManager : MonoBehaviour
{
    public Transform tutorial;
    public string stat1;
    public string stat2;
    public Text text;
    public Image img1;
    public Sprite s1;
    public Sprite s2;
    public Transform InfoPanel;
    public void statment(int s)
    {
        DrawLine.instance.offDrawline();
        tutorial.gameObject.SetActive(true);
        if (s == 0) {
            text.text = stat1;
            img1.sprite = s1;
                }
        else
        {
            text.text = stat2;
            img1.sprite = s2;

        }
    }
    public void infoPanel()
    {
        DrawLine.instance.offDrawline();
        InfoPanel.gameObject.SetActive(true);

    }


}
