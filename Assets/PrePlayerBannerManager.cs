using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PrePlayerBannerManager : MonoBehaviour
{

    public Image MainImage;
    public Sprite OwlImage;
    public Sprite BallImageImage;
    public Sprite GreenColorBall;
    public Sprite BlueColourBall;
    public Sprite fairyball;
    public Sprite bubble;
    public Text TXt;
    void Start()
    {
        if (PlayerPrefs.GetString("Mode") == "f")
        {
            MainImage.sprite = bubble;
            MainImage.SetNativeSize();
            TXt.text = "Shoot The bubbles";
        }
        else
        {

            if (mainscript.Instance.currentLevel == 3 || mainscript.Instance.currentLevel == 6 || mainscript.Instance.currentLevel == 9 || mainscript.Instance.currentLevel == 10)
            {
                MainImage.sprite = OwlImage;
                MainImage.SetNativeSize();
                TXt.text = "Save The Owls";
            }
            else if (mainscript.Instance.currentLevel == 1)
            {
                MainImage.sprite = BallImageImage;
                MainImage.SetNativeSize();

                TXt.text = "Shoot The Colour Ball To Get Power Up";

            }
            else if (mainscript.Instance.currentLevel == 3)
            {
                MainImage.sprite = GreenColorBall;
                MainImage.SetNativeSize();

                TXt.text = "Shoot The Colour Ball To Get Power Up";
            }
            else if (mainscript.Instance.currentLevel == 5)
            {
                MainImage.sprite = GreenColorBall;
                MainImage.SetNativeSize();

                TXt.text = "Shoot The Colour Ball To Get Power Up";
            }
            else
            {
                MainImage.sprite = fairyball;
                MainImage.SetNativeSize();
                MainImage.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                TXt.text = "Save The Fairy From Evil Cat";
            }

        }

    }
}
