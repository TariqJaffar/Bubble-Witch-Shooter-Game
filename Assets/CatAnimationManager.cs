using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CatAnimationManager : MonoBehaviour
{
 
    public Transform cat;
    public Transform levelselection;

    public Transform ParentObject;

    private void Start()
    {
       

    
    }

    public void animationEnd()
    {
       
        levelselection.gameObject.SetActive(true);
       // ParentObject.gameObject.SetActive(false);
     //   cat.gameObject.SetActive(false);
    }




}
