using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("Gems", 50000);
    }
    public void pp()
    {
        Application.OpenURL("https://www.google.com/search?q=privacy+policy+vector&rlz=1C1CHZL_enPK943PK943&sxsrf=APq-WBuocC255jlu2ZlNBp0SsZDCLd92lg:1646154054957&source=lnms&tbm=isch&sa=X&ved=2ahUKEwj2k8PdsaX2AhXrxoUKHZNgCN4Q_AUoAXoECAEQAw#imgrc=mJb0626E4abiXM");
    }
    public void rateus()
    {
        Application.OpenURL("https://www.google.com");

    }
}
