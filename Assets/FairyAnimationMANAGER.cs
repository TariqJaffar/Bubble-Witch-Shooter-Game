using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using UnityEngine.SceneManagement;

public class FairyAnimationMANAGER : MonoBehaviour
{
    public Transform fairytalking;
    public Transform fairycircle;
    public Transform witchcircle;
    public TextMeshProUGUI Statement;
    public Transform LoadinPanel;
    public Transform witchArrow;
    public Transform FairyArrow;
void onanimationend()
    {
        FairyArrow.gameObject.SetActive(true);
        fairytalking.gameObject.SetActive(true);
        fairycircle.transform.DOScale(new Vector3(0.6f, 0.6f, 0.6f),0);
        Statement.text = "Anna! Evil Cat kidnapped the fairy Queen!";
    }

  public   void fairyturn()
    {
        witchArrow.gameObject.SetActive(true);
        FairyArrow.gameObject.SetActive(false);
        witchcircle.gameObject.GetComponent<Button>().interactable = true;
        fairycircle.transform.DOScale(new Vector3(0.3f, 0.3f, 0.3f), 0);
        witchcircle.transform.DOScale(new Vector3(0.2f, 0.2f, 0.2f), 0);
        Statement.text = "What? Evil Cat!?? Leave it to me";
    }

  public  void witchturn()
    {
        fairytalking.gameObject.SetActive(false);
        LoadinPanel.gameObject.SetActive(true);
    //    this.gameObject.SetActive(false);
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1.4f);
        SceneManager.LoadScene("map");
    }
    public void jmpsound()
    {
        AudioManager.instance.PlaySound("jmp");
    }  
    public void lazersound()
    {
        AudioManager.instance.PlaySound("lazer");
    }
    public void trapsound()
    {
        AudioManager.instance.PlaySound("trap");
    }
    public void thundersound()
    {
        AudioManager.instance.PlaySound("thunder");
    }
     public void dsmile()
    {
        AudioManager.instance.PlaySound("dsmile");
    }


}
