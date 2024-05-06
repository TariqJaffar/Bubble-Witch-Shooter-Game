using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndManager : MonoBehaviour
{
    public Transform Thunder;
    public Transform particlesblast;
    public Transform winning;
    public Transform cat;
    void Start()
    {
        if (mainscript.Instance.currentLevel == 10)
        {
            if (PlayerPrefs.GetString("Mode") == "f")
            {
                winning.gameObject.SetActive(true);

            }
            else
            {
                cat.gameObject.SetActive(true);
            }
        }

    }
    public void enndGame()
    {
        Thunder.gameObject.SetActive(true);
        StartCoroutine(wait());
    }
 
   
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);

        particlesblast.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        cat.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        Thunder.gameObject.SetActive(false);
        winning.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
